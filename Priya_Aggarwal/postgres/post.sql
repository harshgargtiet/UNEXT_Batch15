-- create table emp(empno int primary key, ename varchar(20), address varchar(30), city varchar(20), phno int);

-- INSERT INTO emp (empno, ename, address, city, phno) VALUES
--     (101, 'John Doe', '123 Main St', 'New York', 1234),
--     (102, 'Jane Smith', '456 Elm St', 'Los Angeles', 9876),
--     (103, 'Robert Johnson', '789 Oak St', 'Chicago', 5551),
--     (104, 'Emily Williams', '234 Pine St', 'Houston', 8885),
--     (105, 'Michael Brown', '567 Maple St', 'Miami', 3339),
--     (106, 'Jessica Davis', '890 Cedar St', 'San Francisco', 4442),
--     (107, 'William Anderson', '345 Walnut St', 'Seattle', 7774),
--     (108, 'Samantha Martinez', '678 Birch St', 'Dallas', 6661),
--     (109, 'David Garcia', '901 Spruce St', 'Boston', 2223),
--     (110, 'Olivia Wilson', '123 Cherry St', 'Atlanta', 1114);
	
-- SELECT * FROM EMP
-- WHERE phNO = '5551';

explain analyze SELECT * FROM EMP
WHERE phNO = '5551';

create index idx_emp_phno on Emp(phno);


INSERT INTO emp (empno, ename, address, city, phno) VALUES
    (111, 'John', '123 Main St', 'New York', 4321);
	
SELECT indexname, indexdef
FROM   pg_indexes
WHERE   tablename = 'emp';

CREATE UNIQUE INDEX idx_employees_mobile_phone
ON emp(phno);

INSERT INTO emp (empno, ename, address, city, phno) VALUES
    (112, 'Robert Johnson', '789 Oak St', 'Chicago', 3333);
	
create index idx_emp_name
on emp(LOWER(ename));

select * from emp where ename = 'Robert Johnson';

CREATE TABLE people(
    id INT GENERATED BY DEFAULT AS IDENTITY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL
);

CREATE INDEX idx_people_names 
ON people (last_name, first_name);

INSERT INTO people(first_name,last_name)
VALUES('Tillie','Bell'),
('Marie','Lloyd'),
('John','Lyons'),
('Lucas','Gray'),
('Edward','May');

explain SELECT   *
FROM    people
WHERE  last_name = 'Gray'
AND first_name = 'Lucas';



-- Procedure - named block for a specific task
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


-- Function
CREATE OR REPLACE FUNCTION fn_insert_emp(
    p_empno int, p_ename varchar(20), p_address varchar(30), p_city varchar(20), p_phno int
) RETURNS void AS $$
BEGIN
    INSERT INTO emp (empno, ename, address, city, phno)
    VALUES (p_empno, p_ename, p_address, p_city, p_phno);
END;
$$ LANGUAGE plpgsql;

select * from fn_insert_emp(115, 'Alice', '789 Earth St', 'Denver', 955);
select * from emp;



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



-- Trigger
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












-- CASE STUDY
CREATE TABLE books (
    book_id serial PRIMARY KEY,
    title varchar(100) NOT NULL,
    author varchar(50),
    publication_date date,
    price numeric(10, 2),
    stock_quantity int
);

INSERT INTO books (title, author, publication_date, price, stock_quantity)
VALUES
    ('Introduction to SQL', 'John Smith', '2022-01-15', 39.99, 50),
    ('Python Programming', 'Jane Doe', '2021-11-10', 49.99, 30),
    ('Data Structures in C++', 'Robert Johnson', '2022-03-20', 54.95, 25);
	
CREATE OR REPLACE PROCEDURE add_book(
    p_title varchar(100),
    p_author varchar(50),
    p_publication_date date,
    p_price numeric(10, 2),
    p_stock_quantity int
) AS $$
BEGIN
    INSERT INTO books (title, author, publication_date, price, stock_quantity)
    VALUES (p_title, p_author, p_publication_date, p_price, p_stock_quantity);
END;
$$ LANGUAGE plpgsql;

select * from books;

CREATE OR REPLACE FUNCTION get_average_price() RETURNS numeric(10, 2) AS $$
DECLARE
    avg_price numeric(10, 2);
BEGIN
    SELECT AVG(price) INTO avg_price FROM books;
    RETURN avg_price;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION check_stock_trigger_function()
RETURNS TRIGGER AS $$
BEGIN
    IF NEW.stock_quantity < 0 THEN
        RAISE EXCEPTION 'Stock quantity cannot be negative.';
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

BEFORE UPDATE ON books
FOR EACH ROW
EXECUTE FUNCTION check_stock_trigger_function();
