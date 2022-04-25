USE [SCADADB]
GO
/****** Object:  Trigger [dbo].[TriggerTest]    Script Date: 25.04.2022 23.58.22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER TRIGGER [dbo].[TriggerTest] ON [dbo].[TAGDATA]
FOR UPDATE, INSERT, DELETE
AS

DECLARE
-- Input values
@TagDataId int,
@TagValue float,
@TagId int,
@TagValueId int,

-- Alarm variables
@AlarmName varchar(50),
@AlarmLowerLimit float,
@AlarmUpperLimit float

select @TagDataId = TagDataId from INSERTED
select @TagValue = TagValue from INSERTED
select @TagId = TagId from TAGCONFIGURATION where TagName='tagRealProcessValue'
select @TagValueId from INSERTED

IF(@TagId=@TagValueId)
select @AlarmLowerLimit = AlarmLowerLimit from ALARMCONFIGURATION where AlarmName='Notification'
select @AlarmUpperLimit = AlarmUpperLimit from ALARMCONFIGURATION where AlarmName='Notification'
select @AlarmName = AlarmName from ALARMCONFIGURATION where AlarmName='Notification'

	IF(@TagValue BETWEEN @AlarmLowerLimit AND @AlarmUpperLimit)
		INSERT INTO ALARM(AlarmTimeStamp, Value, AcknowledgeId, AlarmConfigurationId)
		VALUES(
		CURRENT_TIMESTAMP,
		@TagValue,
		(select AcknowledgeId from ACKNOWLEDGE where AckStatus=0),
		(select AlarmConfigurationId from ALARMCONFIGURATION where AlarmName=@AlarmName)
		)
GO