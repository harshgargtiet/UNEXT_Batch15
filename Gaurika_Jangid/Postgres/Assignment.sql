
select * from products;

select * from orders;

--Create a stored procedure named place_order that allows customers to place orders. 
CREATE OR REPLACE PROCEDURE place_order(
    IN p_customer_id INT,
    IN p_product_ids VARCHAR(20),
    IN p_quantities VARCHAR(20)
) AS $$
BEGIN
    DECLARE v_product_id INT;
    DECLARE v_quantity INT;
    DECLARE v_stock_quantity INT;
    DECLARE v_order_id INT;
END;
$$ LANGUAGE plpgsql;
----

--Create a function named get_total_price that calculates the total price of an order based on the products and quantities.
CREATE OR REPLACE FUNCTION get_total_price() RETURNS numeric(10, 2) AS $$
DECLARE v_total_price DECIMAL(10,2);
BEGIN
    SET v_total_price = 0;
    SELECT SUM(p.price * o.quantity) INTO v_total_price
    FROM products p
    INNER JOIN order_details o ON p.product_id = o.product_id
    WHERE o.order_id = p_order_id;
    
    RETURN v_total_price;
END;
$$ LANGUAGE plpgsql;
----


--Create a trigger named update_order_status_trigger that automatically updates the order status to "Shipped" when the stock quantity for all ordered products is sufficient.
-----
CREATE OR REPLACE TRIGGER update_order_status_trigger
AFTER INSERT ON order_details
$$ BEGIN
    DECLARE v_order_id INT;
    DECLARE v_order_status VARCHAR(255);
    
    SET v_order_id = NEW.order_id;
    
    SELECT COUNT(*) INTO v_order_status
    FROM order_details
    INNER JOIN products p ON order_details.product_id = p.product_id
    WHERE order_details.order_id = v_order_id
    AND p.stock_quantity >= order_details.quantity;
    
    IF v_order_status = 0 THEN
        UPDATE orders
        SET order_status = 'Shipped'
        WHERE order_id = v_order_id;
    END IF;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER check_stock_trigger
BEFORE UPDATE ON books
FOR EACH ROW
EXECUTE FUNCTION check_stock_trigger_function();