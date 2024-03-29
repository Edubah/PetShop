USE [master]
GO
/****** Object:  Database [petshop]    Script Date: 03/05/2020 14:46:15 ******/
CREATE DATABASE [petshop] ON  PRIMARY 
( NAME = N'petshop', FILENAME = N'C:\BD\petshop.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'petshop_log', FILENAME = N'C:\BD\petshop_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [petshop] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [petshop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [petshop] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [petshop] SET ANSI_NULLS OFF
GO
ALTER DATABASE [petshop] SET ANSI_PADDING OFF
GO
ALTER DATABASE [petshop] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [petshop] SET ARITHABORT OFF
GO
ALTER DATABASE [petshop] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [petshop] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [petshop] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [petshop] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [petshop] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [petshop] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [petshop] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [petshop] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [petshop] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [petshop] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [petshop] SET  DISABLE_BROKER
GO
ALTER DATABASE [petshop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [petshop] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [petshop] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [petshop] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [petshop] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [petshop] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [petshop] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [petshop] SET  READ_WRITE
GO
ALTER DATABASE [petshop] SET RECOVERY SIMPLE
GO
ALTER DATABASE [petshop] SET  MULTI_USER
GO
ALTER DATABASE [petshop] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [petshop] SET DB_CHAINING OFF
GO
USE [petshop]
GO
/****** Object:  Table [dbo].[servico]    Script Date: 03/05/2020 14:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[servico](
	[serv_codigo] [int] IDENTITY(1,1) NOT NULL,
	[serv_descricao] [varchar](50) NOT NULL,
	[serv_preco] [decimal](5, 2) NOT NULL,
	[serv_tempo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[serv_codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[raca]    Script Date: 03/05/2020 14:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[raca](
	[raca_codigo] [int] IDENTITY(1,1) NOT NULL,
	[raca_nome] [varchar](50) NOT NULL,
	[raca_pais_origem] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[raca_codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 03/05/2020 14:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cliente](
	[cli_codigo] [int] IDENTITY(1,1) NOT NULL,
	[cli_nome] [varchar](50) NOT NULL,
	[cli_celular] [varchar](15) NOT NULL,
	[cli_email] [varchar](50) NULL,
	[cli_cpf] [char](14) NULL,
	[cli_endereco] [varchar](100) NOT NULL,
	[cli_foto] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[cli_codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[animal]    Script Date: 03/05/2020 14:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[animal](
	[ani_codigo] [int] IDENTITY(1,1) NOT NULL,
	[ani_nome] [varchar](50) NOT NULL,
	[ani_sexo] [char](1) NOT NULL,
	[ani_agressivo] [char](1) NOT NULL,
	[ani_cor] [varchar](25) NOT NULL,
	[ani_idade] [int] NOT NULL,
	[ani_alergia] [varchar](50) NULL,
	[ani_cliente] [int] NOT NULL,
	[ani_raca] [int] NOT NULL,
	[ani_foto] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[ani_codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[agendamento]    Script Date: 03/05/2020 14:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[agendamento](
	[ag_codigo] [int] IDENTITY(1,1) NOT NULL,
	[ag_data] [date] NOT NULL,
	[ag_horario] [time](7) NOT NULL,
	[ag_situacao] [varchar](15) NOT NULL,
	[ag_animal] [int] NOT NULL,
	[ag_total] [numeric](5, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ag_codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[agendamento_servicos]    Script Date: 03/05/2020 14:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[agendamento_servicos](
	[ag_serv_numero] [int] IDENTITY(1,1) NOT NULL,
	[ag_serv_agendamento] [int] NOT NULL,
	[ag_serv_servico] [int] NOT NULL,
	[ag_serv_quantidade] [int] NOT NULL,
	[ag_serv_valor_unitario] [decimal](5, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[ag_serv_numero] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF__agendamen__ag_to__182C9B23]    Script Date: 03/05/2020 14:46:16 ******/
ALTER TABLE [dbo].[agendamento] ADD  DEFAULT ((0)) FOR [ag_total]
GO
/****** Object:  ForeignKey [FK__animal__ani_clie__08EA5793]    Script Date: 03/05/2020 14:46:16 ******/
ALTER TABLE [dbo].[animal]  WITH CHECK ADD FOREIGN KEY([ani_cliente])
REFERENCES [dbo].[cliente] ([cli_codigo])
GO
/****** Object:  ForeignKey [FK__animal__ani_raca__09DE7BCC]    Script Date: 03/05/2020 14:46:16 ******/
ALTER TABLE [dbo].[animal]  WITH CHECK ADD FOREIGN KEY([ani_raca])
REFERENCES [dbo].[raca] ([raca_codigo])
GO
/****** Object:  ForeignKey [FK__agendamen__ag_an__1920BF5C]    Script Date: 03/05/2020 14:46:16 ******/
ALTER TABLE [dbo].[agendamento]  WITH CHECK ADD FOREIGN KEY([ag_animal])
REFERENCES [dbo].[animal] ([ani_codigo])
GO
/****** Object:  ForeignKey [FK__agendamen__ag_se__1DE57479]    Script Date: 03/05/2020 14:46:16 ******/
ALTER TABLE [dbo].[agendamento_servicos]  WITH CHECK ADD FOREIGN KEY([ag_serv_servico])
REFERENCES [dbo].[servico] ([serv_codigo])
GO
/****** Object:  ForeignKey [FK__agendamen__ag_se__1ED998B2]    Script Date: 03/05/2020 14:46:16 ******/
ALTER TABLE [dbo].[agendamento_servicos]  WITH CHECK ADD FOREIGN KEY([ag_serv_agendamento])
REFERENCES [dbo].[agendamento] ([ag_codigo])
GO
