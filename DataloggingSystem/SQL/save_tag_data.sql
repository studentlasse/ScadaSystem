IF EXISTS (SELECT Name FROM SYSOBJECTS WHERE Name = 'SaveTagData' AND Type = 'P')
DROP PROCEDURE SaveTagData
GO

CREATE PROCEDURE SaveTagData
@TagName varchar(50),
@TagValue float,
@TagStatus varchar(20),
@TagQuality varchar(20)
AS

DECLARE
@TagId int

SELECT @TagId = TagId FROM TAGCONFIGURATION WHERE TagName = @TagName

INSERT INTO TAGDATA 
	(TagValue, TagTimestamp, TagStatus, TagQuality, TagId) 
VALUES
	(@TagValue, GETDATE(), @TagStatus, @TagQuality, @TagId) 
GO
