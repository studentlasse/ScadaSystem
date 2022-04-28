IF EXISTS (SELECT name FROM sysobjects WHERE name='TriggerAlarmIO' AND type='TR')
DROP TRIGGER TriggerAlarmIO
GO

CREATE TRIGGER TriggerAlarmIO ON TAGDATA
FOR UPDATE, INSERT, DELETE
AS

DECLARE
-- Input values
@TagId int,
@TagValue float

select @TagId = TagId from INSERTED
select @TagValue = TagValue from INSERTED

IF(@TagId = 1 and @TagValue < 0)
	INSERT INTO ALARM(AlarmTimeStamp, Value, AcknowledgeId, AlarmConfigurationId)
	VALUES(
	CURRENT_TIMESTAMP,
	@TagValue,
	(select AcknowledgeId from ACKNOWLEDGE where AckStatus=0),
	4
	)
GO