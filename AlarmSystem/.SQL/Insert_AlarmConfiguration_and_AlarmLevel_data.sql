DELETE FROM ALARMCONFIGURATION;
DELETE FROM ALARMLEVEL;
Declare @TagId int;
Declare @AlarmLevelId int;


-- Updating the ALARMLEVEL table
INSERT INTO ALARMLEVEL(AlarmLevel, AlarmLevelDescription) VALUES ('1', 'Lowest');
INSERT INTO ALARMLEVEL(AlarmLevel, AlarmLevelDescription) VALUES ('2', 'Medium');
INSERT INTO ALARMLEVEL(AlarmLevel, AlarmLevelDescription) VALUES ('3', 'Highest');

-- Updating the ALARMCONFIGURATION table
Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE AlarmLevel='1';
INSERT INTO ALARMCONFIGURATION(AlarmName, AlarmDescription, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('Notification', 'Temp approaching high values', @AlarmLevelId, @TagId, '50','40');
Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE AlarmLevel='2';
INSERT INTO ALARMCONFIGURATION(AlarmName, AlarmDescription, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('Warning', 'Temp is too high', @AlarmLevelId, @TagId, '60','50');
Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE AlarmLevel='3';
INSERT INTO ALARMCONFIGURATION(AlarmName, AlarmDescription, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('Alarm', 'Temp is dangerously high, shut down', @AlarmLevelId, @TagId, '100','60');
Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE AlarmLevel='3';
INSERT INTO ALARMCONFIGURATION(AlarmName, AlarmDescription, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('IOERROR', 'IO Error! Check hardware', @AlarmLevelId, @TagId, '0','0');
Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE AlarmLevel='2';
INSERT INTO ALARMCONFIGURATION(AlarmName, AlarmDescription, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('SystemAlarm', 'System alarm, some text here...', @AlarmLevelId, @TagId, '0','0');

