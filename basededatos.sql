USE [DBClima]
GO
/****** Object:  Table [dbo].[tblclimas]    Script Date: 12/9/2022 12:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblclimas](
	[ideclima] [int] IDENTITY(1,1) NOT NULL,
	[idezona] [int] NOT NULL,
	[fechayhora] [smalldatetime] NOT NULL,
	[temperatura] [varchar](50) NOT NULL,
	[presipitacion] [varchar](50) NOT NULL,
	[viento] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblclimas] PRIMARY KEY CLUSTERED 
(
	[ideclima] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblzonas]    Script Date: 12/9/2022 12:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblzonas](
	[idezona] [int] IDENTITY(1,1) NOT NULL,
	[zona] [nchar](50) NULL,
 CONSTRAINT [PK_tblzonas] PRIMARY KEY CLUSTERED 
(
	[idezona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tlbusuarios]    Script Date: 12/9/2022 12:41:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tlbusuarios](
	[ideusuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[contraseña] [varchar](50) NOT NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[ideusuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
