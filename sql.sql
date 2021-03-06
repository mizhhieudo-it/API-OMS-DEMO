USE [API-OMS]
GO
/****** Object:  Table [dbo].[CategoryProduct]    Script Date: 2/23/2022 5:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryProduct](
	[CategoryProductId] [nvarchar](50) NOT NULL,
	[CategoryProductName] [nvarchar](50) NULL,
	[CategoryProductDescription] [nvarchar](50) NULL,
	[TimeCreate] [datetime] NULL,
	[TimeUpdate] [datetime] NULL,
	[HandlerBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_CategoryProduct] PRIMARY KEY CLUSTERED 
(
	[CategoryProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2/23/2022 5:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerId] [nvarchar](50) NOT NULL,
	[CustomerName] [nvarchar](50) NULL,
	[CustomerNumber] [varchar](50) NULL,
	[CountryId] [int] NULL,
	[ZipCode] [varbinary](50) NULL,
	[ProvinceId] [varchar](50) NULL,
	[DistrictId] [varchar](50) NULL,
	[WardsId] [varchar](50) NULL,
	[CustomerAddress] [nvarchar](50) NULL,
	[Note] [nvarchar](255) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 2/23/2022 5:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[InventoryId] [nvarchar](50) NULL,
	[ProductId] [nvarchar](50) NULL,
	[QuantityPurchase] [int] NULL,
	[StockInHand] [int] NULL,
	[QuantitySold] [int] NULL,
	[QuantityLoss] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoices]    Script Date: 2/23/2022 5:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoices](
	[InvoiceId] [nvarchar](50) NOT NULL,
	[OrderId] [nvarchar](50) NULL,
	[TimeCreate] [datetime] NULL,
	[HandlerBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_Invoices] PRIMARY KEY CLUSTERED 
(
	[InvoiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 2/23/2022 5:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderId] [nvarchar](50) NOT NULL,
	[DateReceived] [datetime] NULL,
	[DateRequired] [datetime] NULL,
	[DateDelivered] [datetime] NULL,
	[OrderStatus] [nvarchar](50) NULL,
	[PackageCode] [nvarchar](50) NULL,
	[CustomerId] [nvarchar](50) NULL,
	[OrderNote] [nvarchar](50) NULL,
	[TimeCreate] [datetime] NULL,
	[TimeUpdate] [datetime] NULL,
	[HandlerBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_Order_1] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 2/23/2022 5:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderDetailId] [nvarchar](50) NOT NULL,
	[ProductId] [nvarchar](50) NULL,
	[OrderId] [nvarchar](50) NULL,
	[Prince] [decimal](18, 0) NULL,
	[Discount] [float] NULL,
	[Quantity] [int] NULL,
	[TimeCreate] [datetime] NULL,
	[TimeUpdate] [datetime] NULL,
	[HandlerBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[OrderDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderExport]    Script Date: 2/23/2022 5:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderExport](
	[ExportOrderId] [nvarchar](50) NOT NULL,
	[ProductQuantity] [int] NULL,
	[FromWarehouseId] [nvarchar](50) NULL,
	[ToWarehouseId] [nvarchar](50) NULL,
	[Note] [nvarchar](255) NULL,
	[TimeChangeLocation] [datetime] NULL,
	[TimeCreate] [datetime] NULL,
	[TimeUpdate] [datetime] NULL,
	[HandlerBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_OrderExport] PRIMARY KEY CLUSTERED 
(
	[ExportOrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderImport]    Script Date: 2/23/2022 5:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderImport](
	[OrderImportId] [nvarchar](50) NOT NULL,
	[SupplierId] [nvarchar](50) NULL,
	[ToWarehouseId] [nvarchar](50) NULL,
	[ReferenceCode] [nvarchar](50) NULL,
	[ProductQuantity] [int] NULL,
	[ProductPrince] [decimal](18, 0) NULL,
	[ProductTotal] [decimal](18, 0) NULL,
	[ExpectedDelivery] [datetime] NULL,
	[OrderNote] [nvarchar](50) NULL,
	[TimeCreate] [datetime] NULL,
	[TimeUpdate] [datetime] NULL,
	[HandlerBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderImportId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 2/23/2022 5:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[PaymentId] [nvarchar](50) NOT NULL,
	[InvoiceId] [nvarchar](50) NULL,
	[PaymentMethodId] [nvarchar](50) NULL,
	[TransactionTypeId] [nvarchar](50) NULL,
	[TimeCreate] [datetime] NULL,
	[HandlerBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[PaymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentMethod]    Script Date: 2/23/2022 5:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentMethod](
	[PaymentMethodId] [nvarchar](50) NOT NULL,
	[PaymentName] [nvarchar](50) NULL,
 CONSTRAINT [PK_PaymentMethod] PRIMARY KEY CLUSTERED 
(
	[PaymentMethodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2/23/2022 5:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [nvarchar](50) NOT NULL,
	[ProductName] [nvarchar](50) NULL,
	[OrderDetailId] [nvarchar](50) NULL,
	[SupperlierId] [nvarchar](50) NULL,
	[TrademarkId] [nvarchar](50) NULL,
	[WarehouseId] [nvarchar](50) NULL,
	[CategoryProductId] [nvarchar](50) NULL,
	[OrderId] [nvarchar](50) NULL,
	[OrderImportId] [nvarchar](50) NULL,
	[OrderExportId] [nvarchar](50) NULL,
	[TimeCreate] [datetime] NULL,
	[TimeUpdate] [datetime] NULL,
	[HandlerBy] [nvarchar](255) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductDetail]    Script Date: 2/23/2022 5:11:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductDetail](
	[ProductDetailId] [nvarchar](50) NOT NULL,
	[ProductId] [nvarchar](50) NULL,
	[ProductType] [int] NULL,
	[ProductSKU] [nvarchar](50) NULL,
	[BARCODE] [nvarchar](50) NULL,
	[HashTag] [nvarchar](50) NULL,
	[IMEI] [nvarchar](50) NULL,
	[ImagesDescription] [text] NULL,
	[Description] [nvarchar](255) NULL,
	[ImportPrice] [decimal](18, 0) NULL,
	[ListedPrice] [decimal](18, 0) NULL,
	[RetailPrince] [decimal](18, 0) NULL,
	[NumberStockWaring] [int] NULL,
	[TimeImportProduct] [date] NULL,
	[ProductHeight] [float] NULL,
	[ProductWidth] [float] NULL,
	[ProductLength] [float] NULL,
	[TimeCreat] [datetime] NULL,
	[TimeUpdate] [datetime] NULL,
	[HandlerBy] [datetime] NULL,
 CONSTRAINT [PK_ProductDetail] PRIMARY KEY CLUSTERED 
(
	[ProductDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supperlier]    Script Date: 2/23/2022 5:11:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supperlier](
	[SupplierId] [nvarchar](50) NOT NULL,
	[SupplierType] [nvarchar](50) NULL,
	[SupplierName] [nvarchar](50) NULL,
	[SupplierEmail] [nvarchar](50) NULL,
	[SupplierNumber] [nvarchar](50) NULL,
	[SupplierWebsite] [nvarchar](50) NULL,
	[SupplierAddress] [nvarchar](50) NULL,
	[SupplierTaxCode] [nvarchar](50) NULL,
	[SupplierZipCode] [nvarchar](50) NULL,
	[SupperlierBankNumber] [bigint] NULL,
	[SupperlierBankType] [int] NULL,
	[BankOwnerName] [nvarchar](50) NULL,
	[Note] [nvarchar](50) NULL,
	[SupperlierStatus] [int] NULL,
	[TimeCreate] [datetime] NULL,
	[TimeUpdate] [datetime] NULL,
	[HandlerBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_Supperlier] PRIMARY KEY CLUSTERED 
(
	[SupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransactionType]    Script Date: 2/23/2022 5:11:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionType](
	[TransactionTypeId] [nvarchar](50) NOT NULL,
	[TransactionName] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
 CONSTRAINT [PK_TransactionType] PRIMARY KEY CLUSTERED 
(
	[TransactionTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse]    Script Date: 2/23/2022 5:11:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse](
	[WarehouseId] [nvarchar](50) NOT NULL,
	[WarehouseName] [nvarchar](50) NULL,
	[WarehouseNameContact] [nvarchar](50) NULL,
	[WarehouseNumber] [varchar](50) NULL,
	[WarehouseAddress] [nvarchar](50) NULL,
	[WarehousePostalCode] [varchar](50) NULL,
	[ProvinceId] [int] NULL,
	[DistrinctId] [int] NULL,
	[CommuneId] [int] NULL,
	[LocationMap] [nvarchar](50) NULL,
	[CreateBy] [datetime] NULL,
	[UpdateBy] [datetime] NULL,
	[HandlerBy] [datetime] NULL,
 CONSTRAINT [PK_Warehouse] PRIMARY KEY CLUSTERED 
(
	[WarehouseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WhArea]    Script Date: 2/23/2022 5:11:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WhArea](
	[IdWhArea] [nvarchar](50) NOT NULL,
	[IdWarehouse] [nvarchar](50) NULL,
	[AreaName] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
	[CreateBy] [nvarchar](50) NULL,
	[UpdateBy] [nvarchar](50) NULL,
	[HandlerBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_WhArea] PRIMARY KEY CLUSTERED 
(
	[IdWhArea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_Invoices_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[Invoices] CHECK CONSTRAINT [FK_Invoices_Order]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([CustomerId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customer]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Product]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Invoices] FOREIGN KEY([InvoiceId])
REFERENCES [dbo].[Invoices] ([InvoiceId])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Invoices]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_PaymentMethod] FOREIGN KEY([PaymentMethodId])
REFERENCES [dbo].[PaymentMethod] ([PaymentMethodId])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_PaymentMethod]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_TransactionType] FOREIGN KEY([TransactionTypeId])
REFERENCES [dbo].[TransactionType] ([TransactionTypeId])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_TransactionType]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_CategoryProduct] FOREIGN KEY([CategoryProductId])
REFERENCES [dbo].[CategoryProduct] ([CategoryProductId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_CategoryProduct]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_OrderExport] FOREIGN KEY([OrderImportId])
REFERENCES [dbo].[OrderExport] ([ExportOrderId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_OrderExport]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_OrderImport] FOREIGN KEY([OrderImportId])
REFERENCES [dbo].[OrderImport] ([OrderImportId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_OrderImport]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Supperlier] FOREIGN KEY([SupperlierId])
REFERENCES [dbo].[Supperlier] ([SupplierId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Supperlier]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Warehouse] FOREIGN KEY([WarehouseId])
REFERENCES [dbo].[Warehouse] ([WarehouseId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Warehouse]
GO
ALTER TABLE [dbo].[ProductDetail]  WITH CHECK ADD  CONSTRAINT [FK_ProductDetail_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[ProductDetail] CHECK CONSTRAINT [FK_ProductDetail_Product]
GO
ALTER TABLE [dbo].[WhArea]  WITH CHECK ADD  CONSTRAINT [FK_WhArea_Warehouse] FOREIGN KEY([IdWarehouse])
REFERENCES [dbo].[Warehouse] ([WarehouseId])
GO
ALTER TABLE [dbo].[WhArea] CHECK CONSTRAINT [FK_WhArea_Warehouse]
GO
