USE [master]
GO

/****** Object:  Database [NeuronEDI]    Script Date: 3/2/2017 9:00:29 PM ******/
CREATE DATABASE [NeuronEDI]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NeuronEDI', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\NeuronEDI.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'NeuronEDI_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\NeuronEDI_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [NeuronEDI] SET COMPATIBILITY_LEVEL = 110
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NeuronEDI].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [NeuronEDI] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [NeuronEDI] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [NeuronEDI] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [NeuronEDI] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [NeuronEDI] SET ARITHABORT OFF 
GO

ALTER DATABASE [NeuronEDI] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [NeuronEDI] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [NeuronEDI] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [NeuronEDI] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [NeuronEDI] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [NeuronEDI] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [NeuronEDI] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [NeuronEDI] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [NeuronEDI] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [NeuronEDI] SET  DISABLE_BROKER 
GO

ALTER DATABASE [NeuronEDI] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [NeuronEDI] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [NeuronEDI] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [NeuronEDI] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [NeuronEDI] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [NeuronEDI] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [NeuronEDI] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [NeuronEDI] SET RECOVERY FULL 
GO

ALTER DATABASE [NeuronEDI] SET  MULTI_USER 
GO

ALTER DATABASE [NeuronEDI] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [NeuronEDI] SET DB_CHAINING OFF 
GO

ALTER DATABASE [NeuronEDI] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [NeuronEDI] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [NeuronEDI] SET  READ_WRITE 
GO

USE [NeuronEDI]
GO

