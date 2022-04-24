IF EXISTS (SELECT name FROM sysobjects WHERE name = 'UpdateAlarm' AND type = 'P')
DROP PROCEDURE UpdateAlarm
GO

CREATE PROCEDURE UpdateAlarm
@AlarmId int,
@AckStatus bit,
@AlarmName varchar(50),
@AlarmTimeStamp datetime,
@AlarmValue float
AS

if not exists (select * from ACKNOWLEDGE where AckStatus=@AckStatus)
INSERT INTO ACKNOWLEDGE(AckStatus) VALUES (@AckStatus)

if not exists (select * from ALARMCONFIGURATION where AlarmName=@AlarmName)
INSERT INTO ALARMCONFIGURATION(AlarmName) VALUES (@AlarmName)

UPDATE ALARM SET
AlarmConfigurationId = (select AlarmConfigurationId FROM ALARMCONFIGURATION where AlarmName=@AlarmName),
AcknowledgeId = (select AcknowledgeId FROM ACKNOWLEDGE where AckStatus=@AckStatus),
AlarmTimeStamp = CURRENT_TIMESTAMP,
Value = @AlarmValue
where AlarmId=@AlarmId

GO