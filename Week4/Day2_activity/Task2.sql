USE ecommappdb;
GO
 -- order cancellation with savepoint 
 
CREATE PROCEDURE cancel_order_atomic
    @p_order_id INT
AS
BEGIN

    BEGIN TRY

        BEGIN TRANSACTION;

        -- Savepoint before stock restoration
        SAVE TRANSACTION before_stock_restore;

        -- Restore stock quantities
        UPDATE s
        SET s.quantity = s.quantity + oi.quantity
        FROM stocks s
        JOIN orders o ON o.store_id = s.store_id
        JOIN order_items oi ON oi.product_id = s.product_id
        WHERE oi.order_id = @p_order_id
        AND o.order_id = @p_order_id;

        -- If stock restoration fails rollback to savepoint
        IF @@ROWCOUNT = 0
        BEGIN
            ROLLBACK TRANSACTION before_stock_restore;
            RAISERROR ('Stock restoration failed.',16,1);
            RETURN;
        END

        -- Update order status to Rejected (3)
        UPDATE orders
        SET order_status = 3
        WHERE order_id = @p_order_id;

        COMMIT TRANSACTION;

        SELECT 'Order cancelled successfully and stock restored.' AS message;

    END TRY

    BEGIN CATCH

        ROLLBACK TRANSACTION;

        SELECT 
        ERROR_MESSAGE() AS ErrorMessage;

    END CATCH

END
GO

-- execute procedure

EXEC cancel_order_atomic 2001;

-- verify order status
SELECT order_id, order_status
FROM orders
WHERE order_id = 2001;

-- verify stock restoration

SELECT product_id, store_id, quantity
FROM stocks
WHERE product_id IN
(
    SELECT product_id
    FROM order_items
    WHERE order_id = 2001
);