/****** Object:  Table [dbo].[Agreement]    Script Date: 3/2/2017 9:00:46 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Agreement](
	[PK_AgreementID] [uniqueidentifier] NOT NULL,
	[AgreementName] [nvarchar](100) NOT NULL,
	[TransactionType] [nvarchar](3) NOT NULL,
	[Direction] [nvarchar](10) NOT NULL,
	[Activated] [bit] NOT NULL,
	[ISA01AuthorizationInformationQualifier] [nchar](2) NOT NULL,
	[ISA02AuthorizationInformation] [nvarchar](10) NULL,
	[ISA03SecurityInformationQualifier] [nchar](2) NOT NULL,
	[ISA04SecurityInformation] [nvarchar](10) NULL,
	[ISA05SenderInterchangeIDQualifier] [nchar](2) NOT NULL,
	[ISA06SenderInterchangeID] [nvarchar](15) NOT NULL,
	[ISA07ReceiverInterchangeIDQualifier] [nchar](2) NOT NULL,
	[ISA08ReceiverInterchangeID] [nvarchar](15) NOT NULL,
	[ISA11InterchangeStandardsID] [nchar](1) NOT NULL,
	[ISA12InterchangeVersionID] [nchar](5) NOT NULL,
	[ISA14AckRequested] [nchar](1) NOT NULL,
	[ISA15TestIndicator] [nchar](1) NOT NULL,
	[SegmentSeparator] [nvarchar](6) NULL,
	[ElementSeparator] [nvarchar](6) NULL,
	[ISA16SubElementSeparator] [nvarchar](6) NOT NULL,
	[GS01FunctionalIDCode] [nchar](2) NOT NULL,
	[GS02ApplicationSenderID] [nvarchar](15) NOT NULL,
	[GS03ApplicationReceiverID] [nvarchar](15) NOT NULL,
	[GS07ResponsibleAgencyCode] [nchar](1) NOT NULL,
	[GS08VersionReleaseIndustryIDCode] [nvarchar](12) NOT NULL,
	[SegmentSeparatorSuffix] [nvarchar](12) NULL,
 CONSTRAINT [PK_Agreement_1] PRIMARY KEY CLUSTERED 
(
	[PK_AgreementID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [NeuronEDI]
GO

/****** Object:  Table [dbo].[Agreement_TradingPartner]    Script Date: 3/2/2017 9:00:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Agreement_TradingPartner](
	[FK_AgreementID] [uniqueidentifier] NOT NULL,
	[FK_SenderPartnerID] [uniqueidentifier] NOT NULL,
	[FK_ReceiverPartnerID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Agreement_TradingPartner] PRIMARY KEY CLUSTERED 
(
	[FK_AgreementID] ASC,
	[FK_SenderPartnerID] ASC,
	[FK_ReceiverPartnerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Agreement_TradingPartner]  WITH CHECK ADD  CONSTRAINT [FK_Agreement_TradingPartner_Agreement] FOREIGN KEY([FK_AgreementID])
REFERENCES [dbo].[Agreement] ([PK_AgreementID])
GO

ALTER TABLE [dbo].[Agreement_TradingPartner] CHECK CONSTRAINT [FK_Agreement_TradingPartner_Agreement]
GO

ALTER TABLE [dbo].[Agreement_TradingPartner]  WITH CHECK ADD  CONSTRAINT [FK_Agreement_TradingPartner_TradingPartner] FOREIGN KEY([FK_SenderPartnerID])
REFERENCES [dbo].[TradingPartner] ([PK_PartnerID])
GO

ALTER TABLE [dbo].[Agreement_TradingPartner] CHECK CONSTRAINT [FK_Agreement_TradingPartner_TradingPartner]
GO

ALTER TABLE [dbo].[Agreement_TradingPartner]  WITH CHECK ADD  CONSTRAINT [FK_Agreement_TradingPartner_TradingPartner1] FOREIGN KEY([FK_ReceiverPartnerID])
REFERENCES [dbo].[TradingPartner] ([PK_PartnerID])
GO

ALTER TABLE [dbo].[Agreement_TradingPartner] CHECK CONSTRAINT [FK_Agreement_TradingPartner_TradingPartner1]
GO

USE [NeuronEDI]
GO

/****** Object:  Table [dbo].[ControlNumber]    Script Date: 3/2/2017 9:01:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ControlNumber](
	[PK_AgreementID] [uniqueidentifier] NOT NULL,
	[ISA13InterchangeControlNumber] [int] NOT NULL,
	[GS06GroupControlNumber] [int] NOT NULL,
 CONSTRAINT [PK_ControlNumber] PRIMARY KEY CLUSTERED 
(
	[PK_AgreementID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[ControlNumber] ADD  CONSTRAINT [DF_ControlNumber_InterchangeControlNumber]  DEFAULT ((0)) FOR [ISA13InterchangeControlNumber]
GO

ALTER TABLE [dbo].[ControlNumber] ADD  CONSTRAINT [DF_ControlNumber_GroupControlNumber]  DEFAULT ((0)) FOR [GS06GroupControlNumber]
GO

ALTER TABLE [dbo].[ControlNumber]  WITH CHECK ADD  CONSTRAINT [FK_ControlNumber_Agreement] FOREIGN KEY([PK_AgreementID])
REFERENCES [dbo].[Agreement] ([PK_AgreementID])
GO

ALTER TABLE [dbo].[ControlNumber] CHECK CONSTRAINT [FK_ControlNumber_Agreement]
GO

USE [NeuronEDI]
GO

/****** Object:  Table [dbo].[FunctionalGroup]    Script Date: 3/2/2017 9:01:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FunctionalGroup](
	[PK_GroupID] [uniqueidentifier] NOT NULL,
	[GroupName] [nvarchar](100) NOT NULL,
	[FunctionalGroupID] [nvarchar](15) NOT NULL,
	[Activated] [bit] NOT NULL,
	[FK_PartnerID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_FunctionalGroup] PRIMARY KEY CLUSTERED 
(
	[PK_GroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[FunctionalGroup]  WITH CHECK ADD  CONSTRAINT [FK_FunctionalGroup_TradingPartner] FOREIGN KEY([FK_PartnerID])
REFERENCES [dbo].[TradingPartner] ([PK_PartnerID])
GO

ALTER TABLE [dbo].[FunctionalGroup] CHECK CONSTRAINT [FK_FunctionalGroup_TradingPartner]
GO

USE [NeuronEDI]
GO

/****** Object:  Table [dbo].[TradingPartner]    Script Date: 3/2/2017 9:01:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TradingPartner](
	[PK_PartnerID] [uniqueidentifier] NOT NULL,
	[PartnerName] [nvarchar](100) NOT NULL,
	[InterchangeIDQualifier] [nchar](2) NOT NULL,
	[InterchangeID] [nchar](15) NOT NULL,
	[Activated] [bit] NULL,
	[ExternalReferenceID] [nvarchar](50) NULL,
 CONSTRAINT [PK_TradingPartner] PRIMARY KEY CLUSTERED 
(
	[PK_PartnerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [NeuronEDI]
GO

/****** Object:  StoredProcedure [dbo].[sp_Agreement_Configure]    Script Date: 3/2/2017 9:01:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_Agreement_Configure]
(
	@agreement xml
)
AS 

	BEGIN
		IF (SELECT xmlAgreement.value('Action[1]', 'nvarchar(10)') FROM @agreement.nodes('//Agreement') xml1(xmlAgreement)) = 'Create'
		EXEC dbo.sp_Agreement_Create @agreement;

		IF (SELECT xmlAgreement.value('Action[1]', 'nvarchar(10)') FROM @agreement.nodes('//Agreement') xml1(xmlAgreement)) = 'Update'
		EXEC dbo.sp_Agreement_Update @agreement;
	END


GO

USE [NeuronEDI]
GO

/****** Object:  StoredProcedure [dbo].[sp_Agreement_Create]    Script Date: 3/2/2017 9:01:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_Agreement_Create]
(
	@agreement xml,
	@result nvarchar(max) output
)
AS 

BEGIN TRY
  DECLARE @count int;
  DECLARE @agreementid uniqueidentifier  
  DECLARE @agreementname nvarchar(100);  
  DECLARE @authinfoqual nchar(2);
  DECLARE @authinfo nvarchar(10);
  DECLARE @securityinfoqual nchar(2);
  DECLARE @securityinfo nvarchar(10);
  DECLARE @senderidqual nchar(2);
  DECLARE @senderid nvarchar(15);
  DECLARE @receiveridqual nchar(2);
  DECLARE @receiverid nvarchar(15);
  DECLARE @interchangestandardsid nchar(1);
  DECLARE @interchangeversionid nchar(5);
  DECLARE @interchangecontrolnumber int;
  DECLARE @ackrequested nchar(1);
  DECLARE @testindicator nchar(1);
  DECLARE @subelemsep nvarchar(6);
  DECLARE @functionalidcode nchar(2);
  DECLARE @appsenderid nvarchar(15);
  DECLARE @appreceiverid nvarchar(15);
  DECLARE @groupcontrolnum int;
  DECLARE @respagencycode nchar(1);
  DECLARE @industryidcode nvarchar(12);
  DECLARE @segmentsep nvarchar(6);
  DECLARE @elemsep nvarchar(6);
  DECLARE @segseparatorsuffix nvarchar(12);
  DECLARE @transtype nvarchar(5);
  DECLARE @direction nvarchar(10);
  DECLARE @activated bit;

  SET @agreementid						= NEWID();
  SET @agreementname					= (SELECT agreement1.header.value	('(AgreementName/text())[1]',						'nvarchar(100)')	FROM @agreement.nodes('//Agreement')	 agreement1(header));
  SET @authinfoqual						= (SELECT agreement1.header.value	('(AuthorizationInformationQualifier/text())[1]',	'nchar(2)')			FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
  SET @authinfo							= (SELECT agreement1.header.value	('(AuthorizationInformation/text())[1]',			'nvarchar(10)')		FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
  SET @securityinfoqual					= (SELECT agreement1.header.value	('(SecurityInformationQualifier/text())[1]',		'nchar(2)')			FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
  SET @securityinfo						= (SELECT agreement1.header.value	('(SecurityInformation/text())[1]',					'nvarchar(10)')		FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
  SET @senderidqual						= (SELECT agreement1.header.value	('(InterchangeIDQualifier/text())[1]',				'nchar(2)')			FROM @agreement.nodes('//Agreement/Partner[@Type="Sender"]')   agreement1(header)); 
  SET @senderid							= (SELECT agreement1.header.value	('(InterchangeID/text())[1]',						'nvarchar(15)')		FROM @agreement.nodes('//Agreement/Partner[@Type="Sender"]')   agreement1(header)); 
  SET @receiveridqual					= (SELECT agreement1.header.value	('(InterchangeIDQualifier/text())[1]',				'nchar(2)')			FROM @agreement.nodes('//Agreement/Partner[@Type="Receiver"]') agreement1(header)); 
  SET @receiverid						= (SELECT agreement1.header.value	('(InterchangeID/text())[1]',						'nvarchar(15)')		FROM @agreement.nodes('//Agreement/Partner[@Type="Receiver"]') agreement1(header)); 
  SET @interchangestandardsid			= (SELECT agreement1.header.value	('(InterchangeStandardsID/text())[1]',				'nchar(5)')			FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
  SET @interchangeversionid				= (SELECT agreement1.header.value	('(InterchangeVersionID/text())[1]',				'nchar(5)')			FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
  SET @interchangecontrolnumber			= (SELECT agreement1.header.value	('(InterchangeControlNumber/text())[1]',			'int')				FROM @agreement.nodes('//Agreement')	 agreement1(header));
  SET @ackrequested						= (SELECT agreement1.header.value	('(AckRequested/text())[1]',						'nchar(1)')			FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
  SET @testindicator					= (SELECT agreement1.header.value	('(TestIndicator/text())[1]',						'nchar(1)')			FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
  SET @subelemsep						= (SELECT agreement1.header.value	('(SubElementSeparator/text())[1]',					'nvarchar(6)')		FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
  SET @functionalidcode					= (SELECT agreement1.header.value	('(FunctionalIDCode/text())[1]',					'nchar(2)')			FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
  SET @appsenderid						= (SELECT agreement1.header.value	('(ApplicationSenderID/text())[1]',					'nvarchar(15)')		FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
  SET @appreceiverid					= (SELECT agreement1.header.value	('(ApplicationReceiverID/text())[1]',				'nvarchar(15)')		FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
  SET @groupcontrolnum					= (SELECT agreement1.header.value	('(GroupControlNumber/text())[1]',					'int')				FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
  SET @respagencycode					= (SELECT agreement1.header.value	('(ResponsibleAgencyCode/text())[1]',				'nchar(1)')			FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
  SET @industryidcode					= (SELECT agreement1.header.value	('(VersionReleaseIndustryIDCode/text())[1]',		'nvarchar(12)')		FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
  SET @segmentsep						= (SELECT agreement1.header.value	('(SegmentSeparator/text())[1]',					'nvarchar(6)')		FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
  SET @elemsep							= (SELECT agreement1.header.value	('(ElementSeparator/text())[1]',					'nvarchar(6)')		FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
  SET @segseparatorsuffix				= (SELECT agreement1.header.value	('(SegmentSeparatorSuffix/text())[1]',				'nvarchar(12)')		FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
  SET @transtype						= (SELECT agreement1.header.value	('(TransactionType/text())[1]',						'nvarchar(5)')		FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
  SET @direction						= (SELECT agreement1.header.value	('(Direction/text())[1]',							'nvarchar(10)')		FROM @agreement.nodes('//Agreement')	 agreement1(header));
  SET @activated						= (SELECT agreement1.header.value	('(Activated/text())[1]',							'bit')				FROM @agreement.nodes('//Agreement')	 agreement1(header));

--Check if there is an existing active Agreement
  SELECT @count = (SELECT COUNT(*) 
                              FROM 
							    dbo.Agreement tblAgreement
							  WHERE 
							    tblAgreement.TransactionType				=  @transtype				AND
							    tblAgreement.Direction						=  @direction				AND
								tblAgreement.ISA06SenderInterchangeID		=  @senderid				AND
								tblAgreement.ISA08ReceiverInterchangeID		=  @receiverid				AND
								tblAgreement.ISA12InterchangeVersionID		=  @interchangeversionid	AND
								tblAgreement.GS02ApplicationSenderID		=  @appsenderid				AND
								tblAgreement.GS03ApplicationReceiverID		=  @appreceiverid)

  IF (@count > 0)
	BEGIN
		DECLARE @error nvarchar(200);
		SET @error = 'ERROR:  Agreement already exists';
		THROW 60000, @error, 1
	END

--Check if Sender Partner exists
  SELECT @count = (SELECT COUNT(*)
                              FROM
							    dbo.TradingPartner tblPartner
							  WHERE
							    tblPartner.InterchangeIDQualifier	= @senderidqual	AND
								tblPartner.InterchangeID			= @senderid)

IF (@count = 0)
	BEGIN
	  SET @error = 'ERROR:  No matching Partner entry for Sender: ' + @senderid;
	  THROW 60000, @error, 1
	END

IF (@count > 1)
	BEGIN
		SET @error = 'ERROR:  Multiple matching Partner entries found for this Sender: ' + @senderid;
		THROW 60000, @error, 1
	END

--Check if Receiver Partner exists
 SELECT @count = (SELECT COUNT(*)
                              FROM
							    dbo.TradingPartner tblPartner
							  WHERE
							    tblPartner.InterchangeIDQualifier	= @receiveridqual	AND
								tblPartner.InterchangeID			= @receiverid)

IF (@count = 0)
	BEGIN
		SET @error = 'ERROR:  No matching Partner entry for Receiver: ' + @receiverid;
		THROW 60000, @error, 1
	END

IF (@count > 1)
	BEGIN
		SET @error = 'ERROR:  Multiple matching Partner entries found for this Receiver: ' + @receiverid;
		THROW 60000, @error, 1
	END

--Check if Sender Group exists
SELECT @count = (SELECT COUNT(*)
                              FROM
							    dbo.FunctionalGroup tblGroup						
							  WHERE
								tblGroup.FunctionalGroupID	= @appsenderid)

IF (@count = 0)
	BEGIN
		SET @error = 'ERROR:  No matching Group entry for Sender FunctionalGroupID: : ' + @appsenderid;
		THROW 60000, @error, 1
	END

IF (@count > 1)
	BEGIN
		SET @error = 'ERROR:  Multiple matching Group entries for this Sender FunctionalGroupID: ' + @appsenderid;
		THROW 60000, @error, 1
	END

--Check if Receiver Group exists
SELECT @count = (SELECT COUNT(*)
                              FROM
							    dbo.FunctionalGroup tblGroup
							  WHERE
								tblGroup.FunctionalGroupID	= @appreceiverid)

IF (@count = 0)
	BEGIN
		SET @error = 'ERROR:  No matching Group entry for this Receiver FunctionalGroupID: ' + @appreceiverid;
		THROW 60000, @error, 1
	END

IF (@count > 1)
	BEGIN
		SET @error = 'ERROR:  Multiple matching Group entries for this Receiver FunctionalGroupID: ' + @appreceiverid;
		THROW 60000, @error, 1
	END

END TRY

BEGIN CATCH
  THROW
END CATCH

--Insert Control Numbers, Agreement, and Agreement_TradingPartner junction table
BEGIN TRY

		--Insert Agreement
		INSERT INTO dbo.Agreement(
		  PK_AgreementID,
		  AgreementName, 
		  TransactionType, 
		  Direction,
		  Activated,
		  ISA01AuthorizationInformationQualifier,
		  ISA02AuthorizationInformation,
		  ISA03SecurityInformationQualifier,
		  ISA04SecurityInformation,
		  ISA05SenderInterchangeIDQualifier,
		  ISA06SenderInterchangeID,
		  ISA07ReceiverInterchangeIDQualifier,
		  ISA08ReceiverInterchangeID,
		  ISA11InterchangeStandardsID,
		  ISA12InterchangeVersionID,
		  ISA14AckRequested,
		  ISA15TestIndicator,
		  SegmentSeparator,
		  ElementSeparator,
		  ISA16SubElementSeparator,
		  GS01FunctionalIDCode,
		  GS02ApplicationSenderID,
		  GS03ApplicationReceiverID,
		  GS07ResponsibleAgencyCode,
		  GS08VersionReleaseIndustryIDCode,
		  SegmentSeparatorSuffix)

		   SELECT
			  @agreementid					AS AgreementID,
			  @agreementname 				AS AgreementName,
			  @transtype					AS TransactionType,
			  @direction					AS Direction,
			  @activated					AS Activated,
			  @authinfoqual					AS ISA01AuthorizationInformationQualifier,
			  @authinfo						AS ISA02AuthorizationInformation,
			  @securityinfoqual				AS ISA03SecurityInformationQualifier,
			  @securityinfo					AS ISA04SecurityInformation,
			  @senderidqual					AS ISA05SenderInterchangeIDQualifier,
			  @senderid						AS ISA06SenderInterchangeID,
			  @receiveridqual				AS ISA07ReceiverInterchangeIDQualifier,
			  @receiverid					AS ISA08ReceiverInterchangeID,
			  @interchangestandardsid		AS ISA11InterchangeStandardsID,
			  @interchangeversionid			AS ISA12InterchangeVersionID,
			  @ackrequested					AS ISA14AckRequested,
			  @testindicator				AS ISA15TestIndicator,
			  @segmentsep					AS SegmentSeparator,
			  @elemsep						AS ElementSeparator,
			  @subelemsep					AS ISA16SubElementSeparator,
			  @functionalidcode				AS GS01FunctionalIDCode,
			  @appsenderid					AS GS02ApplicationSenderID,
			  @appreceiverid				AS GS03ApplicationReceiverID,
			  @respagencycode				AS GS07ResponsibleAgencyCode,
			  @industryidcode				AS GS08VersionReleaseIndustryIDCode,
			  @segseparatorsuffix			AS SegmentSeparatorSuffix

		--Control Numbers
		IF (ISNUMERIC(@interchangecontrolnumber) <> 1)
		BEGIN
		  SET @interchangecontrolnumber = 0
		END

		IF (ISNUMERIC(@groupcontrolnum) <> 1)
		BEGIN
		  SET @groupcontrolnum = 0
		END

		INSERT INTO dbo.ControlNumber(
		  PK_AgreementID,
		  ISA13InterchangeControlNumber,
		  GS06GroupControlNumber)

		 SELECT
		    @agreementid				AS PK_AgreementID,
			@interchangecontrolnumber	AS ISA13InterchangeControlNumber,
			@groupcontrolnum			AS GS06GroupControlNumber

		--Agreement_TradingPartner junction table
		INSERT INTO dbo.Agreement_TradingPartner(
			FK_AgreementID,
			FK_SenderPartnerID, 
			FK_ReceiverPartnerID)

		SELECT
	      tblAgreement.PK_AgreementID		AS FK_AgreementID,
		  tblSender.PK_PartnerID			AS FK_SenderPartnerID,
		  tblReceiver.PK_PartnerID			AS FK_ReceiverPartnerID

		FROM
		  @agreement.nodes('//Agreement/Partner[@Type="Sender"]')		agreement1(sender), 
		  @agreement.nodes('//Agreement/Partner[@Type="Receiver"]')		agreement2(receiver), 
		  dbo.TradingPartner tblSender, 
		  dbo.TradingPartner tblReceiver, 
		  dbo.Agreement tblAgreement

		WHERE
		  tblSender.InterchangeID		= agreement1.sender.value	('InterchangeID[1]',		'nvarchar(15)')	AND
		  tblReceiver.InterchangeID		= agreement2.receiver.value	('InterchangeID[1]',		'nvarchar(15)')	AND
		  tblAgreement.PK_AgreementID	= @agreementid

		SELECT @result = 'Success';
END TRY

BEGIN CATCH  
  SELECT @result = 'Error';
  THROW
END CATCH
GO

USE [NeuronEDI]
GO

/****** Object:  StoredProcedure [dbo].[sp_Agreement_Get]    Script Date: 3/2/2017 9:01:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_Agreement_Get]
(
	@senderinterchangeid		nvarchar(15),
	@receiverinterchangeid		nvarchar(15),
	@interchangeversion			nvarchar(5),
	@transactiontype			nvarchar(3),
	@direction					nvarchar(10),
	@applicationsenderid		nvarchar(15),
	@applicationreceiverid		nvarchar(15),
	@applicationversion			nvarchar(12))
AS 

BEGIN TRY

  --Get agreement id
  DECLARE @agreementid uniqueidentifier;
  SET @agreementid = (SELECT PK_AgreementID 
                      FROM dbo.Agreement 
					  WHERE ISA06SenderInterchangeID			= @senderinterchangeid		AND
							ISA08ReceiverInterchangeID			= @receiverinterchangeid	AND
							TransactionType						= @transactiontype			AND
							Direction							= @direction				AND
							ISA12InterchangeVersionID			= @interchangeversion		AND
							GS02ApplicationSenderID				= @applicationsenderid		AND
							GS03ApplicationReceiverID			= @applicationreceiverid	AND
							GS08VersionReleaseIndustryIDCode	= @applicationversion)

	IF(COUNT(@agreementid) != 1)
		BEGIN
			DECLARE @error nvarchar(800);
			SET @error = 'ERROR:  No Active Agreement was found with the following parameters:'		+ CHAR(13) + 
			                    'ISA06SenderInterchangeID: '			+ @senderinterchangeid		+ CHAR(13) + 
								'ISA08ReceiverInterchangeID: '			+ @receiverinterchangeid	+ CHAR(13) + 
								'ISA12InterchangeVersionID: '			+ @interchangeversion		+ CHAR(13) + 
								'TransactionType: '						+ @transactiontype			+ CHAR(13) + 
								'Direction: '							+ @direction				+ CHAR(13) + 
								'GS02ApplicationSenderID: '				+ @applicationsenderid		+ CHAR(13) + 
								'GS03ApplicationReceiverID: '			+ @applicationreceiverid	+ CHAR(13) + 
								'GS08VersionReleaseIndustryCode: '		+ @applicationversion;
			THROW 60000, @error, 1
		END
	ELSE
	  --Update control numbers
	  IF(@direction = 'Outbound')
		BEGIN
			DECLARE @interchangecontrolnumber int
			SET @interchangecontrolnumber = (SELECT ISA13InterchangeControlNumber
													 FROM dbo.ControlNumber
													 WHERE PK_AgreementID = @agreementid)

			DECLARE @groupcontrolnumber int
			SET @groupcontrolnumber = (SELECT GS06GroupControlNumber
										FROM dbo.ControlNumber
										WHERE PK_AgreementID = @agreementid)

			--Reset interchange control number, if necessary
			IF(@interchangecontrolnumber = '999999999')
			BEGIN
				SET @interchangecontrolnumber = '000000000'
			END

			--Reset group control number, if necessary
			IF(@groupcontrolnumber = '999999999')
			BEGIN
				SET @groupcontrolnumber = '000000000'
			END

			UPDATE dbo.ControlNumber
			SET ISA13InterchangeControlNumber = (@interchangecontrolnumber + 1),
					   GS06GroupControlNumber = (@groupcontrolnumber + 1)
			WHERE PK_AgreementID = @agreementid
		END

	  --Return agreement info
	  SELECT *
	  FROM dbo.Agreement agreement, dbo.ControlNumber ctlnum
	  WHERE		  agreement.ISA06SenderInterchangeID			= @senderinterchangeid		AND
				  agreement.ISA08ReceiverInterchangeID			= @receiverinterchangeid	AND
				  agreement.TransactionType						= @transactiontype			AND
				  agreement.Direction							= @direction				AND
				  agreement.ISA12InterchangeVersionID			= @interchangeversion		AND
				  agreement.GS02ApplicationSenderID				= @applicationsenderid		AND
				  agreement.GS03ApplicationReceiverID			= @applicationreceiverid	AND
				  agreement.GS08VersionReleaseIndustryIDCode	= @applicationversion		AND
				  agreement.PK_AgreementID = ctlnum.PK_AgreementID  

END TRY

BEGIN CATCH  
  THROW
END CATCH
GO

USE [NeuronEDI]
GO

/****** Object:  StoredProcedure [dbo].[sp_Agreement_Update]    Script Date: 3/2/2017 9:02:06 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_Agreement_Update]
(
	@agreement xml,
	@result nvarchar(max) output
)
AS 

BEGIN TRY
	DECLARE @agreementid			uniqueidentifier;
	DECLARE @agreementname			nvarchar(100);  
	DECLARE @authinfoqual			nchar(2);
	DECLARE @authinfo				nvarchar(10);
	DECLARE @securityinfoqual		nchar(2);
	DECLARE @securityinfo			nvarchar(10);
	DECLARE @senderidqual			nchar(2);
	DECLARE @senderid				nvarchar(15);
	DECLARE @receiveridqual			nchar(2);
	DECLARE @receiverid				nvarchar(15);
	DECLARE @interchangestandardsid nchar(1);
	DECLARE @interchangeversionid	nchar(5);
	DECLARE @ackrequested			nchar(1);
	DECLARE @testindicator			nchar(1);
	DECLARE @subelemsep				nvarchar(6);
	DECLARE @functionalidcode		nchar(2);
	DECLARE @appsenderid			nvarchar(15);
	DECLARE @appreceiverid			nvarchar(15);
	DECLARE @groupcontrolnum		int;
	DECLARE @respagencycode			nchar(1);
	DECLARE @industryidcode			nvarchar(12);
	DECLARE @segmentsep				nvarchar(6);
	DECLARE @elemsep				nvarchar(6);
	DECLARE @segseparatorsuffix		nvarchar(12);
	DECLARE @transtype				nvarchar(5);
	DECLARE @direction				nvarchar(10);
	DECLARE @activated				bit;

	DECLARE @partnerid			uniqueidentifier;
	DECLARE @senderisvalid		bit;
	DECLARE @receiverisvalid	bit;
	DECLARE @senderisactive		bit;
	DECLARE @receiverisactive	bit;
	
	DECLARE @groupid				uniqueidentifier;
	DECLARE @sendergroupisvalid		bit;
	DECLARE @receivergroupisvalid	bit;
	DECLARE @sendergroupisactive	bit;
	DECLARE @receivergroupisactive	bit;

	DECLARE @count int;

	DECLARE @errormsg nvarchar(1000);

	SET @agreementid				= (SELECT agreement1.header.value	('(AgreementID/text())[1]',							'uniqueidentifier')	FROM @agreement.nodes('//Agreement')	 agreement1(header));
	SET @agreementname				= (SELECT agreement1.header.value	('(AgreementName/text())[1]',						'nvarchar(100)')	FROM @agreement.nodes('//Agreement')	 agreement1(header));
	SET @authinfoqual				= (SELECT agreement1.header.value	('(AuthorizationInformationQualifier/text())[1]',	'nchar(2)')			FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
	SET @authinfo					= (SELECT agreement1.header.value	('(AuthorizationInformation/text())[1]',			'nvarchar(10)')		FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
	SET @securityinfoqual			= (SELECT agreement1.header.value	('(SecurityInformationQualifier/text())[1]',		'nchar(2)')			FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
	SET @securityinfo				= (SELECT agreement1.header.value	('(SecurityInformation/text())[1]',					'nvarchar(10)')		FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
	SET @senderidqual				= (SELECT agreement1.header.value	('(InterchangeIDQualifier/text())[1]',				'nchar(2)')			FROM @agreement.nodes('//Agreement/Partner[@Type="Sender"]')   agreement1(header)); 
	SET @senderid					= (SELECT agreement1.header.value	('(InterchangeID/text())[1]',						'nvarchar(15)')		FROM @agreement.nodes('//Agreement/Partner[@Type="Sender"]')   agreement1(header)); 
	SET @receiveridqual				= (SELECT agreement1.header.value	('(InterchangeIDQualifier/text())[1]',				'nchar(2)')			FROM @agreement.nodes('//Agreement/Partner[@Type="Receiver"]') agreement1(header)); 
	SET @receiverid					= (SELECT agreement1.header.value	('(InterchangeID/text())[1]',						'nvarchar(15)')		FROM @agreement.nodes('//Agreement/Partner[@Type="Receiver"]') agreement1(header)); 
	SET @interchangestandardsid		= (SELECT agreement1.header.value	('(InterchangeStandardsID/text())[1]',				'nchar(5)')			FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
	SET @interchangeversionid		= (SELECT agreement1.header.value	('(InterchangeVersionID/text())[1]',				'nchar(5)')			FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
	SET @ackrequested				= (SELECT agreement1.header.value	('(AckRequested/text())[1]',						'nchar(1)')			FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
	SET @testindicator				= (SELECT agreement1.header.value	('(TestIndicator/text())[1]',						'nchar(1)')			FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
	SET @subelemsep					= (SELECT agreement1.header.value	('(SubElementSeparator/text())[1]',					'nvarchar(6)')		FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
	SET @functionalidcode			= (SELECT agreement1.header.value	('(FunctionalIDCode/text())[1]',					'nchar(2)')			FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
	SET @appsenderid				= (SELECT agreement1.header.value	('(ApplicationSenderID/text())[1]',					'nvarchar(15)')		FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
	SET @appreceiverid				= (SELECT agreement1.header.value	('(ApplicationReceiverID/text())[1]',				'nvarchar(15)')		FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
	SET @respagencycode				= (SELECT agreement1.header.value	('(ResponsibleAgencyCode/text())[1]',				'nchar(1)')			FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
	SET @industryidcode				= (SELECT agreement1.header.value	('(VersionReleaseIndustryIDCode/text())[1]',		'nvarchar(12)')		FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
	SET @segmentsep					= (SELECT agreement1.header.value	('(SegmentSeparator/text())[1]',					'nvarchar(6)')		FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
	SET @elemsep					= (SELECT agreement1.header.value	('(ElementSeparator/text())[1]',					'nvarchar(6)')		FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
	SET @segseparatorsuffix			= (SELECT agreement1.header.value	('(SegmentSeparatorSuffix/text())[1]',				'nvarchar(12)')		FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
	SET @transtype					= (SELECT agreement1.header.value	('(TransactionType/text())[1]',						'nvarchar(5)')		FROM @agreement.nodes('//Agreement')	 agreement1(header)); 
	SET @direction					= (SELECT agreement1.header.value	('(Direction/text())[1]',							'nvarchar(10)')		FROM @agreement.nodes('//Agreement')	 agreement1(header));
	SET @activated					= (SELECT agreement1.header.value	('(Activated/text())[1]',							'bit')				FROM @agreement.nodes('//Agreement')	 agreement1(header));

	--Validate partners
	--Sender
	SET @partnerid			= (SELECT PK_PartnerID 
	                           FROM dbo.TradingPartner 
							   WHERE InterchangeIDQualifier = @senderidqual AND 
							                  InterchangeID = @senderid);

	SET @senderisvalid	= dbo.ufn_Partner_IsValid(@partnerid);

	IF(@senderisvalid != 1)
		BEGIN
			SET @errormsg = 'Sender  [' + CAST(@partnerid AS nvarchar(100)) + '] ''' + @senderid + ''' is not valid';
			THROW 60000, @errormsg, 1
		END

	--Receiver
	SET @partnerid			= (SELECT PK_PartnerID 
	                           FROM dbo.TradingPartner 
							   WHERE InterchangeIDQualifier = @receiveridqual AND 
							                  InterchangeID = @receiverid);

	SET @receiverisvalid	= dbo.ufn_Partner_IsValid(@partnerid);	

	IF(@receiverisvalid != 1)
		BEGIN
			SET @errormsg = 'Receiver [' + CAST(@partnerid AS nvarchar(100)) + '] ''' + @receiverid + ''' is not valid';
			THROW 60000, @errormsg, 1
		END

	--Check if partners are active
	--Sender
	SET @partnerid			= (SELECT PK_PartnerID 
	                           FROM dbo.TradingPartner 
							   WHERE InterchangeIDQualifier = @senderidqual AND 
							                  InterchangeID = @senderid);

	SET @senderisactive	= dbo.ufn_Partner_IsActive(@partnerid);

	--Receiver
	SET @partnerid			= (SELECT PK_PartnerID 
	                           FROM dbo.TradingPartner 
							   WHERE InterchangeIDQualifier = @receiveridqual AND 
							                  InterchangeID = @receiverid);

	SET @receiverisactive = dbo.ufn_Partner_IsActive(@partnerid);

	--Validate groups
	--Sender
	SET @groupid					= (SELECT PK_GroupID 
	                                   FROM dbo.FunctionalGroup 
									   WHERE FunctionalGroupID = @appsenderid);

	SET @sendergroupisvalid	= dbo.ufn_Group_IsValid(@groupid);

	IF(@sendergroupisvalid != 1)
		BEGIN
			SET @errormsg = 'Sender group ''' + @appsenderid + ''' is not valid';
			THROW 60000, @errormsg, 1
		END

	--Receiver
	SET @groupid					= (SELECT PK_GroupID 
	                                   FROM dbo.FunctionalGroup 
									   WHERE FunctionalGroupID = @appreceiverid);

	SET @receivergroupisvalid	= dbo.ufn_Group_IsValid(@groupid);	

	IF(@receivergroupisvalid != 1)
		BEGIN
			SET @errormsg = 'Receiver group ''' + @appreceiverid + ''' is not valid';
			THROW 60000, @errormsg, 1
		END

	--Check if groups are active
	--Sender
	SET @groupid						= (SELECT PK_GroupID 
	                                       FROM dbo.FunctionalGroup 
										   WHERE FunctionalGroupID = @appsenderid);

	SET @sendergroupisactive		= dbo.ufn_Group_IsActive(@groupid);

	--Receiver
	SET @groupid						= (SELECT PK_GroupID 
	                                       FROM dbo.FunctionalGroup 
										   WHERE FunctionalGroupID = @appreceiverid);

	SET @receivergroupisactive	= dbo.ufn_Group_IsActive(@groupid);
	
	--If activating the agreement, make sure the sender and receiver and their functional groups are activated
	IF(@activated = 1)
	BEGIN
		IF(@senderisactive != 1)
		BEGIN
			SET @errormsg = 'Sender [' + CAST(@partnerid AS nvarchar(100)) + '] ''' + @senderid + ''' is not active.  Cannot activate agreement ''' + @agreementname + '''';
			THROW 60000, @errormsg, 1
		END
		ELSE IF(@receiverisactive != 1)
		BEGIN
			SET @errormsg = 'Receiver [' + CAST(@partnerid AS nvarchar(100)) + '] ''' + @receiverid + ''' is not active.  Cannot activate agreement ''' + @agreementname + '''';
			THROW 60000, @errormsg, 1
		END
		ELSE IF(@sendergroupisactive != 1)
		BEGIN
			SET @errormsg = 'Sender Group [' + CAST(@groupid AS nvarchar(100)) + '] ''' + @appsenderid + ''' is not active.  Cannot activate agreement ''' + @agreementname + '''';
			THROW 60000, @errormsg, 1
		END
		ELSE IF(@receivergroupisactive != 1)
		BEGIN
			SET @errormsg = 'Receiver Group [' + CAST(@groupid AS nvarchar(100)) + '] ''' + @appreceiverid + ''' is not active.  Cannot activate agreement ''' + @agreementname + '''';
			THROW 60000, @errormsg, 1
		END
	END
	
	--Check if agreement exists
	SET @count = (SELECT COUNT(*) FROM dbo.Agreement WHERE PK_AgreementID = @agreementid)
	IF(@count = 0)
	BEGIN
		SET @errormsg = 'Agreement [' + CAST(@agreementid AS nvarchar(100)) + '] ''' + @agreementname + ''' is not valid';
		THROW 60000, @errormsg, 1
	END
	
	--Update Agreement
	UPDATE dbo.Agreement
	SET
	  AgreementName								= @agreementname,
	  TransactionType							= @transtype, 
	  Direction									= @direction,
	  Activated									= @activated,
	  ISA01AuthorizationInformationQualifier	= @authinfoqual,
	  ISA02AuthorizationInformation				= @authinfo,
	  ISA03SecurityInformationQualifier			= @securityinfoqual,
	  ISA04SecurityInformation					= @securityinfo,
	  ISA11InterchangeStandardsID				= @interchangestandardsid,
	  ISA12InterchangeVersionID					= @interchangeversionid,
	  ISA14AckRequested							= @ackrequested,
	  ISA15TestIndicator						= @testindicator,
	  SegmentSeparator							= @segmentsep,
	  ElementSeparator							= @elemsep,
	  ISA16SubElementSeparator					= @subelemsep,
	  GS01FunctionalIDCode						= @functionalidcode,
	  GS07ResponsibleAgencyCode					= @respagencycode,
	  GS08VersionReleaseIndustryIDCode			= @industryidcode,
	  SegmentSeparatorSuffix					= @segseparatorsuffix

	   FROM @agreement.nodes('//Agreement') agreement2(header)
	   WHERE PK_AgreementID = agreement2.header.value('AgreementID[1]', 'uniqueidentifier')

	--Update Control Numbers
	UPDATE dbo.ControlNumber
	SET
	  ISA13InterchangeControlNumber	= agreement.header.value('(InterchangeControlNumber/text())[1]',	'int'),
	  GS06GroupControlNumber		= agreement.header.value('(GroupControlNumber/text())[1]',			'int')
	FROM
	  @agreement.nodes('//Agreement') agreement(header)
	WHERE
	  PK_AgreementID = agreement.header.value('AgreementID[1]',	'uniqueidentifier')

	SELECT @result = 'Success';
END TRY

BEGIN CATCH
	SELECT @result = 'Error';
	THROW
END CATCH
GO

USE [NeuronEDI]
GO

/****** Object:  StoredProcedure [dbo].[sp_Agreement_Validate]    Script Date: 3/2/2017 9:02:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_Agreement_Validate]
(
	@senderinterchangeid		nvarchar(15),
	@receiverinterchangeid		nvarchar(15),
	@interchangeversion			nchar(5),
	@interchangecontrolnumber	int,
	@transactiontype			nvarchar(3),	
	@direction					nvarchar(10),	
	@applicationsenderid		nvarchar(15),
	@applicationreceiverid		nvarchar(15),
	@groupcontrolnumber			int,
	@applicationversion			nvarchar(12))
AS 

	BEGIN TRY
		DECLARE @agreementid uniqueidentifier;
		SET @agreementid = (SELECT PK_AgreementID FROM  dbo.Agreement
		                      WHERE 
								ISA06SenderInterchangeID			= @senderinterchangeid		AND
								ISA08ReceiverInterchangeID			= @receiverinterchangeid	AND
								ISA12InterchangeVersionID			= @interchangeversion		AND
								TransactionType						= @transactiontype			AND								
								Direction							= @direction				AND
								GS02ApplicationSenderID				= @applicationsenderid		AND
								GS03ApplicationReceiverID			= @applicationreceiverid	AND
								GS08VersionReleaseIndustryIDCode	= @applicationversion		AND
								Activated							= '1')

		IF(COUNT(@agreementid) != 1)
		BEGIN
			DECLARE @error nvarchar(800);
			SET @error = 'ERROR:  No Active Agreement was found with the following parameters:'		+ CHAR(13) + 
			                    'ISA06SenderInterchangeID: '			+ @senderinterchangeid		+ CHAR(13) + 
								'ISA08ReceiverInterchangeID: '			+ @receiverinterchangeid	+ CHAR(13) + 
								'ISA12InterchangeVersionID: '			+ @interchangeversion		+ CHAR(13) + 
								'TransactionType: '						+ @transactiontype			+ CHAR(13) + 
								'Direction: '							+ @direction				+ CHAR(13) + 
								'GS02ApplicationSenderID: '				+ @applicationsenderid		+ CHAR(13) + 
								'GS03ApplicationReceiverID: '			+ @applicationreceiverid	+ CHAR(13) + 
								'GS08VersionReleaseIndustryCode: '		+ @applicationversion;
			THROW 60000, @error, 1
		END
		ELSE
		BEGIN
			--Update Control Numbers
			--Inbound
			IF(@direction = 'Inbound')
			BEGIN
				DECLARE @intcontrolnum int;
				SET     @intcontrolnum = (SELECT ISA13InterchangeControlNumber
										  FROM dbo.Agreement agreement, dbo.ControlNumber ctlnum
										  WHERE	agreement.PK_AgreementID	= @agreementid AND
											    ctlnum.PK_AgreementID		= @agreementid)

				DECLARE @grpcontrolnum int;
				SET     @grpcontrolnum = (SELECT GS06GroupControlNumber
										  FROM dbo.Agreement agreement, dbo.ControlNumber ctlnum
										  WHERE	agreement.PK_AgreementID	= @agreementid AND
											    ctlnum.PK_AgreementID		= @agreementid)

				UPDATE dbo.ControlNumber
				SET 
					ISA13InterchangeControlNumber	= @interchangecontrolnumber,
				    GS06GroupControlNumber			= @groupcontrolnumber
				FROM
					dbo.Agreement		agreement,
					dbo.ControlNumber	ctlnum
				WHERE 
					agreement.PK_AgreementID	= @agreementid AND
					ctlnum.PK_AgreementID		= @agreementid

				--Return response
				SELECT 'Valid' AS 'Status',
						@intcontrolnum AS 'ISA13InterchangeControlNumber',
						@grpcontrolnum AS 'GS06GroupControlNumber'

			END
		END
	END TRY

	BEGIN CATCH
		THROW
	END CATCH
GO

USE [NeuronEDI]
GO

/****** Object:  StoredProcedure [dbo].[sp_FunctionalGroup_Create]    Script Date: 3/2/2017 9:02:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_FunctionalGroup_Create]
(
	@group xml,
	@partnerid uniqueidentifier
)
AS 

--Check if Group already exists.  If so, throw error.
BEGIN TRY
  DECLARE @count int;
  SELECT @count = (SELECT COUNT(*) 
                   FROM dbo.FunctionalGroup 
				   WHERE FunctionalGroupID IN (SELECT fGroup.FunctionalGroup.value('(FunctionalGroupID/text())[1]',	'nvarchar(15)') FROM @group.nodes('//FunctionalGroups/FunctionalGroup') fGroup(FunctionalGroup)))

  IF (@count > 0)
	BEGIN
		DECLARE @error nvarchar(200);
		SET @error = 'ERROR:  Functional Group already exists';
		THROW 60000, @error, 1
	END
END TRY

BEGIN CATCH
	THROW
END CATCH

--Insert Group
BEGIN TRY

	INSERT INTO dbo.FunctionalGroup(
		PK_GroupID,
		GroupName,
		FunctionalGroupID,
		Activated,
		FK_PartnerID)

		SELECT
		NEWID()																					AS PK_GroupID,
		partner.FunctionalGroup.value('(GroupName/text())[1]',				'nvarchar(100)')	AS GroupName,
		partner.FunctionalGroup.value('(FunctionalGroupID/text())[1]',		'nvarchar(15)')		AS FunctionalGroupID,
		partner.FunctionalGroup.value('(Activated/text())[1]',				'bit')				AS Activated,
		@partnerid																				AS FK_PartnerID

	FROM 
		@group.nodes('//FunctionalGroups/FunctionalGroup') partner(FunctionalGroup)
		
END TRY

BEGIN CATCH  
  THROW
END CATCH
GO

USE [NeuronEDI]
GO

/****** Object:  StoredProcedure [dbo].[sp_FunctionalGroup_Update]    Script Date: 3/2/2017 9:02:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_FunctionalGroup_Update]
(
	@group xml
)
AS 

DECLARE @groupid uniqueidentifier;
SET     @groupid = (SELECT partner.FunctionalGroup.value('(GroupID/text())[1]',		'uniqueidentifier') FROM @group.nodes('//FunctionalGroups/FunctionalGroup') partner(FunctionalGroup));

--Update Group
BEGIN TRY

	UPDATE dbo.FunctionalGroup
	SET
		GroupName			= partner.FunctionalGroup.value('(GroupName/text())[1]',			'nvarchar(100)'),
		FunctionalGroupID	= partner.FunctionalGroup.value('(FunctionalGroupID/text())[1]',	'nvarchar(15)'),
		Activated			= partner.FunctionalGroup.value('(Activated/text())[1]',			'bit')
	FROM 
		@group.nodes('//FunctionalGroups/FunctionalGroup') partner(FunctionalGroup),
		dbo.FunctionalGroup tblFunctionalGroup
	WHERE
	    PK_GroupID	= @groupid
		
END TRY

BEGIN CATCH  
  THROW
END CATCH
GO

USE [NeuronEDI]
GO

/****** Object:  StoredProcedure [dbo].[sp_TradingPartner_Configure]    Script Date: 3/2/2017 9:02:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_TradingPartner_Configure]
(
	@partner xml
)
AS 

	BEGIN
		IF (SELECT xmlPartner.value('Action[1]', 'nvarchar(10)') FROM @partner.nodes('//Partner') xml1(xmlPartner)) = 'Create'
		EXEC dbo.sp_TradingPartner_Create @partner;

		IF (SELECT xmlPartner.value('Action[1]', 'nvarchar(10)') FROM @partner.nodes('//Partner') xml1(xmlPartner)) = 'Update'
		EXEC dbo.sp_TradingPartner_Update @partner;
	END


GO

USE [NeuronEDI]
GO

/****** Object:  StoredProcedure [dbo].[sp_TradingPartner_Create]    Script Date: 3/2/2017 9:02:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_TradingPartner_Create]
(
	@partner xml,
	@tpid uniqueidentifier output
)
AS 

--Check if InterchangeID already exists.  If so, throw error.
BEGIN TRY
  DECLARE @count int;
  DECLARE @interchangeidqual nchar(2);
  DECLARE @interchangeid nvarchar(15);

  SELECT @interchangeidqual		=	(SELECT  partner.header.value('(InterchangeIDQualifier/text())[1]',	'nchar(2)')			FROM @partner.nodes('//Partner') partner(header))
  SELECT @interchangeid			=	(SELECT  partner.header.value('(InterchangeID/text())[1]',			'nvarchar(15)')		FROM @partner.nodes('//Partner') partner(header))

  SELECT @count = (SELECT COUNT(*) 
                   FROM dbo.TradingPartner 
				   WHERE InterchangeID			= @interchangeid AND 
				         InterchangeIDQualifier	= @interchangeidqual)

  IF (@count > 0)
	BEGIN
		DECLARE @error nvarchar(200);
		SET @error = 'ERROR:  Partner already exists for InterchangeIDQualifier ' + @interchangeidqual + ', InterchangeID ' + @interchangeid;
		THROW 60000, @error, 1
	END
END TRY

BEGIN CATCH
	THROW
END CATCH

--Insert Partner and Group
BEGIN TRY
    DECLARE @partnerid uniqueidentifier  
	SET @partnerid = NEWID()

	--Insert Partner
	INSERT INTO dbo.TradingPartner(
	  PK_PartnerID,
	  PartnerName, 
	  InterchangeIDQualifier, 
	  InterchangeID,
	  Activated,
	  ExternalReferenceID)

	   SELECT
	      @partnerid																		AS PK_PartnerID,
		  partner.header.value('(PartnerName/text())[1]',				'nvarchar(100)')	AS PartnerName,
		  partner.header.value('(InterchangeIDQualifier/text())[1]',	'nchar(2)')			AS InterchangeIDQualifier,
		  partner.header.value('(InterchangeID/text())[1]',				'nvarchar(15)')		AS InterchangeID,
		  partner.header.value('(Activated/text())[1]',					'bit')				AS Activated,
		  partner.header.value('(ExternalReferenceID/text())[1]',		'nvarchar(50)')		AS ExternalReferenceID
	   FROM 
		  @partner.nodes('//Partner') partner(header)

  --Call sp to create Functional Groups
  IF(@partner.exist('//Partner/FunctionalGroups') = 1)
	BEGIN
	  DECLARE @groupText xml;
	  SELECT @groupText		= (SELECT @partner.query('//Partner/FunctionalGroups'));

	  EXEC dbo.sp_FunctionalGroup_Create @group	= @groupText,
	                                 @partnerid	= @partnerid
	END

	--Return the TPID
	SELECT @tpid = @partnerid

END TRY

BEGIN CATCH  
  THROW
END CATCH
GO

USE [NeuronEDI]
GO

/****** Object:  StoredProcedure [dbo].[sp_TradingPartner_Update]    Script Date: 3/2/2017 9:02:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


/****** Object:  Stored Procedure dbo.sp_TradingPartner_Update    Script Date: 11/28/2016 7:07:13 PM ******/

