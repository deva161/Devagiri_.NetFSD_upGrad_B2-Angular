use EcommAppDb

SELECT 
    CONCAT(product_name, ' (', model_year, ')') AS product_details,
    product_name,
    model_year,
    list_price,
    
    list_price - (
        SELECT AVG(list_price)
        FROM products p2
        WHERE p2.category_id = p1.category_id
    ) AS price_difference

FROM products p1

WHERE list_price > (
        SELECT AVG(list_price)
        FROM products p2
        WHERE p2.category_id = p1.category_id
);

