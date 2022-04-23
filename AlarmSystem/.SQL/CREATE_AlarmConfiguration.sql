IF EXISTS (SELECT name FROM sysobjects WHERE name = 'CreateAlarmConfiguration' AND type = 'P')
DROP PROCEDURE CreateAlarmConfiguration
GO

CREATE PROCEDURE CreateAlarmConfiguration
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

if not exists (select * from ALARMCONFIGURATION where AlarmName = @AlarmName)
INSERT INTO ALARMCONFIGURATION (AlarmName, AlarmDescription, AlarmLowerLimit, AlarmUpperLimit, AlarmLevelId, TagId) 
VALUES (
@AlarmName,
@AlarmDescription,
@AlarmLowerLimit,
@AlarmUpperLimit,
(select AlarmLevelId from ALARMLEVEL where AlarmLevel=@AlarmLevel),
(select TagId from TAGCONFIGURATION where TagName=@TagName)
)

GO