IF EXISTS (SELECT name FROM sysobjects WHERE name = 'DeleteAlarmConfiguration' AND type = 'P')
DROP PROCEDURE DeleteAlarmConfiguration
GO

CREATE PROCEDURE DeleteAlarmConfiguration
@AlarmConfigurationId int
AS

delete from ALARMCONFIGURATION where AlarmConfigurationId=@AlarmConfigurationId

GO