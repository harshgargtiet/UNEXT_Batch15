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

-- SELECT * FROM emp
-- WHERE phno = '8885';


-- Explain Analyze SELECT * FROM emp
-- WHERE phno = '8885';





-- CREATE INDEX idx_emp_phno ON emp(phno);

-- [USING method]
-- (
--     column_name [ASC | DESC] [NULLS {FIRST | LAST }],
--     ...
-- );