CREATE PROCEDURE [dbo].[sp_TradingPartner_Update]
(
	@partner xml
)
AS 
DECLARE @partnerid uniqueidentifier;
DECLARE @partnername nvarchar(100);
DECLARE @interchangeidqual nchar(2);
DECLARE @interchangeid nvarchar(15);
DECLARE @groupid uniqueidentifier;
DECLARE @groupname nvarchar(100);
DECLARE @functionalgroupid nvarchar(15);
DECLARE @groupactivated bit;
DECLARE @partneractivated bit;
DECLARE @externalreferenceid nvarchar(50);

SET @partnerid				= (SELECT partner.header.value('(PartnerID/text())[1]',					'uniqueidentifier')	FROM @partner.nodes('//Partner') partner(header));
SET @partnername			= (SELECT partner.header.value('(PartnerName/text())[1]',				'nvarchar(100)')	FROM @partner.nodes('//Partner') partner(header));
SET @interchangeidqual		= (SELECT partner.header.value('(InterchangeIDQualifier/text())[1]',	'nchar(2)')			FROM @partner.nodes('//Partner') partner(header));
SET @interchangeid			= (SELECT partner.header.value('(InterchangeID/text())[1]',				'nvarchar(15)')		FROM @partner.nodes('//Partner') partner(header));
SET @partneractivated		= (SELECT partner.header.value('(Activated/text())[1]',					'bit')				FROM @partner.nodes('//Partner') partner(header));
SET @externalreferenceid	= (SELECT partner.header.value('(ExternalReferenceID/text())[1]',		'nvarchar(50)')		FROM @partner.nodes('//Partner') partner(header));
SET @groupid				= (SELECT partner.header.value('(GroupID/text())[1]',					'uniqueidentifier')	FROM @partner.nodes('//Partner/FunctionalGroups/FunctionalGroup') partner(header));
SET @groupname				= (SELECT partner.header.value('(GroupName/text())[1]',					'nvarchar(100)')	FROM @partner.nodes('//Partner/FunctionalGroups/FunctionalGroup') partner(header));
SET @functionalgroupid		= (SELECT partner.header.value('(FunctionalGroupID/text())[1]',			'nvarchar(15)')		FROM @partner.nodes('//Partner/FunctionalGroups/FunctionalGroup') partner(header));
SET @groupactivated			= (SELECT partner.header.value('(Activated/text())[1]',					'bit')				FROM @partner.nodes('//Partner/FunctionalGroups/FunctionalGroup') partner(header));

