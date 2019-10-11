CREATE TABLE [Customers] (
  [CustomerId] int  PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [FirstName] nvarchar NOT NULL,
  [LastName] nvarchar NOT NULL,
  [Address] nvarchar NOT NULL,
  [City] nvarchar NOT NULL,
  [State] nvarchar NOT NULL,
  [Country] nvarchar NOT NULL
)
GO

CREATE TABLE [Orders] (
  [CustomerId] int NOT NULL,
  [OrderId] int  PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [OrderDate] datetime NOT NULL,
  [Total] money NOT NULL,
  [StoreNum] int NOT NULL
)
GO

CREATE TABLE [OrderDetail] (
  [OrderId] int NOT NULL,
  [ProductId] int NOT NULL,
  [ProductQuant] int NOT NULL,
  CONSTRAINT PK_OrderDetailID PRIMARY KEY (OrderId, ProductId) 
)
GO

CREATE TABLE [Products] (
  [Name] nvarchar NOT NULL,
  [ProductId] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [Price] money NOT NULL
)
GO

CREATE TABLE [Stores] (
  [StoreNum] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [InventoryId] int,
  [Address] nvarchar NOT NULL,
  [City] nvarchar NOT NULL,
  [State] nvarchar NOT NULL,
  [Country] nvarchar NOT NULL
)
GO

CREATE TABLE [Inventory] (
  [InventoryId] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [ProductId] int NOT NULL,
  [Quantity] int
)
GO

ALTER TABLE [Orders] ADD FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([CustomerId])
GO

ALTER TABLE [Orders] ADD FOREIGN KEY ([StoreNum]) REFERENCES [Stores] ([StoreNum])
GO

ALTER TABLE [OrderDetail] ADD FOREIGN KEY ([OrderId]) REFERENCES [Orders] ([OrderId])
GO

ALTER TABLE [OrderDetail] ADD FOREIGN KEY ([ProductId]) REFERENCES [Products] ([ProductId])
GO

ALTER TABLE [Stores] ADD FOREIGN KEY ([InventoryId]) REFERENCES [Inventory] ([InventoryId])
GO

ALTER TABLE [Inventory] ADD FOREIGN KEY ([ProductId]) REFERENCES [Products] ([ProductId])
GO
