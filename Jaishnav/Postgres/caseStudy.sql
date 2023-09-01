-- CREATE TABLE books (
--     book_id serial PRIMARY KEY,
--     title varchar(100) NOT NULL,
--     author varchar(50),
--     publication_date date,
--     price numeric(10, 2),
--     stock_quantity int
-- );


-- INSERT INTO books (title, author, publication_date, price, stock_quantity)
-- VALUES
--     ('Introduction to SQL', 'John Smith', '2022-01-15', 39.99, 50),
--     ('Python Programming', 'Jane Doe', '2021-11-10', 49.99, 30),
--     ('Data Structures in C++', 'Robert Johnson', '2022-03-20', 54.95, 25);

-- INSERT INTO books (title, author, publication_date, price, stock_quantity)
-- VALUES
    ('Introduction to SQL', 'John Smith', '2022-01-15', 39.99, 50),
    ('Python Programming', 'Jane Doe', '2021-11-10', 49.99, 30),
    ('Data Structures in C++', 'Robert Johnson', '2022-03-20', 54.95, 25);


-- CREATE OR REPLACE PROCEDURE add_book(
--     p_title varchar(100),
--     p_author varchar(50),
--     p_publication_date date,
--     p_price numeric(10, 2),
--     p_stock_quantity int
-- ) AS $$
-- BEGIN
--     INSERT INTO books (title, author, publication_date, price, stock_quantity)
--     VALUES (p_title, p_author, p_publication_date, p_price, p_stock_quantity);
-- END;
-- $$ LANGUAGE plpgsql;

-- CREATE OR REPLACE FUNCTION get_average_price() RETURNS numeric(10, 2) AS $$
-- DECLARE
--     avg_price numeric(10, 2);
-- BEGIN
--     SELECT AVG(price) INTO avg_price FROM books;
--     RETURN avg_price;
-- END;
-- $$ LANGUAGE plpgsql;

-- CREATE OR REPLACE FUNCTION check_stock_trigger_function()
-- RETURNS TRIGGER AS $$
-- BEGIN
--     IF NEW.stock_quantity < 0 THEN
--         RAISE EXCEPTION 'Stock quantity cannot be negative.';
--     END IF;
--     RETURN NEW;
-- END;
-- $$ LANGUAGE plpgsql;

-- CREATE TRIGGER check_stock_trigger
-- BEFORE UPDATE ON books
-- FOR EACH ROW
-- EXECUTE FUNCTION check_stock_trigger_function();