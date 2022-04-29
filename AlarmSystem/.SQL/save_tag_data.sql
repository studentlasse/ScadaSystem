IF EXISTS (SELECT Name FROM SYSOBJECTS WHERE Name = 'SaveTagData' AND Type = 'P')
DROP PROCEDURE SaveTagData
GO

CREATE PROCEDURE SaveTagData
@TagName varchar(50),
@TagValue float,
@TagStatus varchar(20)
AS

DECLARE
@TagId int

SELECT @TagId = TagId FROM TAGCONFIGURATION WHERE TagName = @TagName

INSERT INTO TAGDATA
	(TagValue, TagTimestamp, TagStatus, TagId) 
VALUES
	(@TagValue, GETDATE(), @TagStatus, @TagId) 
GO
