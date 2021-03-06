USE [master]
GO
/****** Object:  Database [YT_DB]    Script Date: 26/10/2020 10:52:06 AM ******/
CREATE DATABASE [YT_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'YT_DB', FILENAME = N'E:\Data\New Data\YT_DB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'YT_DB_log', FILENAME = N'E:\Data\New Data\YT_DB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [YT_DB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [YT_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [YT_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [YT_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [YT_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [YT_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [YT_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [YT_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [YT_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [YT_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [YT_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [YT_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [YT_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [YT_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [YT_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [YT_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [YT_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [YT_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [YT_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [YT_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [YT_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [YT_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [YT_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [YT_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [YT_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [YT_DB] SET  MULTI_USER 
GO
ALTER DATABASE [YT_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [YT_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [YT_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [YT_DB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [YT_DB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'YT_DB', N'ON'
GO
USE [YT_DB]
GO
/****** Object:  UserDefinedFunction [dbo].[ActionBy]    Script Date: 26/10/2020 10:52:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE function [dbo].[ActionBy] (@BookingID bigint)
returns nvarchar(10) as
begin
	
	declare @Result nvarchar(10);
	SET @Result = (select top 1 LoginID from Comment where BookingID = @BookingID order by CommentID desc);
	
	if (@Result IS NULL)
		begin
			SET @Result = (select LoginID from Booking where BookingID = @BookingID);
		end

	return @Result
end


GO
/****** Object:  UserDefinedFunction [dbo].[AdjustedPrice]    Script Date: 26/10/2020 10:52:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create function [dbo].[AdjustedPrice] (@BookingID bigint)
returns decimal(14,2) as
begin
	
	declare @Result decimal(14,2);
	SET @Result = (select top 1 Calculation from Comment where BookingID = @BookingID order by CommentID desc);
	return @Result
end
GO
/****** Object:  UserDefinedFunction [dbo].[ConvertRate]    Script Date: 26/10/2020 10:52:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[ConvertRate] (
@Currency NCHAR(3),
@Date DATE,
@Rate DECIMAL(14,2)
) RETURNS DECIMAL(14,2)
AS
BEGIN
	DECLARE @Result DECIMAL(14,2);
	DECLARE @Exchange DECIMAL(14,4) = (
		SELECT TOP 1 Rate
		FROM Exchange
		WHERE Currency = @Currency AND EffectiveDate <= @Date
		ORDER BY EffectiveDate DESC
	);

	SET @Result = @Rate / @Exchange;

	RETURN @Result;
END


GO
/****** Object:  UserDefinedFunction [dbo].[Dispute]    Script Date: 26/10/2020 10:52:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Dispute] (@BookingID BIGINT) RETURNS Nvarchar(15)
AS
BEGIN
	DECLARE @Result Nvarchar(15);
	SET @Result = (SELECT TOP 1 [Status] FROM Comment WHERE BookingID = @BookingID ORDER BY CommentID DESC);
	RETURN @Result;
END

GO
/****** Object:  UserDefinedFunction [dbo].[ExcessiveMargin]    Script Date: 26/10/2020 10:52:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[ExcessiveMargin] (@MarginEUR float, @Destination nvarchar(2), @TO nvarchar(20), @EffectiveDate date) RETURNS TINYINT
AS
BEGIN
	DECLARE @Result INT;

	DECLARE @Markup FLOAT;
	SET @Markup = (@MarginEUR * 100);

	DECLARE @MinMarkup FLOAT;
	DECLARE @MaxMarkup FLOAT;

	SELECT TOP 1 @MinMarkup = Margin.MarginFrom, @MaxMarkup = Margin.MarginTo
		FROM Margin, Destination, TourOperator
		WHERE Margin.DestinationID = Destination.DestinationID
		AND Margin.TourOperatorID = TourOperator.TourOperatorID
		AND  Destination.DestinationCode = @Destination
		AND @EffectiveDate >= Margin.EffectiveDate
		AND TourOperator.TourOperator = @TO
		ORDER BY Margin.EffectiveDate DESC;

	IF (@MinMarkup IS NULL)
		BEGIN
			SET @Result = 1
		END
	ELSE IF (@Markup BETWEEN @MinMarkup AND @MaxMarkup)
		BEGIN
			SET @Result = 0;
		END
	ELSE
		BEGIN

			IF (@MinMarkup IS NULL)
				begin
					SET @Result = 1;
				end
			else
				begin
					SET @Result = 0;
				end
			
		END


	RETURN @Result;
END





GO
/****** Object:  UserDefinedFunction [dbo].[LastComment]    Script Date: 26/10/2020 10:52:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create function [dbo].[LastComment] (@BookingID bigint)
returns nvarchar(350) as
begin
	
	declare @Result nvarchar(350);
	SET @Result = (select top 1 Comment from Comment where BookingID = @BookingID order by CommentID desc);
	return @Result
end
GO
/****** Object:  UserDefinedFunction [dbo].[LastStatus]    Script Date: 26/10/2020 10:52:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[LastStatus] (@BookingID bigint)
returns nvarchar(20) as
begin

	declare @Result nvarchar(20) = (
	select top 1 Comment.Status AS LastStatus
	from Login, Comment
	where Comment.LoginID = Login.LoginID
	and Comment.BookingID = @BookingID
	order by Comment.CommentID desc
	)
	
	return @Result
end
GO
/****** Object:  UserDefinedFunction [dbo].[Mismatch]    Script Date: 26/10/2020 10:52:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [dbo].[Mismatch] (@DifferenceEUR float, @Destination nvarchar(2), @TO nvarchar(20), @EffectiveDate date) RETURNS tinyINT
AS
BEGIN
	DECLARE @Result INT;

	DECLARE @Difference FLOAT;
	SET @Difference = COALESCE(@DifferenceEUR, 0);

	DECLARE @MinDifference FLOAT;
	DECLARE @MaxDifference FLOAT;

	SELECT TOP 1 @MinDifference = Margin.DifferenceFrom, @MaxDifference = Margin.DifferenceTo
		FROM Margin, Destination, TourOperator
		WHERE Margin.DestinationID = Destination.DestinationID
		AND Margin.TourOperatorID = TourOperator.TourOperatorID
		AND Destination.DestinationCode = @Destination
		AND @EffectiveDate >= Margin.EffectiveDate
		AND TourOperator.TourOperator = @TO
		ORDER BY Margin.EffectiveDate DESC;


	IF (@Difference BETWEEN @MinDifference AND @MaxDifference)
		BEGIN
			SET @Result = 0;
		END
	ELSE
		BEGIN
			SET @Result = 1;
		END


	RETURN @Result;
END



GO
/****** Object:  Table [dbo].[Booking]    Script Date: 26/10/2020 10:52:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[BookingID] [bigint] IDENTITY(11111,1) NOT NULL,
	[Reference] [nvarchar](10) NULL,
	[HotelCode] [nvarchar](10) NULL,
	[HotelName] [nvarchar](150) NULL,
	[HotelCountry] [nvarchar](2) NULL,
	[GwgStatus] [nvarchar](10) NULL,
	[PurchaseCurrency] [nvarchar](3) NULL,
	[PurchasePrice] [decimal](14, 2) NULL,
	[SalesCurrency] [nvarchar](3) NULL,
	[SalesPrice] [decimal](14, 2) NULL,
	[GwgHandlingFee] [decimal](14, 2) NULL,
	[Margin] [decimal](14, 2) NULL,
	[Difference] [decimal](14, 2) NULL,
	[CurrencyHotelTC] [nvarchar](3) NULL,
	[NetRateHotelTC] [decimal](14, 2) NULL,
	[NetRateHandlingTC] [decimal](14, 2) NULL,
	[CheckHotel] [nvarchar](3) NULL,
	[CompanyGroup] [nvarchar](20) NULL,
	[BookingDate] [date] NULL,
	[TravelDate] [date] NULL,
	[RoomType] [nvarchar](3) NULL,
	[Board] [nvarchar](3) NULL,
	[Duration] [int] NULL,
	[TransferTo] [nvarchar](3) NULL,
	[TransferFrom] [nvarchar](3) NULL,
	[Pax] [tinyint] NULL,
	[Adult] [tinyint] NULL,
	[Child] [tinyint] NULL,
	[ImportDate] [date] NULL,
	[IncomingAgency] [nvarchar](25) NULL,
	[BookingStateDesc] [nvarchar](15) NULL,
	[HotelFlag] [nvarchar](15) NULL,
	[MissingBookings] [nvarchar](15) NULL,
	[MarginCheck] [nvarchar](15) NULL,
	[DifferenceTOPrice] [nvarchar](15) NULL,
	[ActionBy] [int] NULL,
	[Status] [nvarchar](20) NULL,
	[Comments] [nvarchar](350) NULL,
	[AdjustedPrice] [decimal](14, 2) NULL,
	[PriceBreakdown] [nvarchar](150) NULL,
	[LoginID] [int] NULL,
	[Junk] [bit] NULL DEFAULT ((0)),
	[PurchasePriceEUR] [decimal](14, 2) NULL,
	[SalesPriceEUR] [decimal](14, 2) NULL,
	[MarginEUR] [decimal](14, 2) NULL,
	[NetRateEUR] [decimal](14, 2) NULL,
	[DifferenceEUR] [decimal](14, 2) NULL,
	[BookingStatus] [nchar](3) NOT NULL DEFAULT ('New'),
	[MPImportDate] [date] NULL,
	[SysImportDate] [date] NOT NULL DEFAULT (getdate()),
	[MissingCurrency] [bit] NOT NULL DEFAULT ((1)),
	[MissingDestination] [bit] NOT NULL DEFAULT ((1)),
	[MissingTo] [bit] NOT NULL DEFAULT ((1)),
	[MissingMargin] [bit] NOT NULL DEFAULT ((1)),
	[NegativeMargin] [bit] NOT NULL DEFAULT ((1)),
	[ExcessiveMargin] [bit] NOT NULL DEFAULT ((1)),
	[MismatchCalc] [bit] NOT NULL DEFAULT ((1)),
	[Log] [nvarchar](60) NULL DEFAULT (''),
	[Locked] [int] NULL DEFAULT (NULL),
	[LockTime] [datetime] NULL DEFAULT (NULL),
PRIMARY KEY CLUSTERED 
(
	[BookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Comment]    Script Date: 26/10/2020 10:52:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[CommentID] [bigint] IDENTITY(1,1) NOT NULL,
	[BookingID] [bigint] NULL,
	[Date] [datetime] NULL DEFAULT (getdate()),
	[Comment] [nvarchar](350) NULL,
	[Calculation] [decimal](14, 2) NULL,
	[Status] [nvarchar](15) NOT NULL,
	[LoginID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CommentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Destination]    Script Date: 26/10/2020 10:52:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Destination](
	[DestinationID] [int] IDENTITY(11,1) NOT NULL,
	[DestinationCode] [nvarchar](2) NOT NULL,
	[Destination] [nvarchar](30) NOT NULL DEFAULT (''),
PRIMARY KEY CLUSTERED 
(
	[DestinationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[DestinationCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Exchange]    Script Date: 26/10/2020 10:52:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exchange](
	[ExchangeID] [int] IDENTITY(1,1) NOT NULL,
	[Currency] [nchar](3) NOT NULL,
	[Rate] [decimal](14, 4) NOT NULL,
	[EffectiveDate] [date] NOT NULL DEFAULT (getdate()),
	[LoginID] [int] NULL,
	[TimeAdded] [datetime] NOT NULL DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[ExchangeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Login]    Script Date: 26/10/2020 10:52:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[LoginID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](10) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[Mail] [nvarchar](50) NULL,
	[Password] [nvarchar](100) NOT NULL,
	[Authority] [nvarchar](10) NOT NULL DEFAULT ('USER'),
	[Active] [bit] NOT NULL DEFAULT ((1)),
	[InvalidLogins] [tinyint] NOT NULL DEFAULT ((0)),
	[Locked] [bit] NOT NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[LoginID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Margin]    Script Date: 26/10/2020 10:52:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Margin](
	[MarginID] [int] IDENTITY(1,1) NOT NULL,
	[DestinationID] [int] NULL,
	[TourOperatorID] [int] NULL,
	[MarginFrom] [float] NOT NULL DEFAULT ((0)),
	[MarginTo] [float] NOT NULL DEFAULT ((0)),
	[DifferenceFrom] [float] NOT NULL DEFAULT ((0)),
	[DifferenceTo] [float] NOT NULL DEFAULT ((0)),
	[EffectiveDate] [date] NOT NULL DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[MarginID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TourOperator]    Script Date: 26/10/2020 10:52:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TourOperator](
	[TourOperatorID] [int] IDENTITY(11,1) NOT NULL,
	[TourOperator] [nvarchar](30) NULL DEFAULT (''),
PRIMARY KEY CLUSTERED 
(
	[TourOperatorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserDestination]    Script Date: 26/10/2020 10:52:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserDestination](
	[UserDestinationID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[DestinationID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserDestinationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserOperator]    Script Date: 26/10/2020 10:52:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserOperator](
	[UserOperatorID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[TourOperatorID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserOperatorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  UserDefinedFunction [dbo].[BookingStatus]    Script Date: 26/10/2020 10:52:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[BookingStatus] (@BookingID bigint)
returns table as
return
(
	select top 1
	(case when Comment.Status = 0 then 'Pending DMC' when Comment.Status = 1 then 'Fixed DMC'
	when Comment.Status = 2 then 'Pending TO' when Comment.Status = 3 then 'Fixed TO' ELSE '' end) AS LastStatus,
	Comment.Calculation as AdjustedPrice, Login.Username as ActionBy
	from Login, Comment
	where Comment.LoginID = Login.LoginID
	and Comment.BookingID = @BookingID
	order by Comment.CommentID desc
)

GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD FOREIGN KEY([ActionBy])
REFERENCES [dbo].[Login] ([LoginID])
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD FOREIGN KEY([ActionBy])
REFERENCES [dbo].[Login] ([LoginID])
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD FOREIGN KEY([Locked])
REFERENCES [dbo].[Login] ([LoginID])
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD FOREIGN KEY([LoginID])
REFERENCES [dbo].[Login] ([LoginID])
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD FOREIGN KEY([BookingID])
REFERENCES [dbo].[Booking] ([BookingID])
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD FOREIGN KEY([LoginID])
REFERENCES [dbo].[Login] ([LoginID])
GO
ALTER TABLE [dbo].[Exchange]  WITH CHECK ADD FOREIGN KEY([LoginID])
REFERENCES [dbo].[Login] ([LoginID])
GO
ALTER TABLE [dbo].[Margin]  WITH CHECK ADD FOREIGN KEY([DestinationID])
REFERENCES [dbo].[Destination] ([DestinationID])
GO
ALTER TABLE [dbo].[Margin]  WITH CHECK ADD FOREIGN KEY([TourOperatorID])
REFERENCES [dbo].[TourOperator] ([TourOperatorID])
GO
ALTER TABLE [dbo].[UserDestination]  WITH CHECK ADD FOREIGN KEY([DestinationID])
REFERENCES [dbo].[Destination] ([DestinationID])
GO
ALTER TABLE [dbo].[UserDestination]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Login] ([LoginID])
GO
ALTER TABLE [dbo].[UserOperator]  WITH CHECK ADD FOREIGN KEY([TourOperatorID])
REFERENCES [dbo].[TourOperator] ([TourOperatorID])
GO
ALTER TABLE [dbo].[UserOperator]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Login] ([LoginID])
GO
/****** Object:  StoredProcedure [dbo].[SaveBooking]    Script Date: 26/10/2020 10:52:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SaveBooking] 
	@BookingsID bigint,
	@Reference nvarchar(10),
	@HotelCode nvarchar(10),
	@HotelName nvarchar(150),
	@HotelCountry nvarchar(2),
	@GwgStatus nvarchar(10),
	@PurchaseCurrency nvarchar(3),
	@PurchasePrice decimal(14,2),
	@SalesCurrency nvarchar(3),
	@SalesPrice decimal(14,2),
	@GwgHandlingFee decimal(14,2),
	@Margin decimal(14,2),
	@Difference decimal(14,2),
	@CurrencyHotelTC nvarchar(3),
	@NetRateHotelTC decimal(14,2),
	@NetRateHandlingTC decimal(14,2),
	@CheckHotel nvarchar(3),
	@CompanyGroup nvarchar(20),
	@BookingDate date,
	@TravelDate date,
	@RoomType nvarchar(3),
	@Board nvarchar(3),
	@Duration int,
	@TransferTo nvarchar(3),
	@TransferFrom nvarchar(3),
	@Pax tinyint,
	@Adult tinyint,
	@Child tinyint,
	@ImportDate date,
	@IncomingAgency nvarchar(25),
	@BookingStateDesc nvarchar(15),
	@HotelFlag nvarchar(15),
	@MissingBookings nvarchar(15),
	@MarginCheck nvarchar(15),
	@DifferenceTOPrice nvarchar(15),
	@ActionBy nvarchar(15),
	@PriceBreakdown nvarchar(300),
	@LoginID int,
	@Junk bit,
	@BookingStatus nchar(3),
	@MPImportDate date
AS
    DECLARE @Existing INT = (SELECT COUNT(*) FROM Booking WHERE Reference = @Reference AND HotelCode = @HotelCode);
	DECLARE @Result TINYINT;

	DECLARE @PurchasePriceEUR DECIMAL(14,2);
	DECLARE @SalesPriceEUR DECIMAL(14,2);
	DECLARE @MarginEUR DECIMAL(14,2);
	DECLARE @NetRateEUR DECIMAL(14,2);
	DECLARE @DifferenceEUR DECIMAL(14,2);

	DECLARE @MissingCurrency bit = 0;
	DECLARE @MissingDestination bit = 1;
	DECLARE @MissingTO bit = 1;
	DECLARE @MissingMargin BIT = 1;
	DECLARE @NegativeMargin bit = 1;
	DECLARE @ExcessiveMargin bit = 1;
	DECLARE @MismatchCalc bit = 1;
	DECLARE @Log nvarchar(60);

	IF (@PurchaseCurrency NOT IN (SELECT Currency FROM Exchange WHERE TimeAdded <= @TravelDate)) OR
		(@SalesCurrency NOT IN (SELECT Currency FROM Exchange WHERE TimeAdded <= @TravelDate)) OR
		(@CurrencyHotelTC NOT IN (SELECT Currency FROM Exchange WHERE TimeAdded <= @TravelDate))
		BEGIN
			SET @MissingCurrency = 1;
		END
	IF (@HotelCountry IN (SELECT DestinationCode FROM Destination))
		BEGIN
			SET @MissingDestination = 0
		END

	IF (@CompanyGroup IN (SELECT TourOperator FROM TourOperator))
		BEGIN
			SET @MissingTO = 0
		END
	IF ((SELECT COUNT(*) FROM Margin, Destination, TourOperator WHERE Margin.DestinationID = Destination.DestinationID
		AND Margin.TourOperatorID = TourOperator.TourOperatorID
		AND Destination.DestinationCode = @HotelCountry
		AND TourOperator.TourOperator = @CompanyGroup
		AND Margin.EffectiveDate <= @TravelDate) != 0)
		BEGIN
			SET @MissingMargin = 0;
		END
	
	IF (@MissingCurrency = 0 AND @MissingDestination = 0 AND @MissingTO = 0 AND @MissingMargin = 0)
		BEGIN
			SET @Log = 'OK';
		END
	ELSE
		BEGIN
			SET @Log = IIF(@MissingCurrency = 1, 'Missing Currency', '');
			SET @Log = IIF(@MissingDestination = 1, IIF(@Log = '', 'Missing Country', @Log + '-Missing Country'), @Log)
			SET @Log = IIF(@MissingTO = 1, IIF(@Log = '', 'Missing T/O', @Log + '-Missing T/O'), @Log)
			SET @Log = IIF(@MissingMargin = 1, IIF(@Log = '', 'Missing Margin', @Log + '-Missing Margin'), @Log)
		END


	SET @PurchasePriceEUR = dbo.ConvertRate(@PurchaseCurrency, @TravelDate, @PurchasePrice);
	SET @SalesPriceEUR = dbo.ConvertRate(@SalesCurrency, @TravelDate, @SalesPrice);
	IF (@PurchasePriceEUR != 0)
		BEGIN
			SET @MarginEUR = (@SalesPriceEUR - @PurchasePriceEUR) / @SalesPriceEUR;
		END
	ELSE
		BEGIN
			SET @MarginEUR = 0
		END
	
	SET @NetRateEUR = dbo.ConvertRate(@CurrencyHotelTC, @TravelDate, @NetRateHotelTC);
	SET @DifferenceEUR = (@SalesPriceEUR - @NetRateEUR);
	DECLARE @BookingToAdjust BIGINT;
	IF (@Existing > 1)
		BEGIN
			SET @BookingToAdjust = (SELECT BookingID FROM Booking 
									WHERE Reference = @Reference 
									AND HotelCode = @HotelCode
									AND TravelDate = @TravelDate);
		END

	SET @NegativeMargin = (IIF(@MarginEUR < 0, 1, 0));
	SET @ExcessiveMargin = dbo.ExcessiveMargin(@MarginEUR, @HotelCountry, @CompanyGroup, @TravelDate);
	SET @MismatchCalc = dbo.Mismatch(@DifferenceEUR, @HotelCountry, @CompanyGroup, @TravelDate);

	IF (@Existing = 0)
		BEGIN
			INSERT INTO Booking (Reference, Hotelcode, Hotelname, HotelCountry, GwgStatus, PurchaseCurrency, PurchasePrice,
			SalesCurrency, SalesPrice, GWGHandlingFee, Margin, Difference, CurrencyHotelTC, NetRateHotelTC, NetRateHandlingTC,
			CheckHotel, CompanyGroup, Bookingdate, Traveldate, Roomtype, Board, Duration, TransferTo, TransferFrom, Pax, Adult,
			Child, ImportDate, IncomingAgency, BookingStateDesc, HotelFlag, MissingBookings, MarginCheck, DifferenceTOPrice,
			ActionBy, PriceBreakdown, LoginID, Junk, PurchasePriceEUR, SalesPriceEUR, MarginEUR, NetRateEUR, DifferenceEUR,
			BookingStatus, MPImportDate, MissingCurrency, MissingDestination, MissingTo, MissingMargin, NegativeMargin,
			ExcessiveMargin, MismatchCalc, [Log]) VALUES
			(@Reference, @Hotelcode, @Hotelname, @HotelCountry, @GwgStatus, @PurchaseCurrency, @PurchasePrice, @SalesCurrency,
			@SalesPrice, @GWGHandlingFee, @Margin, @Difference, @CurrencyHotelTC, @NetRateHotelTC, @NetRateHandlingTC, @CheckHotel,
			@CompanyGroup, @Bookingdate, @Traveldate, @Roomtype, @Board, @Duration, @TransferTo, @TransferFrom, @Pax, @Adult, @Child,
			@ImportDate, @IncomingAgency, @BookingStateDesc, @HotelFlag, @MissingBookings, @MarginCheck, @DifferenceTOPrice,
			@LoginID, @PriceBreakdown, @LoginID, @Junk, @PurchasePriceEUR, @SalesPriceEUR, @MarginEUR, @NetRateEUR, @DifferenceEUR,
			@BookingStatus, @MPImportDate, @MissingCurrency, @MissingDestination, @MissingTO, @MissingMargin, @NegativeMargin,
			@ExcessiveMargin, @MismatchCalc, @Log);

			SET @Result = 0
		END
	ELSE
		BEGIN
			DECLARE @BookingID BIGINT = (SELECT TOP 1 BookingID FROM Booking WHERE Reference = @Reference AND HotelCode = @HotelCode);
			
			INSERT INTO Comment (BookingID, [Date], Comment, Calculation, [Status], LoginID) Values
				(@BookingID, GETDATE(), 'Booking Amendment!', NULL, '', 7);

			UPDATE Booking SET
			Hotelcode = @Hotelcode, Hotelname = @Hotelname,
			HotelCountry = @HotelCountry, GwgStatus = @GwgStatus, PurchaseCurrency = @PurchaseCurrency,
			PurchasePrice = @PurchasePrice, SalesCurrency = @SalesCurrency, SalesPrice = @SalesPrice, 
			GWGHandlingFee = @GWGHandlingFee, Margin = @Margin, Difference = @Difference, CurrencyHotelTC = @CurrencyHotelTC,
			NetRateHotelTC = @NetRateHotelTC, NetRateHandlingTC = @NetRateHandlingTC, CheckHotel = @CheckHotel,
			CompanyGroup = @CompanyGroup, Bookingdate = @Bookingdate, Traveldate = @Traveldate,
			Roomtype = @Roomtype, Board = @Board, Duration = @Duration, TransferTo = @TransferTo,
			TransferFrom = @TransferFrom, Pax = @Pax, 
			Adult = @Adult, Child = @Child, ImportDate = @ImportDate, IncomingAgency = @IncomingAgency, 
			BookingStateDesc = @BookingStateDesc, HotelFlag = @HotelFlag, MissingBookings = @MissingBookings,
			MarginCheck = @MarginCheck,	DifferenceTOPrice = @DifferenceTOPrice, ActionBy = dbo.ActionBy(BookingID),
			[Status] = dbo.LastStatus(BookingID), Comments = dbo.LastComment(BookingID), AdjustedPrice = dbo.AdjustedPrice(BookingID),
			PriceBreakdown = @PriceBreakdown,
			LoginID = @LoginID, Junk = @Junk, PurchasePriceEUR = @PurchasePriceEUR,
			SalesPriceEUR = @SalesPriceEUR, MarginEUR = @MarginEUR, NetRateEUR = @NetRateEUR,
			DifferenceEUR = @DifferenceEUR,
			BookingStatus = @BookingStatus, MPImportDate = @MPImportDate,
			MissingCurrency = @MissingCurrency, MissingDestination = @MissingDestination,
			MissingTo = @MissingTO, MissingMargin = @MissingMargin, ExcessiveMargin = @ExcessiveMargin,
			MismatchCalc = @MismatchCalc, [Log] = @Log

			WHERE BookingID = @BookingID;

			SET @Result = 1;
		END

RETURN @Result;




GO
USE [master]
GO
ALTER DATABASE [YT_DB] SET  READ_WRITE 
GO
