﻿CREATE TABLE [dbo].[Sales] (
    [ID] [int] NOT NULL IDENTITY,
    [CoffeeName] [nvarchar](max) NOT NULL,
    [Quantity] [int] NOT NULL,
    [DateTime] [datetime] NOT NULL,
    [Price] [int] NOT NULL,
    [Total] [int] NOT NULL,
    [Age] [int] NOT NULL,
    [MobileNumber] [int] NOT NULL,
    CONSTRAINT [PK_dbo.Sales] PRIMARY KEY ([ID])
)
CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId] [nvarchar](150) NOT NULL,
    [ContextKey] [nvarchar](300) NOT NULL,
    [Model] [varbinary](max) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201703041032101_AutomaticMigration', N'coffeeSalesManag_CompApp.Migrations.Configuration',  0x1F8B0800000000000400CD584B8EE33610DD07C81D04AD12A0C7ECCF2669C83370ECEEC0C8B8BB33F2CC76404B2535118A5448AA619F2D8B1C295748517F4BFEC8F62008BC914A558F8FC5AAA792FFF9EB6FEFC33AE1CE1B28CDA418BB37A36BD70111C8908978EC66267AF793FBE1FDF7DF790F61B276BE547E77D60F23851EBBAFC6A4F784E8E01512AA47090B94D43232A34026848692DC5E5FFF4C6E6E0820848B588EE37DCA846109E437783B952280D464942F64085C97767CE2E7A8CE134D40A73480B11BC82802F02907BDA082C65FA7324927693A2A425D67C219455A3EF0C875A810D25083A4EF3F6BF08D9222F6533450BEDCA4807E11E51ACACDDC37EE43F7757D6BF7459AC00A2AC8B491C98980377765A24837FCAC74BB752231950F9872B3B1BBCED38919C21CBA4E77A1FB2957D6E968A647F6C995B3CFEBAAAE162C2AFBBB72A619379982B180CC28CAAF9C976CC559F01B6C96F20F10639171DEA68CA4F1D996014D2F4AA6A0CCE61344E546E633D721DB71A41B5887B5628A6DCE85B9BB759D275C9CAE38D415D14A896FA4825F4180A206C2176A0C283CD07908794E7BAB77D69AE629B2D7D59A5888D860AEB3A0EB8F2062F33A76F1D2751ED91AC2CA52F2F82C18F623061995C10E9E87D7FE3DA325C7C3BB3D8C32C37D2F59C3BFB93F11E845B1002EE3B2C453E197414CE20B392CE48A7178CA9215A853903CD27461BF3751060D65586555D65745E5583BACCD8E5E454D2BDB5597F5B14DBBC0F5C1B45A1E25B22151E8E4A890825D4C6B4E8D269342942BF1267BD4DB5BD034C52A6FA9796971FC42CAA7EFFCD3652D293048A077A85BCDB65E093B97C6D0796A5B328447A6B4C14AA62B6ACF691A263DB7EE09ECC96EB55A3BC95DD96A725E79DBEB226288D276019B743EE20E1354A27CB350932A05BE1796BF5529A76A87224E25CF12B14F550F45B735AE8DD2B60F476B54AB8DD5588723354AD5466AACC3914AE96AC394A6E118A576B5314AD3708C5CBCDA08B96178FCB676B581B69FF4113DD2A9B86E8D935E9177DECADD8E3924385D977AF55A783A02E395CD7E7C86EC757FE1E23A98AA3716DACEF737DA4032B20E23FF4F3EE50CF7DB38609BB208B42906171727B7DBCEE4F9FF990289D6211F300AFEE79317B3193D3A5B9DF86AEE0F5BE28DAAE095AA1F12BAFEF1E2012A277DE1F814E2BDB9787C3A87C9D6F0740E406B743A277CD7E0741CE7B4B1A9FF6E3F3E14ED9D890A65C0235B49E45B302CA7A833C7A5BE4A79A4FD3DECCD40B3B881B05FC70202DBFE0D68E5331791AC528C3B6A33AA5CBA27008662FDD189322CA281C1C701689D7F8E7CA13C4397073C9D702E9E33936666A235242BBEF5D2F5C8E1F5F399709BB3F79CDA3BFD2DB68034996DA167F14BC67858F37EDC51397B206C8D94A283ACF0730CE1E24D8DF424C540A0327D33484158C95A42927204D3CFC2A76F700E371CEA3F424C834DF5B2D90F72FC20B6D3EECD188D154D7489D1C4DBFF7888FD93E7FDBF96413FAC16120000 , N'6.1.3-40302')
