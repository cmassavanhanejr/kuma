USE [dbsgc]
GO
/****** Object:  Table [dbo].[Audit]    Script Date: 05/14/2016 23:10:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Audit](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[TableName] [nvarchar](250) NULL,
	[UserId] [nvarchar](100) NULL,
	[Actions] [nvarchar](1) NULL,
	[OldData] [text] NULL,
	[NewData] [text] NULL,
	[TableIdValue] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[UserName] [nvarchar](250) NULL,
 CONSTRAINT [PK_DBAudit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
