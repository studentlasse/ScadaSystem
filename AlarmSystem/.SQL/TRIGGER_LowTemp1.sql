IF EXISTS (SELECT name FROM sysobjects WHERE name='TRIGGER_LowTemp1' AND type='TR')
DROP TRIGGER TRIGGER_LowTemp1
GO

CREATE TRIGGER TRIGGER_LowTemp1 ON TAGDATA
FOR UPDATE, INSERT, DELETE
AS

DECLARE
-- Input values
@TagDataId int,
@TagValue float,

-- Alarm variables
@AlarmName varchar(50),
@AlarmLowerLimit float,
@AlarmUpperLimit float

select @TagDataId = TagDataId from INSERTED
select @TagValue = TagValue from INSERTED

select @AlarmLowerLimit = AlarmLowerLimit from ALARMCONFIGURATION where AlarmConfigurationId=13
select @AlarmUpperLimit = AlarmUpperLimit from ALARMCONFIGURATION where AlarmConfigurationId=13
select @AlarmName = AlarmName from ALARMCONFIGURATION where AlarmConfigurationId=13

IF(@TagValue BETWEEN @AlarmLowerLimit AND @AlarmUpperLimit )
	INSERT INTO ALARM(AlarmTimeStamp, Value, AcknowledgeId, AlarmConfigurationId)
	VALUES(
	CURRENT_TIMESTAMP,
	@TagValue,
	(select AcknowledgeId from ACKNOWLEDGE where AckStatus=0),
	(select AlarmConfigurationId from ALARMCONFIGURATION where AlarmName=@AlarmName)
	)
GO