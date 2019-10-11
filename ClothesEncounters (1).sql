CREATE TABLE [Customers] (
  [CustomerId] int UNIQUE PRIMARY KEY NOT NULL IDENTITY(1, 1),
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
  [OrderId] int UNIQUE PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [OrderDate] datetime NOT NULL,
  [Total] money NOT NULL,
  [StoreNum] int NOT NULL
)
GO

CREATE TABLE [OrderDetail] (
  [OrderId] int PRIMARY KEY NOT NULL,
  [ProductId] int PRIMARY KEY NOT NULL,
  [ProductQuant] int NOT NULL
)
GO

CREATE TABLE [Products] (
  [Name] nvarchar NOT NULL,
  [ProductId] int UNIQUE PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [Price] money NOT NULL
)
GO

CREATE TABLE [Stores] (
  [StoreNum] int UNIQUE PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [Address] nvarchar NOT NULL,
  [City] nvarchar NOT NULL,
  [State] nvarchar NOT NULL,
  [Country] nvarchar NOT NULL
)
GO

CREATE TABLE [Inventory] (
  [InventoryId] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [StoreNum] int UNIQUE NOT NULL IDENTITY(1, 1),
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

ALTER TABLE [Inventory] ADD FOREIGN KEY ([StoreNum]) REFERENCES [Stores] ([StoreNum])
GO

ALTER TABLE [Inventory] ADD FOREIGN KEY ([ProductId]) REFERENCES [Products] ([ProductId])
GO
