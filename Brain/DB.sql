USE [master]
GO
/****** Object:  Database [aspnet-Brain-20160522102326]    Script Date: 5/22/2016 8:17:57 PM ******/
CREATE DATABASE [aspnet-Brain-20160522102326]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BrainProjectDB.mdf', FILENAME = N'D:\hackRuse\Brain\Brain\App_Data\BrainProjectDB.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BrainProjectDB_log.ldf', FILENAME = N'D:\hackRuse\Brain\Brain\App_Data\BrainProjectDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [aspnet-Brain-20160522102326].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET ARITHABORT OFF 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET  ENABLE_BROKER 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET  MULTI_USER 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET DB_CHAINING OFF 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET DELAYED_DURABILITY = DISABLED 
GO
USE [aspnet-Brain-20160522102326]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 5/22/2016 8:17:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 5/22/2016 8:17:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201605220920379_InitialCreate', N'Brain.Models.BrainContext', 0x1F8B0800000000000400CD57CB6E1B3714DD17C83F105CA58023FAB1698D99048E6C074223DBC838D953335732513E2624C795BEAD8B7E527FA197F3D68C65596E8016DACC702ECF3DF7F03EA8BFFFFC2BFAB056923C8275C2E8989E4C8E29019D9A4CE8554C0BBF7CF70BFDF0FECD4FD155A6D6E45B637716EC70A776317DF03E3F67CCA50FA0B89B28915AE3CCD24F52A318CF0C3B3D3EFE959D9C3040088A5884445F0AED8582F2055FA746A790FB82CBB9C940BA7A1DBF24252AB9E10A5CCE5388E947CB859E5476945C48C1914302724909D7DA78EE91E1F9570789B746AF921C17B8BCDFE480764B2E1DD4CCCF3BF39706717C1A8260DDC6062A2D9C37EA40C093B35A1536DCFE2A6D69AB1AEA7685FAFA4D88BAD42EA62888A564E8E87C2A6D30DA9675128C8F48B974D41E3AE646F81D9169217D6121D65078CBE511B92B1652A4BFC1E6DEFC0E3AD685947D324807BF6D2DE0D29D353958BFF902CB1EC5594609DBDECB869BDBAD837D552033EDCF4E29B941127C21A13DF35ED08937163E8106CB3D6477DC7BB07864B30C4AD5460C9EF0A7F1A9F1888986D542C99CAF3F835EF98798E22325D7620D59B352B3F8AA0516176EF2B6807D8EEEB8737F189BFD604711EBB2639C33588B1ECF1D6C4DA2CC82B0086BFF4402A118750EB9DAD77648156802BE271ED66DC7A02ADE49959F4FD16C09755D81556DA1691F6C47FF88E63CCF51B15E3FA95748523593E9BBE4F05A5315064BDD1325D7B26D3D61B2F1150CBEA26B647A2DACF397DCF3050F6736CDD4C86C4BFE1DD236AEFA0A0FCBAD13BCB10ECFBD23EED7FE707727DC35C6A2B04CCAB0A06550F797D1B6B28373C9ED8E929D1A5928FD5CF9EF43A90A718853ADBE1CA9ABB43E52B73A468AD84091A1E06CA4F8A0AD0D8FEFB9D41F9AB4DEDB1218A47A54A7DDFE793ACAC3CA841294E851642107938DF3A026C160927C97532930DECE60CEB55882F355F7A738D84E0783F9FF33249973997CC1A4FCCFC69708CAEE1D50A3E976D8C4D28FDCA60FDCBE557CFD731FED3553E900B0C326CFB843EE1F2D3B274B95D531CD1606895704FFD5CC191758C4FAD7DAE8129C587510E192AB210D99DB81363633BD348DCC18509F516332388539789EA12E17D68B254F3D7E4EC1B9F27EF08DCB024DAED402B299BE2D7C5EF80BE7402DE4D6E52662CFFB2F07EB36E7E8360F6FEE47848034058600B7FA632164D6F2BE1EA7F42E889022759D202BBC1F21DC6AD322DD18FD42A05ABE4BC841872ABB07954B0473B73AE18FF01A6E985D9F61C5D34DD3277783EC3F886DD9A34BC157962B576374FBC35F3516FEABBDFF078799B208DD0D0000, N'6.1.3-40302')
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201605220948548_Added Email to User class', N'Brain.Models.BrainContext', 0x1F8B0800000000000400CD57CB6EE33614DD17E83F105CB540C6CC63D306D20C324E52181D27C128337B5ABA7688F2A192546A7F5B17FDA4FE422FF5B614C7F6CC142DBC91A8CB73CF3DBC0FFAEF3FFF8ADEAD9524CF609D303AA66793534A40A726137A15D3C22FDFFC44DFBDFDFEBBE826536BF2B9B1BB0876B853BB983E799F5F32E6D22750DC4D9448AD7166E927A9518C67869D9F9EFECCCECE182004452C42A28F85F64241F982AF53A353C87DC1E5DC64205DBD8E5F921295DC71052EE729C4F4BDE5424F2A3B4AAEA4E0C82101B9A4846B6D3CF7C8F0F29383C45BA357498E0B5C3E6E7240BB25970E6AE6979DF9A1419C9E872058B7B1814A0BE78D3A12F0ECA256850DB77F91B6B4550D75BB417DFD26445D6A175314C452327474399536186DCB3A09C627A45C3A690F1D7323FC4EC8B490BEB0106B28BCE5F2843C140B29D25F61F3687E031DEB42CA3E19A483DFB61670E9C19A1CACDF7C84658FE22CA3846DEF65C3CDEDD6C1BE2A9099F617E794DC2109BE90D09E792FE8C41B0BBF8006CB3D640FDC7BB07864B30C4AD5460C5EF0A7F1A9F1888986D542C99CAF3F805EF9A798E22325B7620D59B352B3F8A40516176EF2B6807D8E6E1417F25FF7F2C09DFBC3D8EC1B3B8A589783E3CCC48AF7985D606B1265AE854558FB17D21425AF33D5D5BEB643AA4013F0BD23C2EED031A85AC4A4AA829768B684BADEC3AAE6D33429B6A34B45739EE7A858AF6BD52B24A95AD6F44D727C45AB0A83A5EE85C26ED9B69E30A5F90A065FD13532BD15D6F96BEEF98287339B666A64B625FF0E691B577D858745DD09DE5887E7DE11F73BCC707727DC2DC6A2B018CBB0A0655077B1D1B6724E70C9ED8EC63035B250FAB526B30FA52AF7214EB57A38525DCF7D987AE9708CAE5AFB30DDEA18296203558787C646A73668C0C31478AD7C8626ADF7B68C06E512D5A9BB7FF28F72B932A104257A1659C8E364E33CA849309824BFCBA914186F6730E75A2CC1F96A4E511CC1E7832BC4FF679C33E73279C04CFFCF06AD08CAEE1DA5A3397CDC6CD5CFDCA64FDCFEA0F8FAC73EDAD1F3F3AB908633F208B0E3E6E0B85FEF1F743BE75C551F31CD1606895704BF6A028E4B3562FDAB7C740D4EAC3A8870B1D790861AE8401B9B995E9A46660CA8CFA831199CC21C3CCF50972BEBC592A71E3FA7E05C795BF9CC65511EF902B299BE2F7C5EF82BE7402DE4D6852E62AFFB2FC7FC36E7E83E0F6FEE5B848034058600F7FA7D2164D6F2BE1D17C72E88902275C5212BBCAD21DC6AD322DD197D20502DDF35E4A043BD3E82CA2582B97B9DF067F8126E985D1F60C5D34DD3717783EC3F886DD9A36BC157962B576374FBC3DF5316FE9FBEFD07849A40BBD10E0000, N'6.1.3-40302')
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [Username], [Password], [Email]) VALUES (1, N'pesho', N'123', NULL)
INSERT [dbo].[User] ([UserId], [Username], [Password], [Email]) VALUES (2, N'peti', N'123', NULL)
INSERT [dbo].[User] ([UserId], [Username], [Password], [Email]) VALUES (3, N'niki', N'123', NULL)
SET IDENTITY_INSERT [dbo].[User] OFF
USE [master]
GO
ALTER DATABASE [aspnet-Brain-20160522102326] SET  READ_WRITE 
GO
