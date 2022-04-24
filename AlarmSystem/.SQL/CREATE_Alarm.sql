IF EXISTS (SELECT name FROM sysobjects WHERE name = 'CreateAlarm' AND type = 'P')
DROP PROCEDURE CreateAlarm
GO

CREATE PROCEDURE CreateAlarm
@AckStatus bit,
@AlarmName varchar(50),
@AlarmTimeStamp datetime,
@AlarmValue float
AS

if not exists (select * from ACKNOWLEDGE where AckStatus=@AckStatus)
INSERT INTO ACKNOWLEDGE(AckStatus) VALUES (@AckStatus)

if not exists (select * from ALARMCONFIGURATION where AlarmName=@AlarmName)
INSERT INTO ALARMCONFIGURATION(AlarmName) VALUES (@AlarmName)

if not exists (select * from ALARM where AlarmTimeStamp = @AlarmTimeStamp)
INSERT INTO ALARM(AlarmTimeStamp, Value, AcknowledgeId, AlarmConfigurationId)
VALUES (
@AlarmTimeStamp,
@AlarmValue,
(select AcknowledgeId from ACKNOWLEDGE where AckStatus=@AckStatus),
(select AlarmConfigurationId from ALARMCONFIGURATION where AlarmName=@AlarmName)
)
GO