IF EXISTS (SELECT name FROM sysobjects WHERE name='AddAckTimeStamp' AND type='TR')
DROP TRIGGER AddAckTimeStamp
GO

CREATE TRIGGER AddAckTimeStamp ON ALARM
FOR UPDATE, INSERT, DELETE
AS

DECLARE
@AlarmId int,
@AcknowledgeId int,
@AlarmConfigurationId int,
@AlarmTimeStamp datetime,
@AlarmValue float

select @AlarmId = AlarmId from INSERTED
select @AcknowledgeId = AcknowledgeId from INSERTED
select @AlarmConfigurationId = AlarmConfigurationId from INSERTED
select @AlarmTimeStamp = AlarmTimeStamp from INSERTED
select @AlarmValue = Value from INSERTED

IF(@AcknowledgeId =2)
	INSERT INTO ALARM(AcknowledgeId, AlarmConfigurationId, AlarmTimeStamp, Value, AckTimeStamp)
	VALUES(@AcknowledgeId,@AlarmConfigurationId, @AlarmTimeStamp, @AlarmValue, CURRENT_TIMESTAMP)
GO