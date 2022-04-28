IF EXISTS (SELECT name FROM sysobjects WHERE name = 'SP_TriggerAlarms' AND type = 'P')
DROP PROCEDURE SP_TriggerAlarms
GO

CREATE PROCEDURE SP_TriggerAlarms
@TagValue float,
@AlarmConfigurationId int
AS

DECLARE
@AlarmLowerLimit float,
@AlarmUpperLimit float,
@AlarmName varchar(50)

select @AlarmLowerLimit = AlarmLowerLimit from ALARMCONFIGURATION where AlarmConfigurationId=@AlarmConfigurationId
select @AlarmUpperLimit = AlarmUpperLimit from ALARMCONFIGURATION where AlarmConfigurationId=@AlarmConfigurationId
select @AlarmName = AlarmName from ALARMCONFIGURATION where AlarmConfigurationId=@AlarmConfigurationId

IF(@TagValue BETWEEN @AlarmLowerLimit AND @AlarmUpperLimit )
	INSERT INTO ALARM(AlarmTimeStamp, Value, AcknowledgeId, AlarmConfigurationId)
	VALUES(
	CURRENT_TIMESTAMP,
	@TagValue,
	(select AcknowledgeId from ACKNOWLEDGE where AckStatus=0),
	(select AlarmConfigurationId from ALARMCONFIGURATION where AlarmName=@AlarmName)
	)
GO