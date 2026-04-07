USE ecommappdb;
GO

CREATE TRIGGER trg_reduce_stock_after_insert
ON order_items
AFTER INSERT
AS
BEGIN

    BEGIN TRY

        -- Check if stock is insufficient
        IF EXISTS (
            SELECT 1
            FROM inserted i
            JOIN orders o ON i.order_id = o.order_id
            JOIN stocks s ON s.product_id = i.product_id 
                         AND s.store_id = o.store_id
            WHERE s.quantity < i.quantity
        )
        BEGIN
            RAISERROR ('Stock insufficient. Order cannot be placed.',16,1);
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Reduce stock
        UPDATE s
        SET s.quantity = s.quantity - i.quantity
        FROM stocks s
        JOIN inserted i ON s.product_id = i.product_id
        JOIN orders o ON i.order_id = o.order_id
        WHERE s.store_id = o.store_id;

    END TRY

    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH

END
GO


-- transaction

BEGIN TRANSACTION;

INSERT INTO orders
(order_id, customer_id, order_status, order_date, required_date, store_id, staff_id)
VALUES
(2001, 5, 1, GETDATE(), DATEADD(day,7,GETDATE()), 1, 2);

INSERT INTO order_items
(item_id, order_id, product_id, quantity, list_price, discount)
VALUES
(1, 2001, 5, 2, 1500, 0.10),
(2, 2001, 7, 1, 800, 0.05);

COMMIT TRANSACTION;

-- Verify stock
SELECT *
FROM stocks
WHERE product_id IN (5,7);