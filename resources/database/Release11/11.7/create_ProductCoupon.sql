IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.ProductCouponRedeemer') AND type in (N'U'))
DROP TABLE dbo.ProductCouponRedeemer
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.ProductCouponProduct') AND type in (N'U'))
DROP TABLE dbo.ProductCouponProduct
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.ProductCoupon') AND type in (N'U'))
DROP TABLE dbo.ProductCoupon
GO

-- ProductCoupon

CREATE TABLE dbo.ProductCoupon
(
	id UNIQUEIDENTIFIER NOT NULL,
	code NVARCHAR(100) NOT NULL,
	discount DECIMAL(18, 2) NOT NULL,
	expiryDate DATETIME NULL,
	canBeUsedOnce BIT NOT NULL,
	enabled BIT NOT NULL
)
GO

ALTER TABLE dbo.ProductCoupon
ADD CONSTRAINT PK_ProductCoupon PRIMARY KEY NONCLUSTERED
(
	id
)
GO

CREATE UNIQUE INDEX IX_ProductCoupon_code ON dbo.ProductCoupon
(
	code
)
GO

-- ProductCouponProduct

CREATE TABLE dbo.ProductCouponProduct
(
	couponId UNIQUEIDENTIFIER NOT NULL,
	productId UNIQUEIDENTIFIER NOT NULL
)
GO

ALTER TABLE dbo.ProductCouponProduct
ADD CONSTRAINT PK_ProductCouponProduct PRIMARY KEY CLUSTERED
(
	couponId,
	productId
)
GO

ALTER TABLE dbo.ProductCouponProduct
ADD CONSTRAINT FK_ProductCouponProduct_ProductCoupon FOREIGN KEY (couponId)
REFERENCES dbo.ProductCoupon (id)
GO

ALTER TABLE dbo.ProductCouponProduct
ADD CONSTRAINT FK_ProductCouponProduct_Product FOREIGN KEY (productId)
REFERENCES dbo.Product (id)
GO

-- ProductCouponRedeemer

CREATE TABLE dbo.ProductCouponRedeemer
(
	couponId UNIQUEIDENTIFIER NOT NULL,
	redeemerId UNIQUEIDENTIFIER NOT NULL
)
GO

ALTER TABLE dbo.ProductCouponRedeemer
ADD CONSTRAINT PK_ProductCouponRedeemer PRIMARY KEY CLUSTERED
(
	couponId,
	redeemerId
)
GO

ALTER TABLE dbo.ProductCouponRedeemer
ADD CONSTRAINT FK_ProductCouponRedeemer_ProductCoupon FOREIGN KEY (couponId)
REFERENCES dbo.ProductCoupon (id)
GO

