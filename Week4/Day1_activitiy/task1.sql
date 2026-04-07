use EcommAppDb
- --Create a stored procedure to generate total sales amount per store.
CREATE PROCEDURE sp_TotalSalesPerStore
AS
BEGIN
    SELECT 
        s.store_id,
        s.store_name,
        SUM(oi.quantity * oi.list_price) AS Total_Sales
    FROM stores s
    JOIN orders o ON s.store_id = o.store_id
    JOIN order_items oi ON o.order_id = oi.order_id
    GROUP BY s.store_id, s.store_name
    ORDER BY Total_Sales DESC;
END 

EXEC sp_TotalSalesPerStore;

--Create a stored procedure to retrieve orders by date range.
CREATE PROCEDURE sp_GetOrdersByDateRange
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    SELECT 
        order_id,
        customer_id,
        order_date,
        order_status,
        store_id
    FROM orders
    WHERE order_date BETWEEN @StartDate AND @EndDate
    ORDER BY order_date;
END

EXEC sp_GetOrdersByDateRange '2023-01-01', '2023-12-31';

--Create a scalar function to calculate total price after discount.

CREATE FUNCTION fn_CalculateDiscountPrice
(
    @Price DECIMAL(10,2),
    @DiscountPercent DECIMAL(5,2)
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @FinalPrice DECIMAL(10,2)

    IF @DiscountPercent IS NULL
        SET @DiscountPercent = 0

    SET @FinalPrice = @Price - (@Price * @DiscountPercent / 100)

    RETURN @FinalPrice
END

SELECT 
product_name,
list_price,
dbo.fn_CalculateDiscountPrice(list_price,10) AS DiscountPrice
FROM products;

- --Create a table-valued function to return top 5 selling products.
CREATE FUNCTION fn_Top5SellingProducts()
RETURNS TABLE
AS
RETURN
(
    SELECT TOP 5
        p.product_id,
        p.product_name,
        SUM(oi.quantity) AS TotalSold
    FROM products p
    JOIN order_items oi ON p.product_id = oi.product_id
    GROUP BY p.product_id, p.product_name
    ORDER BY TotalSold DESC
)

SELECT * FROM dbo.fn_Top5SellingProducts();