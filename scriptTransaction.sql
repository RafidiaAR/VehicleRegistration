USE [TransactionDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 5/10/2024 2:43:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TR_BPKB]    Script Date: 5/10/2024 2:43:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TR_BPKB](
	[agreement_number] [nvarchar](100) NOT NULL,
	[bpkb_no] [nvarchar](100) NOT NULL,
	[branch_id] [nvarchar](10) NOT NULL,
	[bpkb_date] [datetime2](7) NOT NULL,
	[faktur_no] [nvarchar](100) NOT NULL,
	[faktur_date] [datetime2](7) NOT NULL,
	[location_id] [nvarchar](10) NOT NULL,
	[police_no] [nvarchar](20) NOT NULL,
	[bpkb_date_in] [datetime2](7) NOT NULL,
	[created_at] [datetime2](7) NULL,
	[created_by] [nvarchar](max) NULL,
	[updated_at] [datetime2](7) NULL,
	[updated_by] [nvarchar](max) NULL,
	[deleted_at] [datetime2](7) NULL,
	[deleted_by] [nvarchar](max) NULL,
 CONSTRAINT [PK_TR_BPKB] PRIMARY KEY CLUSTERED 
(
	[agreement_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
