﻿CREATE TABLE [dbo].[Customer]
(
	[cID] INT NOT NULL PRIMARY KEY, 
    [cName] NVARCHAR(255) NOT NULL, 
    [cNumber] NVARCHAR(255) NOT NULL, 
    [cAddress] NVARCHAR(255) NOT NULL, 
    [cEmail] NVARCHAR(255) NOT NULL, 
    [cNID] NVARCHAR(255) NOT NULL, 
    [cRating] INT NULL, 
    [BidLimit] INT NULL, 
    [VarificationStatus] VARCHAR(50) NULL
)
