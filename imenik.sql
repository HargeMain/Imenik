USE [master]
GO

/****** Object:  Database [imenik]    Script Date: 11. 8. 2023. 18:20:06 ******/
CREATE DATABASE [imenik]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'imenik', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\imenik.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'imenik_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\imenik_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [imenik].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [imenik] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [imenik] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [imenik] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [imenik] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [imenik] SET ARITHABORT OFF 
GO

ALTER DATABASE [imenik] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [imenik] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [imenik] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [imenik] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [imenik] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [imenik] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [imenik] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [imenik] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [imenik] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [imenik] SET  DISABLE_BROKER 
GO

ALTER DATABASE [imenik] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [imenik] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [imenik] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [imenik] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [imenik] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [imenik] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [imenik] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [imenik] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [imenik] SET  MULTI_USER 
GO

ALTER DATABASE [imenik] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [imenik] SET DB_CHAINING OFF 
GO

ALTER DATABASE [imenik] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [imenik] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [imenik] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [imenik] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [imenik] SET QUERY_STORE = OFF
GO

ALTER DATABASE [imenik] SET  READ_WRITE 
GO

