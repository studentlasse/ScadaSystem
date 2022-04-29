IF EXISTS (SELECT name FROM sysobjects WHERE name='TriggerAlarmSystem' AND type='TR')
DROP TRIGGER TriggerAlarmSystem
GO

CREATE TRIGGER TriggerAlarmSystem ON TAGDATA
FOR UPDATE, INSERT, DELETE
AS

DECLARE
-- Input values
@TagId int,
@TagValue float

select @TagId = TagId from INSERTED
select @TagValue = TagValue from INSERTED

IF(@TagValue < 0 AND @TagId = 5)
	INSERT INTO ALARM(AlarmTimeStamp, Value, AcknowledgeId, AlarmConfigurationId)
	VALUES(
	CURRENT_TIMESTAMP,
	@TagValue,
	(select AcknowledgeId from ACKNOWLEDGE where AckStatus=0),
	8
	)
GO