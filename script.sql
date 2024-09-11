USE [master]
GO
/****** Object:  Database [Contact]    Script Date: 9/11/2024 10:09:59 PM ******/
CREATE DATABASE [Contact]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Contact', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS01\MSSQL\DATA\Contact.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Contact_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS01\MSSQL\DATA\Contact_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Contact] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Contact].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Contact] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Contact] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Contact] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Contact] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Contact] SET ARITHABORT OFF 
GO
ALTER DATABASE [Contact] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Contact] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Contact] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Contact] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Contact] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Contact] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Contact] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Contact] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Contact] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Contact] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Contact] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Contact] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Contact] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Contact] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Contact] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Contact] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Contact] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Contact] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Contact] SET  MULTI_USER 
GO
ALTER DATABASE [Contact] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Contact] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Contact] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Contact] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Contact] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Contact] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Contact] SET QUERY_STORE = ON
GO
ALTER DATABASE [Contact] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Contact]
GO
/****** Object:  Table [dbo].[Contact]    Script Date: 9/11/2024 10:09:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[ContactID] [int] NOT NULL,
	[Last Name] [nchar](50) NOT NULL,
	[First Name] [nchar](50) NOT NULL,
	[Contact No] [nchar](50) NOT NULL,
	[Gender] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[ContactID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Contact] SET  READ_WRITE 
GO
