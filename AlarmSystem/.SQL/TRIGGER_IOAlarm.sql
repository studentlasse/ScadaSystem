IF EXISTS (SELECT name FROM sysobjects WHERE name='TriggerAlarmIO' AND type='TR')
DROP TRIGGER TriggerAlarmIO
GO

CREATE TRIGGER TriggerAlarmIO ON TAGDATA
FOR UPDATE, INSERT, DELETE
AS

DECLARE
-- Input values
@TagDataId int,
@TagValue float,

-- Alarm variables
@AlarmName varchar(50)

select @TagDataId = TagDataId from INSERTED
select @TagValue = TagValue from INSERTED

select @AlarmName = AlarmName from ALARMCONFIGURATION where AlarmConfigurationId=4

IF(@TagValue < 0)
	INSERT INTO ALARM(AlarmTimeStamp, Value, AcknowledgeId, AlarmConfigurationId)
	VALUES(
	CURRENT_TIMESTAMP,
	@TagValue,
	(select AcknowledgeId from ACKNOWLEDGE where AckStatus=0),
	(select AlarmConfigurationId from ALARMCONFIGURATION where AlarmName=@AlarmName)
	)
GO