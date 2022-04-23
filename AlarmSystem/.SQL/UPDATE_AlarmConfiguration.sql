IF EXISTS (SELECT name FROM sysobjects WHERE name = 'UpdateAlarmConfiguration' AND type = 'P')
DROP PROCEDURE UpdateAlarmConfiguration
GO

CREATE PROCEDURE UpdateAlarmConfiguration
@AlarmConfigurationId int,
@AlarmName varchar(50),
@AlarmDescription varchar(100),
@AlarmLevel varchar(50),
@TagName varchar(50),
@AlarmLowerLimit float,
@AlarmUpperLimit float
AS

if not exists (select * from ALARMLEVEL where AlarmLevel = @AlarmLevel)
INSERT INTO ALARMLEVEL (AlarmLevel) VALUES (@AlarmLevel)

if not exists (select * from TAGCONFIGURATION where TagName = @TagName)
INSERT INTO TAGCONFIGURATION (TagName) VALUES (@TagName)

UPDATE ALARMCONFIGURATION SET
AlarmName = @AlarmName,
AlarmDescription = @AlarmDescription,
AlarmLowerLimit = @AlarmLowerLimit,
AlarmUpperLimit = @AlarmUpperLimit,
AlarmLevelId = (select AlarmLevelId from ALARMLEVEL where AlarmLevel=@AlarmLevel),
TagId = (select TagId from TAGCONFIGURATION where TagName=@TagName)
WHERE AlarmConfigurationId = @AlarmConfigurationId

GO