BEGIN TRY
	--Update Partner and associated Agreements
	BEGIN TRANSACTION;
	--Sender agreements
	UPDATE dbo.Agreement
	SET
		ISA05SenderInterchangeIDQualifier	= @interchangeidqual,
		ISA06SenderInterchangeID			= @interchangeid,
		GS02ApplicationSenderID				= @functionalgroupid
	FROM 
		dbo.TradingPartner tbl_TradingPartner
	WHERE
		ISA06SenderInterchangeID = (SELECT tbl_TradingPartner.InterchangeID WHERE PK_PartnerID = @partnerid);

	--Receiver agreements
	UPDATE dbo.Agreement
	SET
		ISA07ReceiverInterchangeIDQualifier	= @interchangeidqual,
		ISA08ReceiverInterchangeID			= @interchangeid,
		GS03ApplicationReceiverID			= @functionalgroupid
	FROM 
		dbo.TradingPartner					tbl_TradingPartner
	WHERE
		ISA08ReceiverInterchangeID = (SELECT tbl_TradingPartner.InterchangeID WHERE PK_PartnerID = @partnerid)

	--Partner
	UPDATE dbo.TradingPartner
	SET
		PartnerName				= @partnername,
		InterchangeIDQualifier	= @interchangeidqual,
		InterchangeID			= @interchangeid,
		Activated				= @partneractivated,
		ExternalReferenceID		= @externalreferenceid
	FROM 
		dbo.TradingPartner tblTradingPartner
	WHERE
		tblTradingPartner.PK_PartnerID = @partnerid

	--Functional Group
	  IF(@partner.exist('//Partner/FunctionalGroups') = 1)
		BEGIN
		  DECLARE @groupxml xml;
		  SELECT  @groupxml = (SELECT @partner.query('//Partner/FunctionalGroups'));

		  EXEC dbo.sp_FunctionalGroup_Update @group			= @groupxml
		END
	COMMIT;

	--If Partner is being deactivated, then deactivate all of it's agreements also
	IF((SELECT partner.header.value('(Activated/text())[1]', 'bit') FROM @partner.nodes('//Partner') partner(header)) = 'false')
	  UPDATE dbo.Agreement
	  SET 
		Activated = 'false'
	  WHERE 
		ISA05SenderInterchangeIDQualifier	= (SELECT partner.header.value('(InterchangeIDQualifier/text())[1]',	'nchar(2)')			FROM @partner.nodes('//Partner') partner(header)) AND
		ISA06SenderInterchangeID			= (SELECT partner.header.value('(InterchangeID/text())[1]',				'nvarchar(15)')		FROM @partner.nodes('//Partner') partner(header)) OR
		ISA07ReceiverInterchangeIDQualifier	= (SELECT partner.header.value('(InterchangeIDQualifier/text())[1]',	'nchar(2)')			FROM @partner.nodes('//Partner') partner(header)) AND
		ISA08ReceiverInterchangeID			= (SELECT partner.header.value('(InterchangeID/text())[1]',				'nvarchar(15)')		FROM @partner.nodes('//Partner') partner(header))

