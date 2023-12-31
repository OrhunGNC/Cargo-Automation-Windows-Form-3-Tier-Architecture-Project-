USE [master]
GO
/****** Object:  Database [Cargo]    Script Date: 13.09.2023 09:52:30 ******/
CREATE DATABASE [Cargo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Cargo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLKODLAB\MSSQL\DATA\Cargo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Cargo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLKODLAB\MSSQL\DATA\Cargo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Cargo] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Cargo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Cargo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Cargo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Cargo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Cargo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Cargo] SET ARITHABORT OFF 
GO
ALTER DATABASE [Cargo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Cargo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Cargo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Cargo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Cargo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Cargo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Cargo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Cargo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Cargo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Cargo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Cargo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Cargo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Cargo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Cargo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Cargo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Cargo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Cargo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Cargo] SET RECOVERY FULL 
GO
ALTER DATABASE [Cargo] SET  MULTI_USER 
GO
ALTER DATABASE [Cargo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Cargo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Cargo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Cargo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Cargo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Cargo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Cargo', N'ON'
GO
ALTER DATABASE [Cargo] SET QUERY_STORE = ON
GO
ALTER DATABASE [Cargo] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Cargo]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[customerID] [int] IDENTITY(1,1) NOT NULL,
	[customerNameSurname] [varchar](50) NULL,
	[customerAdress] [varchar](50) NULL,
	[customerPhone] [varchar](11) NULL,
	[customerMail] [varchar](50) NULL,
	[customerPaymentStatus] [varchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[customerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[loginID] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[loginID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[personelID] [int] IDENTITY(1,1) NOT NULL,
	[personelNameSurname] [varchar](50) NULL,
	[personelTask] [varchar](50) NULL,
	[personelTitle] [varchar](50) NULL,
	[personelPhone] [varchar](11) NULL,
	[personelMail] [varchar](50) NULL,
	[personelSalary] [money] NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[personelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shipment]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shipment](
	[shipmentID] [int] IDENTITY(1,1) NOT NULL,
	[shipmentName] [varchar](50) NULL,
	[shipmentPickupPoint] [varchar](50) NULL,
	[shipmentTransportationPoint] [varchar](50) NULL,
	[shipmentDistance] [int] NULL,
	[shipmentFee] [money] NULL,
	[customerID] [int] NULL,
	[personelID] [int] NULL,
	[vehicleID] [int] NULL,
 CONSTRAINT [PK_Shipment] PRIMARY KEY CLUSTERED 
(
	[shipmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicle]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicle](
	[vehicleID] [int] IDENTITY(1,1) NOT NULL,
	[vehicleName] [varchar](50) NULL,
	[vehicleCapacity] [varchar](50) NULL,
	[vehicleDriver] [varchar](50) NULL,
	[vehicleExpense] [money] NULL,
 CONSTRAINT [PK_Vehicle] PRIMARY KEY CLUSTERED 
(
	[vehicleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([customerID], [customerNameSurname], [customerAdress], [customerPhone], [customerMail], [customerPaymentStatus]) VALUES (1, N'fadslah', N'lhfdsahla', N'05335423', N'asklfhsadkj', N'sdfajkdl')
INSERT [dbo].[Customer] ([customerID], [customerNameSurname], [customerAdress], [customerPhone], [customerMail], [customerPaymentStatus]) VALUES (2, N'fdsalkasdg', N'kljdfsgaklgadksf', N'0534234', N'asd', N'dfs')
INSERT [dbo].[Customer] ([customerID], [customerNameSurname], [customerAdress], [customerPhone], [customerMail], [customerPaymentStatus]) VALUES (3, N'sdfaasjl', N'kjldfsaglkasd', N'05343', N'dfaas', N'fdsafd')
INSERT [dbo].[Customer] ([customerID], [customerNameSurname], [customerAdress], [customerPhone], [customerMail], [customerPaymentStatus]) VALUES (4, N'dasfa', N'ajkldsfad', N'053434', N'fdsa', N'dfsa')
INSERT [dbo].[Customer] ([customerID], [customerNameSurname], [customerAdress], [customerPhone], [customerMail], [customerPaymentStatus]) VALUES (5, N'ali', N'adapazari', N'dfd', N'sdfad', N'dfsdf')
INSERT [dbo].[Customer] ([customerID], [customerNameSurname], [customerAdress], [customerPhone], [customerMail], [customerPaymentStatus]) VALUES (6, N'fdg', N'fdg', N'dfg', N'dfg', N'dfg')
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Login] ON 

INSERT [dbo].[Login] ([loginID], [username], [password]) VALUES (1, N'admin', N'1234')
SET IDENTITY_INSERT [dbo].[Login] OFF
GO
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([personelID], [personelNameSurname], [personelTask], [personelTitle], [personelPhone], [personelMail], [personelSalary]) VALUES (1, N'fdajsklga', N'fadksljlk', N'fasjdkl', N'053423', N'fdsa', 324234.0000)
INSERT [dbo].[Personel] ([personelID], [personelNameSurname], [personelTask], [personelTitle], [personelPhone], [personelMail], [personelSalary]) VALUES (2, N'fsdaklj', N'kdlfsqk', N'dfsak', N'05343', N'fsda', 3413.0000)
INSERT [dbo].[Personel] ([personelID], [personelNameSurname], [personelTask], [personelTitle], [personelPhone], [personelMail], [personelSalary]) VALUES (3, N'fdksja', N'fdjkgsa', N'fdksjag', N'0534243', N'sadfad', 23523.0000)
INSERT [dbo].[Personel] ([personelID], [personelNameSurname], [personelTask], [personelTitle], [personelPhone], [personelMail], [personelSalary]) VALUES (4, N'asfdas', N'fdkgja', N'jkfdsag', N'053442', N'fasd', 45334.0000)
SET IDENTITY_INSERT [dbo].[Personel] OFF
GO
SET IDENTITY_INSERT [dbo].[Shipment] ON 

INSERT [dbo].[Shipment] ([shipmentID], [shipmentName], [shipmentPickupPoint], [shipmentTransportationPoint], [shipmentDistance], [shipmentFee], [customerID], [personelID], [vehicleID]) VALUES (1, N'sdfa', N'fdsa', N'fdsa', 342, 13483.0000, 1, 1, 1)
INSERT [dbo].[Shipment] ([shipmentID], [shipmentName], [shipmentPickupPoint], [shipmentTransportationPoint], [shipmentDistance], [shipmentFee], [customerID], [personelID], [vehicleID]) VALUES (2, N'fdask', N'fkgdsakjh', N'fdgksjds', 324, 1343.0000, 2, 1, 3)
INSERT [dbo].[Shipment] ([shipmentID], [shipmentName], [shipmentPickupPoint], [shipmentTransportationPoint], [shipmentDistance], [shipmentFee], [customerID], [personelID], [vehicleID]) VALUES (3, N'fda', N'fsda', N'sdfa', 23, 423423.0000, 3, 2, 1)
INSERT [dbo].[Shipment] ([shipmentID], [shipmentName], [shipmentPickupPoint], [shipmentTransportationPoint], [shipmentDistance], [shipmentFee], [customerID], [personelID], [vehicleID]) VALUES (4, N'asd', N'fsad', N'sad', 324, 23423.0000, 2, 2, 2)
SET IDENTITY_INSERT [dbo].[Shipment] OFF
GO
SET IDENTITY_INSERT [dbo].[Vehicle] ON 

INSERT [dbo].[Vehicle] ([vehicleID], [vehicleName], [vehicleCapacity], [vehicleDriver], [vehicleExpense]) VALUES (1, N'sfda', N'fdsa', N'fdsa', 13413.0000)
INSERT [dbo].[Vehicle] ([vehicleID], [vehicleName], [vehicleCapacity], [vehicleDriver], [vehicleExpense]) VALUES (2, N'fdsa', N'fdsaa', N'fdsa', 34252.0000)
INSERT [dbo].[Vehicle] ([vehicleID], [vehicleName], [vehicleCapacity], [vehicleDriver], [vehicleExpense]) VALUES (3, N'fdsa', N'fdsa', N'fdsa', 54254.0000)
INSERT [dbo].[Vehicle] ([vehicleID], [vehicleName], [vehicleCapacity], [vehicleDriver], [vehicleExpense]) VALUES (4, N'dasd', N'asdsa', N'ssad', 2342312.0000)
INSERT [dbo].[Vehicle] ([vehicleID], [vehicleName], [vehicleCapacity], [vehicleDriver], [vehicleExpense]) VALUES (5, N'ddsa', N'asdafsd', N'ssadf', 2342312.0000)
SET IDENTITY_INSERT [dbo].[Vehicle] OFF
GO
ALTER TABLE [dbo].[Shipment]  WITH CHECK ADD  CONSTRAINT [FK_Shipment_Customer] FOREIGN KEY([customerID])
REFERENCES [dbo].[Customer] ([customerID])
GO
ALTER TABLE [dbo].[Shipment] CHECK CONSTRAINT [FK_Shipment_Customer]
GO
ALTER TABLE [dbo].[Shipment]  WITH CHECK ADD  CONSTRAINT [FK_Shipment_Personel] FOREIGN KEY([personelID])
REFERENCES [dbo].[Personel] ([personelID])
GO
ALTER TABLE [dbo].[Shipment] CHECK CONSTRAINT [FK_Shipment_Personel]
GO
ALTER TABLE [dbo].[Shipment]  WITH CHECK ADD  CONSTRAINT [FK_Shipment_Vehicle] FOREIGN KEY([vehicleID])
REFERENCES [dbo].[Vehicle] ([vehicleID])
GO
ALTER TABLE [dbo].[Shipment] CHECK CONSTRAINT [FK_Shipment_Vehicle]
GO
/****** Object:  StoredProcedure [dbo].[CustomerAdd]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CustomerAdd]
@customerNameSurname varchar(50),
@customerAdress varchar(50),
@customerPhone varchar(11),
@customerMail varchar(50),
@customerPaymentStatus varchar(50)
as begin
insert into Customer([customerNameSurname],[customerAdress],[customerPhone],[customerMail],[customerPaymentStatus])values(@customerNameSurname,@customerAdress,@customerPhone,@customerMail,@customerPaymentStatus)
end
GO
/****** Object:  StoredProcedure [dbo].[CustomerDel]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CustomerDel]
@customerID int
as begin
delete from Customer where customerID=@customerID
end
GO
/****** Object:  StoredProcedure [dbo].[CustomerList]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CustomerList]
as begin
select * from Customer
end
GO
/****** Object:  StoredProcedure [dbo].[CustomerSearch]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CustomerSearch]
@customerNameSurname varchar(50)
as begin
select * from Customer where customerNameSurname like '%'+@customerNameSurname+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[CustomerShipmentPersonel]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CustomerShipmentPersonel]
as begin
select cus.customerNameSurname,cus.customerPaymentStatus,cus.customerPhone,ship.shipmentName,ship.shipmentPickupPoint,ship.shipmentTransportationPoint,per.personelNameSurname,per.personelMail,per.personelPhone from Customer cus join Shipment ship on cus.customerID=ship.customerID join Personel per on per.personelID=ship.personelID order by per.personelNameSurname
end
GO
/****** Object:  StoredProcedure [dbo].[CustomerUpdate]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CustomerUpdate]
@customerID int,
@customerNameSurname varchar(50),
@customerAdress varchar(50),
@customerPhone varchar(11),
@customerMail varchar(50),
@customerPaymentStatus varchar(50)
as begin
update Customer set customerNameSurname=@customerNameSurname,customerAdress=@customerAdress,customerPhone=@customerPhone,customerMail=@customerMail,customerPaymentStatus=@customerPaymentStatus where customerID=@customerID
end
GO
/****** Object:  StoredProcedure [dbo].[PersonelAdd]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PersonelAdd]
@personelNameSurname varchar(50),
@personelTask varchar(50),
@personelTitle varchar(50),
@personelPhone varchar(11),
@personelMail varchar(50),
@personelSalary money
as begin
insert into Personel([personelNameSurname],[personelTask],[personelTitle],[personelPhone],[personelMail],[personelSalary])values(@personelNameSurname,@personelTask,@personelTitle,@personelPhone,@personelMail,@personelSalary)
end
GO
/****** Object:  StoredProcedure [dbo].[PersonelList]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PersonelList]
as begin
select * from Personel
end
GO
/****** Object:  StoredProcedure [dbo].[PersonelSearch]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PersonelSearch]
@personelNameSurname varchar(50)
as begin
select * from Personel where personelNameSurname like '%'+@personelNameSurname+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[PersonelUpdate]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PersonelUpdate]
@personelID int,
@personelNameSurname varchar(50),
@personelTask varchar(50),
@personelTitle varchar(50),
@personelPhone varchar(11),
@personelMail varchar(50),
@personelSalary money
as begin
update Personel set personelNameSurname=@personelNameSurname,personelTask=@personelTask,personelTitle=@personelTitle,personelPhone=@personelPhone,personelMail=@personelMail,personelSalary=@personelSalary where personelID=@personelID
end
GO
/****** Object:  StoredProcedure [dbo].[ShipmentAdd]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ShipmentAdd]
@shipmentName varchar(50),
@shipmentPickupPoint varchar(50),
@shipmentTransportationPoint varchar(50),
@shipmentDistance int,
@shipmentFee money,
@customerID int,
@personelID int,
@vehicleID int
as begin
insert into Shipment([shipmentName],[shipmentPickupPoint],[shipmentTransportationPoint],[shipmentDistance],[shipmentFee],[customerID],[personelID],[vehicleID])values(@shipmentName,@shipmentPickupPoint,@shipmentTransportationPoint,@shipmentDistance,@shipmentFee,@customerID,@personelID,@vehicleID)
end
GO
/****** Object:  StoredProcedure [dbo].[ShipmentCustomer]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ShipmentCustomer]
as begin
select ship.shipmentName,ship.shipmentPickupPoint,ship.shipmentTransportationPoint,cust.customerNameSurname,cust.customerPaymentStatus,cust.customerAdress from Shipment ship join Customer cust on ship.customerID=cust.customerID order by cust.customerPaymentStatus
end
GO
/****** Object:  StoredProcedure [dbo].[ShipmentDel]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ShipmentDel]
@shipmentID int
as begin
delete from Shipment where shipmentID=@shipmentID
end
GO
/****** Object:  StoredProcedure [dbo].[ShipmentList]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ShipmentList]
as begin
select * from Shipment
end
GO
/****** Object:  StoredProcedure [dbo].[ShipmentPersonel]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ShipmentPersonel]
as begin
select ship.shipmentDistance,ship.shipmentFee,ship.shipmentName,per.personelNameSurname,per.personelMail,per.personelTask,per.personelTitle from Shipment ship join Personel per on ship.personelID=per.personelID order by ship.shipmentDistance desc
end
GO
/****** Object:  StoredProcedure [dbo].[ShipmentSearch]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ShipmentSearch]
@shipmentName varchar(50)
as begin
select * from Shipment where shipmentName like '%'+@shipmentName+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[ShipmentUpdate]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ShipmentUpdate]
@shipmentID int,
@shipmentName varchar(50),
@shipmentPickupPoint varchar(50),
@shipmentTransportationPoint varchar(50),
@shipmentDistance int,
@shipmentFee money,
@customerID int,
@personelID int,
@vehicleID int
as begin
update Shipment set shipmentName=@shipmentName,shipmentPickupPoint=@shipmentPickupPoint,shipmentTransportationPoint=@shipmentTransportationPoint,shipmentDistance=@shipmentDistance,shipmentFee=@shipmentFee,customerID=@customerID,personelID=@personelID,vehicleID=@vehicleID where shipmentID=@shipmentID
end
GO
/****** Object:  StoredProcedure [dbo].[ShipmentVehicle]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ShipmentVehicle]
as begin
select ship.shipmentFee,ship.shipmentDistance,ship.shipmentName,veh.vehicleCapacity,veh.vehicleDriver,veh.vehicleExpense,veh.vehicleName from Shipment ship join Vehicle veh on ship.vehicleID=veh.vehicleID order by ship.shipmentFee asc
end
GO
/****** Object:  StoredProcedure [dbo].[VehicleAdd]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[VehicleAdd]
@vehicleName varchar(50),
@vehicleCapacity varchar(50),
@vehicleDriver varchar(50),
@vehicleExpense money
as begin
insert into Vehicle([vehicleName],[vehicleCapacity],[vehicleDriver],[vehicleExpense])values(@vehicleName,@vehicleCapacity,@vehicleDriver,@vehicleExpense)
end
GO
/****** Object:  StoredProcedure [dbo].[VehicleList]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[VehicleList]
as begin
select * from Vehicle
end
GO
/****** Object:  StoredProcedure [dbo].[VehicleSearch]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[VehicleSearch]
@vehicleName varchar(50)
as begin
select * from Vehicle where vehicleName like '%'+@vehicleName+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[VehicleShipmentPersonel]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[VehicleShipmentPersonel]
as begin
select veh.vehicleDriver,veh.vehicleName,veh.vehicleCapacity,ship.shipmentDistance,ship.shipmentFee,ship.shipmentName,per.personelNameSurname,per.personelTask,per.personelTitle from Vehicle veh join Shipment ship on ship.vehicleID=veh.vehicleID join Personel per on per.personelID=ship.personelID order by ship.shipmentFee desc
end
GO
/****** Object:  StoredProcedure [dbo].[VehicleShipmentPersonelCustomer]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[VehicleShipmentPersonelCustomer]
as begin
select veh.vehicleDriver,veh.vehicleExpense,ship.shipmentFee,ship.shipmentDistance,per.personelNameSurname,per.personelPhone,cust.customerAdress,cust.customerPhone from Vehicle veh join Shipment ship on ship.vehicleID = veh.vehicleID join Personel per on per.personelID=ship.personelID join Customer cust on cust.customerID=ship.customerID order by ship.shipmentFee desc
end
GO
/****** Object:  StoredProcedure [dbo].[VehicleUpdate]    Script Date: 13.09.2023 09:52:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[VehicleUpdate]
@vehicleID int,
@vehicleName varchar(50),
@vehicleCapacity varchar(50),
@vehicleDriver varchar(50),
@vehicleExpense money
as begin
update Vehicle set vehicleName=@vehicleName,vehicleCapacity=@vehicleCapacity,vehicleDriver=@vehicleDriver,vehicleExpense=@vehicleExpense where vehicleID=@vehicleID
end
GO
USE [master]
GO
ALTER DATABASE [Cargo] SET  READ_WRITE 
GO
