CREATE TABLE products (
    product_id serial PRIMARY KEY,
    product_name varchar(50),
    price numeric(10, 2),
	stock_quantity int
);

CREATE TABLE orders (
    order_id serial PRIMARY KEY,
    customer_id varchar(50),
    order_date date,
	order_status varchar(50)
);

INSERT INTO products (product_name, price, stock_quantity)
VALUES
    ('Product A', 299.99,600),
    ('Product B', 49.99,800),
    ('Product C', 199.00,1000),
    ('Product D', 159.50,300),
    ('Product E', 15.99,200),
    ('Product F', 29.95,600),
    ('Product G', 349.00,500),
    ('Product H', 79.50,400),
    ('Product I', 599.00,200),
    ('Product J', 12.49,100);
INSERT INTO orders ( customer_id,order_date, order_status)
VALUES
(123,'2016-3-4','pending'),
(213,'2017-5-16','pending'),
(313,'2016-12-9','shipped'),
(456,'2020-11-5','pending'),
(897,'2021-1-1','shipped');

CREATE OR REPLACE PROCEDURE place_order(
    p_customer_id varchar(100),
    p_product_id integer [],
    p_quantities integer []
) AS $$
BEGIN
	var d =select current_date ;
	for i in 1..array_length(p_product_id,1) LOOP
    INSERT INTO orders (customer_id, order_date, order_status)
    VALUES (p_customer_id, p_product_id[i],d, 'pending');
	update products set stock_quantity= stock-quantity-p_quantities[i]
	where product_id = p-product_id[i];
	end loop;
END;
$$ LANGUAGE plpgsql;

select * from products

select * from orders

CALL place_order('313',Array[4,5], Array[100,1000]);