use EcommAppDb

CREATE TRIGGER trg_UpdateStockAfterOrder
ON order_items
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        -- Check if stock is enough
        IF EXISTS (
            SELECT 1
            FROM stocks s
            JOIN inserted i ON s.product_id = i.product_id
            JOIN orders o ON i.order_id = o.order_id
            WHERE s.store_id = o.store_id
            AND s.quantity < i.quantity
        )
        BEGIN
            THROW 50001, 'Stock is insufficient for this order.', 1;
        END

        -- Update stock
        UPDATE s
        SET s.quantity = s.quantity - i.quantity
        FROM stocks s
        JOIN inserted i ON s.product_id = i.product_id
        JOIN orders o ON i.order_id = o.order_id
        WHERE s.store_id = o.store_id;

    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        DECLARE @ErrorMessage NVARCHAR(4000)
        SET @ErrorMessage = ERROR_MESSAGE()

        RAISERROR(@ErrorMessage,16,1)
    END CATCH
END

SELECT name
FROM sys.triggers;

sp_helptext 'trg_UpdateStockAfterOrder'

