USE [Webinar]
GO

CREATE TABLE [dbo].[Coffees](
	[Id] [uniqueidentifier] NOT NULL,
	[Type] [int] NOT NULL,
	[Toppings] [varchar](200) NULL,
	[Done] [bit] NOT NULL,
 CONSTRAINT [PK_Coffees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Coffees] ADD  CONSTRAINT [DF_Coffees_Done]  DEFAULT ((0)) FOR [Done]
GO


CREATE TABLE [dbo].[Payments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [uniqueidentifier] NOT NULL,
	[Amount] [decimal](6, 2) NOT NULL,
	[IsPaid] [bit] NOT NULL,
	[IsValid] [bit] NOT NULL,
 CONSTRAINT [PK_Payments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Payments] ADD  CONSTRAINT [DF_Payments_IsPaid]  DEFAULT ((0)) FOR [IsPaid]
GO

ALTER TABLE [dbo].[Payments] ADD  CONSTRAINT [DF_Payments_IsValid]  DEFAULT ((0)) FOR [IsValid]
GO


