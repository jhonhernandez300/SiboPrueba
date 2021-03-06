IF NOT EXISTS (SELECT * FROM sysdatabases WHERE NAME ='SiboSupermarket1')
BEGIN
CREATE DATABASE SiboSupermarket1
 END 
GO

USE [SiboSupermarket1]
GO

/****** Object:  Table [dbo].[Adviser]    Script Date: 05/06/2020 18:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adviser](
	[AdviserID] [int] IDENTITY(1,1) NOT NULL,
	[Identification] [varchar](20) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Password] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Adviser] PRIMARY KEY CLUSTERED 
(
	[AdviserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 05/06/2020 18:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[Identification] [varchar](20) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 05/06/2020 18:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[InvoiceID] [int] NOT NULL,
	[ClientID] [int] NOT NULL,
	[AdviserID] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvoiceDetail]    Script Date: 05/06/2020 18:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceDetail](
	[InvoiceDetailID] [int] NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [money] NULL,
 CONSTRAINT [PK_InvoiceDetail] PRIMARY KEY CLUSTERED 
(
	[InvoiceDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 05/06/2020 18:12:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Price] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[PercentDiscount] [decimal](3, 0) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Adviser] ON 

INSERT [dbo].[Adviser] ([AdviserID], [Identification], [Name], [LastName], [Password]) VALUES (1, N'12345', N'Elkin', N'Cardona', N'12345')
INSERT [dbo].[Adviser] ([AdviserID], [Identification], [Name], [LastName], [Password]) VALUES (2, N'123', N'Juan', N'Quintana', N'abc')
INSERT [dbo].[Adviser] ([AdviserID], [Identification], [Name], [LastName], [Password]) VALUES (3, N'55576', N'Jonathan', N'Plata', N'123')
SET IDENTITY_INSERT [dbo].[Adviser] OFF
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([ClientID], [Identification], [Name], [LastName]) VALUES (1, N'1234', N'Elkin', N'Cardona')
INSERT [dbo].[Client] ([ClientID], [Identification], [Name], [LastName]) VALUES (2, N'12345', N'Juan', N'Velez')
INSERT [dbo].[Client] ([ClientID], [Identification], [Name], [LastName]) VALUES (3, N'123', N'Guillermo', N'Quintana')
INSERT [dbo].[Client] ([ClientID], [Identification], [Name], [LastName]) VALUES (4, N'6543', N'Pablo', N'Herrera')
INSERT [dbo].[Client] ([ClientID], [Identification], [Name], [LastName]) VALUES (5, N'0098', N'Jonathan', N'Plata')
INSERT [dbo].[Client] ([ClientID], [Identification], [Name], [LastName]) VALUES (6, N'111222', N'Elkin', N'Cardona 2')
SET IDENTITY_INSERT [dbo].[Client] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductID], [Name], [Price], [Quantity], [PercentDiscount]) VALUES (2, N'Camiseta deportiva', 32000.0000, 10, CAST(0 AS Decimal(3, 0)))
INSERT [dbo].[Product] ([ProductID], [Name], [Price], [Quantity], [PercentDiscount]) VALUES (3, N'Libro Colombia Salvaje', 63500.0000, 2, CAST(10 AS Decimal(3, 0)))
INSERT [dbo].[Product] ([ProductID], [Name], [Price], [Quantity], [PercentDiscount]) VALUES (4, N'Bicicleta todo terreno', 250000.0000, 8, CAST(1 AS Decimal(3, 0)))
INSERT [dbo].[Product] ([ProductID], [Name], [Price], [Quantity], [PercentDiscount]) VALUES (6, N'Silla Oficina', 300000.0000, 2, CAST(0 AS Decimal(3, 0)))
INSERT [dbo].[Product] ([ProductID], [Name], [Price], [Quantity], [PercentDiscount]) VALUES (7, N'Computador portatil', 1800000.0000, 5, CAST(20 AS Decimal(3, 0)))
INSERT [dbo].[Product] ([ProductID], [Name], [Price], [Quantity], [PercentDiscount]) VALUES (8, N'Ancheta', 25000.0000, 20, CAST(1 AS Decimal(3, 0)))
INSERT [dbo].[Product] ([ProductID], [Name], [Price], [Quantity], [PercentDiscount]) VALUES (9, N'Paquete leche x 6', 15600.0000, 100, CAST(0 AS Decimal(3, 0)))
INSERT [dbo].[Product] ([ProductID], [Name], [Price], [Quantity], [PercentDiscount]) VALUES (10, N'Combo Aseo', 18000.0000, 0, CAST(1 AS Decimal(3, 0)))
SET IDENTITY_INSERT [dbo].[Product] OFF
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Adviser] FOREIGN KEY([AdviserID])
REFERENCES [dbo].[Adviser] ([AdviserID])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Adviser]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Client] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ClientID])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Client]
GO
ALTER TABLE [dbo].[InvoiceDetail]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceDetail_Invoice] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[Invoice] ([InvoiceID])
GO
ALTER TABLE [dbo].[InvoiceDetail] CHECK CONSTRAINT [FK_InvoiceDetail_Invoice]
GO
ALTER TABLE [dbo].[InvoiceDetail]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceDetail_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[InvoiceDetail] CHECK CONSTRAINT [FK_InvoiceDetail_Product]
GO
