-- Case Study: Online Order Management System
-- You are tasked with designing a database for an online 
-- order management system. The system needs to handle customer 
-- orders, products, and inventory. Additionally, you need to 
-- implement functionality for tracking order status and managing 
-- stock quantities. Design the database schema, insert sample data,
-- and create a stored procedure, function, and trigger to enhance 
-- the system's capabilities.
-- Step 1: Create Table
CREATE TABLE orders (
    order_id serial PRIMARY KEY,
    customer_id varchar(100) NOT NULL,
    order_date date,
    order_status varchar(100) NOT NULL
);
CREATE TABLE products (
	product_id serial PRIMARY KEY,
	product_name varchar(100) NOT NULL,
	price numeric(10, 2),
	stock_quantity int
);

-- Step 2: Insert Data
INSERT INTO orders (order_id, customer_id, order_date, order_status)
VALUES
    ('CUST00001', 'John Smith', '2022-01-15', 'Pending'),
	('CUST00010', 'John Snow', '2021-11-10', 'Pending'),
	('CUST00011', 'Tom Smith', '2022-03-20', 'Shipped'),
	('CUST00100', 'Tommy Snow Lapino', '2022-03-20', 'Shipped');
-- Step 3: Create Stored Procedure
-- Create a stored procedure named add_book to insert a new book into the table
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


-- Step 4: Create Function
-- Create a function named get_average_price to calculate the average price of books
CREATE OR REPLACE FUNCTION get_average_price() RETURNS numeric(10, 2) AS $$
DECLARE
    avg_price numeric(10, 2);
BEGIN
    SELECT AVG(price) INTO avg_price FROM books;
    RETURN avg_price;
END;
$$ LANGUAGE plpgsql;

-- Step 5: Create Trigger
-- Create a trigger named check_stock_trigger that fires before 
-- an UPDATE operation on the books table to prevent negative stock quantities
CREATE OR REPLACE FUNCTION check_stock_trigger_function()
RETURNS TRIGGER AS $$
BEGIN
    IF NEW.stock_quantity < 0 THEN
        RAISE EXCEPTION 'Stock quantity cannot be negative.';
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER check_stock_trigger
BEFORE UPDATE ON books
FOR EACH ROW
EXECUTE FUNCTION check_stock_trigger_function();