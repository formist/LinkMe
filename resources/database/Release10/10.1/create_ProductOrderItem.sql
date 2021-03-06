IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.ProductOrderItem') AND type in (N'U'))
DROP TABLE dbo.ProductOrderItem
GO

CREATE TABLE dbo.ProductOrderItem
(
	id UNIQUEIDENTIFIER NOT NULL,
	orderId UNIQUEIDENTIFIER NOT NULL,
	productId UNIQUEIDENTIFIER NOT NULL,
	price DECIMAL NOT NULL,
	currency INT NOT NULL
)

ALTER TABLE dbo.ProductOrderItem
ADD CONSTRAINT PK_ProductOrderItem PRIMARY KEY NONCLUSTERED
(
	id
)

ALTER TABLE dbo.ProductOrderItem
ADD CONSTRAINT FK_ProductOrderItem_Product FOREIGN KEY (productId)
REFERENCES dbo.Product (id)
GO

ALTER TABLE dbo.ProductOrderItem
ADD CONSTRAINT FK_ProductOrderItem_Order FOREIGN KEY (orderId)
REFERENCES dbo.ProductOrder (id)
GO
