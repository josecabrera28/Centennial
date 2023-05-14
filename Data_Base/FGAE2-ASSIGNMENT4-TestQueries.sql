
--Which customers name starts with J? List each customer’s full name, city, and email.
SELECT CNAME, CITY, EMAIL FROM CUSTOMERS WHERE CNAME LIKE 'J%'; 

--Write the sql command to count the number of vendororders that are still in process?
SELECT COUNT(*) FROM VENDORORDERS WHERE ORDERSTATUS = 'IN PROCESS'; 

--Write a sql command that retrieves the orders that have arrived?
SELECT * FROM VENDORORDERS WHERE ORDERSTATUS = 'ARRIVED'; 

--Write a sql command to list the vendors from Canada with their Vendorid, name, and address.
SELECT VENDORID, NAME, ADDRESS FROM VENDORS WHERE COUNTRY = 'CA'; 

--Write a command to show the order number and the date it arrived for all the orders that arrived after April 6, 2023.
SELECT V_ORDER#, ARRIVEDDATE FROM VENDORORDERS 
WHERE ARRIVEDDATE > TO_DATE('06-APR-23', 'DD-MON-YY'); 

--Write a sql command that retrieves the product name, warehouse ID, aisle, bin, and quantity for each product that is currently in inventory.
SELECT P.PRODNAME, L.WAREHOUSE#, L.AISLE, L.BIN, I.QUANTITY 
FROM PRODUCTS P 
JOIN INVENTORY I ON P.PRODUCTID = I.PRODUCTID 
JOIN LOCATION L ON I.LOCATIONID = L.LOCATIONID; 

--This month single product sale quantity
SELECT PRODUCTID, PRODNAME, SUM(QUANTITY) QUANTITY
FROM CUSTOMERSORDERS NATURAL JOIN C_ORDERDETAILS NATURAL JOIN PRODUCTS
WHERE ORDER_DATE >= '01-APR-23'
GROUP BY PRODUCTID, PRODNAME
ORDER BY PRODUCTID;

--Year to date total sales by customer
SELECT C.CNAME "CUSTOMER NAME", SUM(P.COST * D.QUANTITY) SALES, COUNT(DISTINCT O.C_ORDER#) "COUNT OF ORDERS"
FROM CUSTOMERS C 
JOIN CUSTOMERSORDERS O ON C.CUSTOMERID = O.CUSTOMERID
JOIN C_ORDERDETAILS D ON O.C_ORDER# = D.C_ORDER#
JOIN PRODUCTS P ON D.PRODUCTID = P.PRODUCTID
WHERE ORDER_DATE >= '01-JAN-23'
GROUP BY C.CNAME
ORDER BY SUM(P.COST * D.QUANTITY) DESC;





