select * from stores

--creating all our stores
INSERT INTO Stores (Address, City, State, Zipcode)
Values ('123 Main Street', 'Nowhere', 'TX', '89898'),
		('321 Niam Road', 'Los Angeles', 'CA', '12345'),
		('4567 Avenue', 'New York City', 'NY', '55667'),
		('789 Drive', 'Houston', 'TX', '77080'),
		('999 Old Potato Road', 'Denver', 'CO', '67504')


SELECT * FROM Products

--creating all our products
INSERT INTO Products(Name, Price)
Values ('Red Shirt', 5), 
		('White Shirt', 3),
		('Blue Shirt', 5)



SELECT * FROM Inventory

--creating our inventory for Store# 101
INSERT INTO Inventory(StoreId, ProductId, Quantity)
VALUES (101, 1000, 10),
		(101, 1001, 10),
		(101, 1002, 10)

--creating inventory for Store# 102
INSERT INTO Inventory(StoreId, ProductId, Quantity)
VALUES (102, 1000, 10),
		(102, 1001, 10),
		(102, 1002, 10)

--creating inventory for Store# 103
INSERT INTO Inventory(StoreId, ProductId, Quantity)
VALUES (103, 1000, 10),
		(103, 1001, 10),
		(103, 1002, 10)

--creating inventory for Store# 104
INSERT INTO Inventory(StoreId, ProductId, Quantity)
VALUES (104, 1000, 10),
		(104, 1001, 10),
		(104, 1002, 10)

--creating inventory for Store# 105
INSERT INTO Inventory(StoreId, ProductId, Quantity)
VALUES (105, 1000, 10),
		(105, 1001, 10),
		(105, 1002, 10)


--creating a new customer
INSERT INTO Customers(FirstName, LastName, Address, City, State, Zipcode)
VALUES ('Victoria', 'de la Guardia', '13911 Wheatbridge Dr.', 'Houston', 'TX', '77041')
	
select * from customers


