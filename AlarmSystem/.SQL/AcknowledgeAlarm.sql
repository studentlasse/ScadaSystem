IF EXISTS (SELECT name FROM sysobjects WHERE name = 'AcknowledgeAlarm' AND type = 'P')
DROP PROCEDURE AcknowledgeAlarm
GO

CREATE PROCEDURE AcknowledgeAlarm
@AlarmId int
AS

update ALARM SET 
AcknowledgeId = 4
where AlarmId = @AlarmId