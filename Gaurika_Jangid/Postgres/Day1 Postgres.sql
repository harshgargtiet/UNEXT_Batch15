CREATE TABLE emp (empno int primary key, ename varchar(20), address varchar(20), city varchar(20), phno int);

drop table emp;

INSERT INTO emp (empno, ename, address, city, phno) VALUES
    (101, 'John Doe', '123 Main St', 'New York', 1234),
    (102, 'Jane Smith', '456 Elm St', 'Los Angeles', 9876),
    (103, 'Robert Johnson', '789 Oak St', 'Chicago', 5551),
    (104, 'Emily Williams', '234 Pine St', 'Houston', 8885),
    (105, 'Michael Brown', '567 Maple St', 'Miami', 3339),
    (106, 'Jessica Davis', '890 Cedar St', 'San Francisco', 44422),
    (107, 'William Anderson', '345 Walnut St', 'Seattle', 7774),
    (108, 'Samantha Martinez', '678 Birch St', 'Dallas', 6661),
    (109, 'David Garcia', '901 Spruce St', 'Boston', 2223),
    (110, 'Olivia Wilson', '123 Cherry St', 'Atlanta', 1114);

SELECT * FROM emp;

explain analyze select * from emp where phno = '1114'

create index ind_emp_phno on emp(phno);

insert into emp (empno, ename, address, city, phno) values (111, 'Tony', '123 cherry st', 'New York', '1234');

select indexname, indexdef from pg_indexes where tablename = 'emp';

drop procedure insert_emp;

CREATE OR REPLACE PROCEDURE insert_emp(
    p_empno int, p_ename varchar(20), p_address varchar(30), p_city varchar(20), p_phno int
) AS $$
BEGIN
    INSERT INTO emp (empno, ename, address, city, phno)
    VALUES (p_empno, p_ename, p_address, p_city, p_phno);
END;
$$ LANGUAGE plpgsql;

CALL insert_emp(113, 'Alice Brown', '789 Maple St', 'Denver', 5555);

select * from emp;


CREATE OR REPLACE FUNCTION finsert_emp(
    f_empno int, f_ename varchar(20), f_address varchar(30), f_city varchar(20), f_phno int
) RETURNS void AS $$
BEGIN
    INSERT INTO emp (empno, ename, address, city, phno)
    VALUES (f_empno, f_ename, f_address, f_city, f_phno);
END;
$$ LANGUAGE plpgsql;

CALL insert_emp(112, 'Alice', '789 Earth St', 'Denver', 55);

select * from emp;


-----------------------------------

CREATE TABLE products (
    product_id serial PRIMARY KEY,
    product_name varchar(50),
    category varchar(50),
    price numeric(10, 2)
);

INSERT INTO products (product_name, category, price)
VALUES
    ('Product A', 'Electronics', 299.99),
    ('Product B', 'Clothing', 49.99),
    ('Product C', 'Home Appliances', 199.00),
    ('Product D', 'Electronics', 159.50),
    ('Product E', 'Books', 15.99),
    ('Product F', 'Beauty', 29.95),
    ('Product G', 'Home Appliances', 349.00),
    ('Product H', 'Clothing', 79.50),
    ('Product I', 'Electronics', 599.00),
    ('Product J', 'Toys', 12.49);
	
select * from products;

CREATE OR REPLACE PROCEDURE update_product(
    p_product_id int,
    p_product_name varchar(50),
    p_category varchar(50),
    p_price numeric(10, 2)
) AS $$
BEGIN
    UPDATE products
    SET
        product_name = p_product_name,
        category = p_category,
        price = p_price
    WHERE product_id = p_product_id;
END;
$$ LANGUAGE plpgsql;

CALL update_product(1, 'Updated Product A', 'Electronics', 349.99);

select * from products;


CREATE OR REPLACE FUNCTION get_products_by_category(
    p_category varchar(50)
) RETURNS TABLE (
    product_id int,
    product_name varchar(50),
    category varchar(50),
    price numeric(10, 2)
) AS $$
BEGIN
    RETURN QUERY
    SELECT p.product_id, p.product_name, p.category, p.price
    FROM products p
    WHERE p.category = p_category;
END;
$$ LANGUAGE plpgsql;

SELECT * FROM get_products_by_category('Electronics');

=======================

triggers

trigger that automatically updates the category column of the products table whenever 
the price of a product is updated to be greater than a certain threshold. set the category
to 'Premium' for products with a price greater than 500.

CREATE OR REPLACE FUNCTION update_category_trigger_function()
RETURNS TRIGGER AS $$
BEGIN
    IF NEW.price > 500 THEN
        NEW.category = 'Premium';
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER update_category_trigger
BEFORE UPDATE ON products
FOR EACH ROW
EXECUTE FUNCTION update_category_trigger_function();

select * from products;

UPDATE products SET price = 600 WHERE product_id = 1;

select * from products;

