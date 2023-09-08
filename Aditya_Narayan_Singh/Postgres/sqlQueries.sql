-- create table emp(empno int primary key, ename varchar(20), address varchar(30), city varchar(20), phno int);
-- INSERT INTO emp (empno, ename, address, city, phno) VALUES
--     (101, 'John Doe', '123 Main St', 'New York', 1234),
--     (102, 'Jane Smith', '456 Elm St', 'Los Angeles', 9876),
--     (103, 'Robert Johnson', '789 Oak St', 'Chicago', 5551),
--     (104, 'Emily Williams', '234 Pine St', 'Houston', 88855),
--     (105, 'Michael Brown', '567 Maple St', 'Miami', 33399),
--     (106, 'Jessica Davis', '890 Cedar St', 'San Francisco', 4441),
--     (107, 'William Anderson', '345 Walnut St', 'Seattle', 77744),
--     (108, 'Samantha Martinez', '678 Birch St', 'Dallas', 66611),
--     (109, 'David Garcia', '901 Spruce St', 'Boston', 22233),
--     (110, 'Olivia Wilson', '123 Cherry St', 'Atlanta', 1114);

-- SELECT * FROM EMP
-- WHERE phNO = '66611';

-- explain analyze SELECT * FROM EMP
-- WHERE phNO = '66611';

-- CREATE INDEX idx_emp_phno ON EMP(phno);
-- (
--     column_name [ASC | DESC] [NULLS {FIRST | LAST }],
--     ...
-- );


-- SELECT indexname, indexdef
-- FROM   pg_indexes
-- WHERE   tablename = 'emp';

-- CREATE TABLE people(
--     id INT GENERATED BY DEFAULT AS IDENTITY,
--     first_name VARCHAR(50) NOT NULL,
--     last_name VARCHAR(50) NOT NULL
-- );


-- CREATE INDEX idx_people_names 
-- ON people (last_name, first_name);

-- INSERT INTO people(first_name,last_name)
-- VALUES('Tillie','Bell'),
-- ('Marie','Lloyd'),
-- ('John','Lyons'),
-- ('Lucas','Gray'),
-- ('Edward','May');

-- explain SELECT   *
-- FROM    people
-- WHERE  last_name = 'Gray'
-- AND first_name = 'Lucas';


-- CREATE OR REPLACE PROCEDURE insert_emp(
--     p_empno int, p_ename varchar(20), p_address varchar(30), p_city varchar(20), p_phno int
-- ) AS $$
-- BEGIN
--     INSERT INTO emp (empno, ename, address, city, phno)
--     VALUES (p_empno, p_ename, p_address, p_city, p_phno);
-- END;
-- $$ LANGUAGE plpgsql;

-- CALL insert_emp(111, 'Alice Brown', '789 Maple St', 'Denver', 5555);


-- CREATE OR REPLACE FUNCTION insert_emp1(
--     p_empno int, p_ename varchar(20), p_address varchar(30), p_city varchar(20), p_phno int
-- ) RETURNS void AS $$
-- BEGIN
--     INSERT INTO emp (empno, ename, address, city, phno)
--     VALUES (p_empno, p_ename, p_address, p_city, p_phno);
-- END;
-- $$ LANGUAGE plpgsql;

-- CALL insert_emp1(112, 'Alice', '789 Earth St', 'Denver', 55);


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

-- CREATE OR REPLACE PROCEDURE update_product(
--     p_product_id int,
--     p_product_name varchar(50),
--     p_category varchar(50),
--     p_price numeric(10, 2)
-- ) AS $$
-- BEGIN
--     UPDATE products
--     SET
--         product_name = p_product_name,
--         category = p_category,
--         price = p_price
--     WHERE product_id = p_product_id;
-- END;
-- $$ LANGUAGE plpgsql;

-- CALL update_product(1, 'Updated Product A', 'Electronics', 349.99);

-- select * from products;


-- CREATE OR REPLACE FUNCTION get_products_by_category(
--     p_category varchar(50)
-- ) RETURNS TABLE (
--     product_id int,
--     product_name varchar(50),
--     category varchar(50),
--     price numeric(10, 2)
-- ) AS $$
-- BEGIN
--     RETURN QUERY
--     SELECT p.product_id, p.product_name, p.category, p.price
--     FROM products p
--     WHERE p.category = p_category;
-- END;
-- $$ LANGUAGE plpgsql;

-- SELECT * FROM get_products_by_category('Electronics');