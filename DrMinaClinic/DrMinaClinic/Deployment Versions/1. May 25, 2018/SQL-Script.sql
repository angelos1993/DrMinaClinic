USE [master]
GO
/****** Object:  Database [DrMinaClinic]    Script Date: 5/25/2018 12:25:22 PM ******/
CREATE DATABASE [DrMinaClinic]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DrMinaClinic', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\DrMinaClinic.mdf' , SIZE = 18432KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DrMinaClinic_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\DrMinaClinic_log.ldf' , SIZE = 7616KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DrMinaClinic] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DrMinaClinic].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DrMinaClinic] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DrMinaClinic] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DrMinaClinic] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DrMinaClinic] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DrMinaClinic] SET ARITHABORT OFF 
GO
ALTER DATABASE [DrMinaClinic] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DrMinaClinic] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [DrMinaClinic] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DrMinaClinic] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DrMinaClinic] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DrMinaClinic] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DrMinaClinic] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DrMinaClinic] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DrMinaClinic] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DrMinaClinic] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DrMinaClinic] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DrMinaClinic] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DrMinaClinic] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DrMinaClinic] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DrMinaClinic] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DrMinaClinic] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DrMinaClinic] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DrMinaClinic] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DrMinaClinic] SET RECOVERY FULL 
GO
ALTER DATABASE [DrMinaClinic] SET  MULTI_USER 
GO
ALTER DATABASE [DrMinaClinic] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DrMinaClinic] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DrMinaClinic] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DrMinaClinic] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DrMinaClinic', N'ON'
GO
USE [DrMinaClinic]
GO
/****** Object:  Table [dbo].[Examinations]    Script Date: 5/25/2018 12:25:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examinations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[PregnancyId] [int] NOT NULL,
	[Weeks] [int] NULL,
	[Weight] [float] NULL,
	[UterineSize] [int] NULL,
	[UrineAlb] [nvarchar](10) NULL,
	[UrineSuger] [bit] NULL,
	[BP] [nvarchar](50) NULL,
	[FundalHeight] [int] NULL,
	[Oedema] [bit] NULL,
	[Hb] [int] NULL,
	[Fhs] [int] NULL,
	[Engagement] [int] NULL,
	[UltraSoundNotes] [nvarchar](max) NULL,
 CONSTRAINT [PK_Examinations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Patients]    Script Date: 5/25/2018 12:25:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients](
	[Id] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[BirthDate] [date] NULL,
	[CreatedOn] [datetime] NOT NULL,
	[Twins] [int] NULL,
	[Diabetes] [bit] NULL,
	[Hypertension] [bit] NULL,
	[PastIllness] [nvarchar](max) NULL,
	[Operations] [nvarchar](max) NULL,
	[Allergies] [nvarchar](max) NULL,
	[Drugs] [nvarchar](max) NULL,
	[Heart] [nvarchar](max) NULL,
	[Lungs] [nvarchar](max) NULL,
	[VaricoseVenis] [nvarchar](max) NULL,
	[Pelvis] [nvarchar](max) NULL,
	[LowerLimbs] [nvarchar](max) NULL,
	[PV] [nvarchar](max) NULL,
	[AboGroup] [nvarchar](2) NULL,
	[RhesusGroup] [nvarchar](2) NULL,
	[CytomegaioVirus] [bit] NULL,
	[HbsAg] [bit] NULL,
	[HbcAb] [bit] NULL,
	[Bhcg] [int] NULL,
	[EstriolE3] [int] NULL,
	[Fbs] [int] NULL,
	[Cbc] [int] NULL,
	[Platelets] [int] NULL,
	[GeneralRemarks] [nvarchar](max) NULL,
 CONSTRAINT [PK_Patients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pregnancies]    Script Date: 5/25/2018 12:25:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pregnancies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [nvarchar](50) NOT NULL,
	[G] [int] NULL,
	[P1] [int] NULL,
	[P2] [int] NULL,
	[Vag] [int] NULL,
	[CS] [int] NULL,
	[No] [int] NOT NULL,
	[LMP] [date] NULL,
	[EDD] [date] NULL,
	[ActualBirthdate] [date] NULL,
	[IsCurrent] [bit] NOT NULL,
 CONSTRAINT [PK_Pregnancies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PregnancyDetails]    Script Date: 5/25/2018 12:25:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PregnancyDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PregnancyId] [int] NOT NULL,
	[Living] [bit] NOT NULL,
	[AF] [nvarchar](max) NULL,
	[Sex] [bit] NOT NULL,
	[Placenta] [nvarchar](max) NULL,
	[Weight] [float] NULL,
	[Presentation] [nvarchar](max) NULL,
	[Other] [nvarchar](max) NULL,
 CONSTRAINT [PK_PregnancyDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[Examinations]  WITH CHECK ADD  CONSTRAINT [FK_Examinations_Pregnancies] FOREIGN KEY([PregnancyId])
REFERENCES [dbo].[Pregnancies] ([Id])
GO
ALTER TABLE [dbo].[Examinations] CHECK CONSTRAINT [FK_Examinations_Pregnancies]
GO
ALTER TABLE [dbo].[Pregnancies]  WITH CHECK ADD  CONSTRAINT [FK_Pregnancies_Patients] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([Id])
GO
ALTER TABLE [dbo].[Pregnancies] CHECK CONSTRAINT [FK_Pregnancies_Patients]
GO
ALTER TABLE [dbo].[PregnancyDetails]  WITH CHECK ADD  CONSTRAINT [FK_PregnancyDetails_Pregnancies] FOREIGN KEY([PregnancyId])
REFERENCES [dbo].[Pregnancies] ([Id])
GO
ALTER TABLE [dbo].[PregnancyDetails] CHECK CONSTRAINT [FK_PregnancyDetails_Pregnancies]
GO
USE [master]
GO
ALTER DATABASE [DrMinaClinic] SET  READ_WRITE 
GO