END TRY

BEGIN CATCH
  THROW
END CATCH
GO

USE [NeuronEDI]
GO

/****** Object:  UserDefinedFunction [dbo].[ufn_Group_IsActive]    Script Date: 3/2/2017 9:03:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [dbo].[ufn_Group_IsActive]
(
	@groupid uniqueidentifier
)
RETURNS bit
AS
BEGIN
	DECLARE @count int;
	DECLARE @result bit;

	SET @count = (SELECT COUNT(*) 
				  FROM dbo.FunctionalGroup
				  WHERE PK_GroupID	= @groupid AND
					      Activated = 1);

	IF(@count = 1)
	BEGIN
		SET @result = 1
	END
	ELSE IF(@count = 0)
	BEGIN
		SET @result = 0
	END
	ELSE
	BEGIN
		SET @result = NULL
	END

	RETURN @result;
END

GO

USE [NeuronEDI]
GO

/****** Object:  UserDefinedFunction [dbo].[ufn_Group_IsValid]    Script Date: 3/2/2017 9:03:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [dbo].[ufn_Group_IsValid]
(
	@groupid uniqueidentifier
)
RETURNS bit
AS
BEGIN
	DECLARE @result bit;

	SET @result = (SELECT COUNT(*) 
				   FROM dbo.FunctionalGroup
				   WHERE PK_GroupID = @groupid);

	RETURN @result;
END

GO

USE [NeuronEDI]
GO

/****** Object:  UserDefinedFunction [dbo].[ufn_Partner_IsActive]    Script Date: 3/2/2017 9:03:18 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [dbo].[ufn_Partner_IsActive]
(
	@partnerid uniqueidentifier
)
RETURNS bit
AS
BEGIN
	DECLARE @result bit;
	DECLARE @count int;

		SET @count = (SELECT COUNT(*) 
					  FROM dbo.TradingPartner
					  WHERE PK_PartnerID	= @partnerid AND
							      Activated = 1);
	
		IF(@count = 1)
		BEGIN
			SET @result = 1;
			RETURN @result
		END

		ELSE IF (@count = 0)
		BEGIN
			SET @result = 0;
			RETURN @result
		END

		ELSE
		  SET @result = NULL;
		  RETURN @result
END

GO

USE [NeuronEDI]
GO

/****** Object:  UserDefinedFunction [dbo].[ufn_Partner_IsValid]    Script Date: 3/2/2017 9:03:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [dbo].[ufn_Partner_IsValid]
(
	@partnerid uniqueidentifier
)
RETURNS bit
AS
BEGIN
	DECLARE @result bit;
	DECLARE @count int;

		SET @count = (SELECT COUNT(*) 
					  FROM dbo.TradingPartner
					  WHERE PK_PartnerID = @partnerid)
	
		IF(@count = 1)
		BEGIN
			SET @result = 1;
			RETURN @result
		END

		ELSE IF(@count = 0)
		BEGIN
			SET @result = 0;
			RETURN @result;
		END

		ELSE
			SET @result = NULL;
			RETURN @result;
END

GO

