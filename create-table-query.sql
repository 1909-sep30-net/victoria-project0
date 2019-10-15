CREATE TABLE [Customers] (
  [CustomerId] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [FirstName] nvarchar(100) NOT NULL,
  [LastName] nvarchar(100) NOT NULL,
  [Address] nvarchar(100) NOT NULL,
  [City] nvarchar(50) NOT NULL,
  [State] nvarchar(2) NOT NULL,
  [Zipcode] nvarchar(5) NOT NULL
)
GO

CREATE TABLE [Orders] (
  [CustomerId] int NOT NULL,
  [OrderId] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [OrderDate] datetime2 NOT NULL DEFAULT (GETDATE()),
  [Total] money NOT NULL,
  [StoreId] int NOT NULL
)
GO

CREATE TABLE [OrderDetail] (
  [OrderId] int NOT NULL,
  [ProductId] int NOT NULL,
  [ProductQuant] int NOT NULL,
  CONSTRAINT OrderDetails_PK primary key(OrderId, ProductId)
)
GO

CREATE TABLE [Products] (
  [Name] nvarchar(160) NOT NULL,
  [ProductId] int PRIMARY KEY NOT NULL IDENTITY(1000, 1),
  [Price] money NOT NULL
)
GO

CREATE TABLE [Stores] (
  [StoreId] int PRIMARY KEY NOT NULL IDENTITY(101, 1),
  [Address] nvarchar(160) NOT NULL,
  [City] nvarchar(50) NOT NULL,
  [State] nvarchar(2) NOT NULL,
  [Zipcode] nvarchar(5) NOT NULL
)
GO

CREATE TABLE [Inventory] (
  [StoreId] int NOT NULL,
  [ProductId] int NOT NULL,
  [Quantity] int
)
GO

ALTER TABLE [Orders] ADD FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([CustomerId])
GO

ALTER TABLE [Orders] ADD FOREIGN KEY ([StoreId]) REFERENCES [Stores] ([StoreId])
GO

ALTER TABLE [OrderDetail] ADD FOREIGN KEY ([OrderId]) REFERENCES [Orders] ([OrderId])
GO

ALTER TABLE [OrderDetail] ADD FOREIGN KEY ([ProductId]) REFERENCES [Products] ([ProductId])
GO

ALTER TABLE [Inventory] ADD FOREIGN KEY ([StoreId]) REFERENCES [Stores] ([StoreId])
GO

ALTER TABLE [Inventory] ADD FOREIGN KEY ([ProductId]) REFERENCES [Products] ([ProductId])
GO





DROP TABLE Inventory
DROP TABLE OrderDetail
DROP TABLE Orders
DROP TABLE Products
DROP TABLE Stores
DROP TABLE Customers

