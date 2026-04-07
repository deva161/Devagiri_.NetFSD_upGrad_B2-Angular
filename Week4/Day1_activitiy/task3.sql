use EcommAppDb
BEGIN TRY

BEGIN TRANSACTION

-- Temporary table to store order revenue
CREATE TABLE #OrderRevenue
(
    order_id INT,
    store_id INT,
    revenue DECIMAL(12,2)
)

-- Variables for cursor
DECLARE @order_id INT
DECLARE @store_id INT
DECLARE @revenue DECIMAL(12,2)

-- Cursor declaration
DECLARE order_cursor CURSOR FOR
SELECT order_id, store_id
FROM orders
WHERE order_status = 4

-- Open cursor
OPEN order_cursor

-- Fetch first row
FETCH NEXT FROM order_cursor INTO @order_id, @store_id

WHILE @@FETCH_STATUS = 0
BEGIN

    -- Calculate revenue for current order
    SELECT @revenue = SUM(quantity * list_price * (1 - discount))
    FROM order_items
    WHERE order_id = @order_id

    -- Handle NULL
    IF @revenue IS NULL
        SET @revenue = 0

    -- Insert into temporary table
    INSERT INTO #OrderRevenue
    VALUES (@order_id, @store_id, @revenue)

    -- Fetch next row
    FETCH NEXT FROM order_cursor INTO @order_id, @store_id

END

-- Close cursor
CLOSE order_cursor
DEALLOCATE order_cursor

-- Store wise revenue summary
SELECT 
    store_id,
    SUM(revenue) AS Total_Revenue
FROM #OrderRevenue
GROUP BY store_id
ORDER BY store_id

COMMIT TRANSACTION

END TRY

BEGIN CATCH

ROLLBACK TRANSACTION

PRINT ERROR_MESSAGE()

END CATCH