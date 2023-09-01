create table emp(empno int primary key, ename varchar(20), address varchar(30), city varchar(20), phno int);
INSERT INTO emp (empno, ename, address, city, phno) VALUES
    (101, 'John Doe', '123 Main St', 'New York', 1234),
    (102, 'Jane Smith', '456 Elm St', 'Los Angeles', 9876),
    (103, 'Robert Johnson', '789 Oak St', 'Chicago', 5551),
    (104, 'Emily Williams', '234 Pine St', 'Houston', 8885),
    (105, 'Michael Brown', '567 Maple St', 'Miami', 3339),
    (106, 'Jessica Davis', '890 Cedar St', 'San Francisco', 4442),
    (107, 'William Anderson', '345 Walnut St', 'Seattle', 7774),
    (108, 'Samantha Martinez', '678 Birch St', 'Dallas', 6661),
    (109, 'David Garcia', '901 Spruce St', 'Boston', 2223),
    (110, 'Olivia Wilson', '123 Cherry St', 'Atlanta', 1114);
	
SELECT * FROM EMP WHERE phNO = '898989';
explain SELECT * FROM EMP WHERE phNO = '898989';


Explain analyze select * from EMP where phNO = '1114';

create index idx_emp_phno on emp(phno);

INSERT INTO emp (empno, ename, address, city, phno) VALUES
    (111, 'John', '123 Main St', 'New York', 4324);

select indexname, indexdef from pg_indexes where tablename ='emp';

CREATE UNIQUE INDEX idx_employees_mobile_phone
ON emp(phno);

insert into emp (empno, ename, address, city, phno)values 
(112, 'Robert Johnson', '789 Oak St', 'Chicago', 3333);

select * from Emp;

Create index idx_emp_name
on emp(lower(ename));

select * from emp where ename = 'Robert Johnson';

CREATE OR REPLACE PROCEDURE insert_emp(
    p_empno int, p_ename varchar(20), p_address varchar(30), p_city varchar(20), p_phno int
) AS $$
BEGIN
    INSERT INTO emp (empno, ename, address, city, phno)
    VALUES (p_empno, p_ename, p_address, p_city, p_phno);
END;
$$ LANGUAGE plpgsql;

CALL insert_emp(191, 'Alice Brown', '789 Maple St', 'Denver', 5555);


CREATE OR REPLACE FUNCTION insert_emp(
    p_empno int, p_ename varchar(20), p_address varchar(30), p_city varchar(20), p_phno int
) RETURNS void AS $$
BEGIN
    INSERT INTO emp (empno, ename, address, city, phno)
    VALUES (p_empno, p_ename, p_address, p_city, p_phno);
END;
$$ LANGUAGE plpgsql;

CALL insert_emp(119, 'Alice', '789 Earth St', 'Denver', 55);

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


