create table emp(empno int primary key, ename varchar(20), address varchar(30), city varchar(20), phno int);

INSERT INTO emp (empno, ename, address, city, phno) VALUES
    (101, 'John Doe', '123 Main St', 'New York', 12345),
    (102, 'Jane Smith', '456 Elm St', 'Los Angeles', 98765),
    (103, 'Robert Johnson', '789 Oak St', 'Chicago', 55512),
    (104, 'Emily Williams', '234 Pine St', 'Houston', 88855),
    (105, 'Michael Brown', '567 Maple St', 'Miami', 33399),
    (106, 'Jessica Davis', '890 Cedar St', 'San Francisco', 44422),
    (107, 'William Anderson', '345 Walnut St', 'Seattle', 77744),
    (108, 'Samantha Martinez', '678 Birch St', 'Dallas', 66611),
    (109, 'David Garcia', '901 Spruce St', 'Boston', 22233),
    (110, 'Olivia Wilson', '123 Cherry St', 'Atlanta', 11144);

SELECT * FROM EMP
WHERE phNO = '898989';

explain Analyze SELECT * FROM EMP
WHERE phNO = '44422';

create index idx_emp_phno
ON emp(phno); 

INSERT INTO emp (empno, ename, address, city, phno) VALUES
    (111, 'John', '123 Main St', 'New York', 54321);
	
explain Analyze SELECT * FROM EMP
WHERE phNO = '54321';

create unique index idx_employess_mobile_phone
on emp(phno);

INSERT INTO emp (empno, ename, address, city, phno) VALUES
    (112, 'Robert Johnson', '789 Oak St', 'Chicago', 33333);
	
Create index idx_emp_name
on emp(LOWER(ename));

CREATE OR REPLACE PROCEDURE insert_emp(
    p_empno int, p_ename varchar(20), p_address varchar(30), p_city varchar(20), p_phno int
) AS $$
BEGIN
    INSERT INTO emp (empno, ename, address, city, phno)
    VALUES (p_empno, p_ename, p_address, p_city, p_phno);
END;
$$ LANGUAGE plpgsql;

CALL insert_emp(113, 'Alice Brown', '789 Maple St', 'Denver', 77777);

select * from emp;

CREATE OR REPLACE FUNCTION fn_insert_emp(
    p_empno int, p_ename varchar(20), p_address varchar(30), p_city varchar(20), p_phno int
) RETURNS void AS $$
BEGIN
    INSERT INTO emp (empno, ename, address, city, phno)
    VALUES (p_empno, p_ename, p_address, p_city, p_phno);
END;
$$ LANGUAGE plpgsql;

