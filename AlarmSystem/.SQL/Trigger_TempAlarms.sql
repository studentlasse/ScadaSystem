IF EXISTS (SELECT name FROM sysobjects WHERE name='TriggerTempAlarms' AND type='TR')
DROP TRIGGER TriggerTempAlarms
GO

CREATE TRIGGER TriggerTempAlarms ON TAGDATA
FOR UPDATE, INSERT
AS
BEGIN
DECLARE
@TagId int,
@TagValue float,
@AlarmConfigurationId int

select @TagId = TagId from INSERTED

IF(@TagId=1)
BEGIN
	select @TagValue = TagValue from inserted
	EXEC SP_TriggerAlarms @TagValue, 1
	EXEC SP_TriggerAlarms @TagValue, 2
	EXEC SP_TriggerAlarms @TagValue, 3
	EXEC SP_TriggerAlarms @TagValue, 4
END
IF(@TagId=3)
BEGIN
	select @TagValue = TagValue from inserted
	EXEC SP_TriggerAlarms @TagValue, 6
	EXEC SP_TriggerAlarms @TagValue, 7
END

END
GO

