DELETE FROM ALARMCONFIGURATION;
DELETE FROM ALARMLEVEL;
Declare @AlarmLevelId int;


-- Updating the ALARMLEVEL table
INSERT INTO ALARMLEVEL(AlarmLevel, AlarmLevelDescription) VALUES ('1', 'Lowest');
INSERT INTO ALARMLEVEL(AlarmLevel, AlarmLevelDescription) VALUES ('2', 'Medium');
INSERT INTO ALARMLEVEL(AlarmLevel, AlarmLevelDescription) VALUES ('3', 'Highest');

-- Updating the ALARMCONFIGURATION table
-- High temperatures
Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE AlarmLevel='2';
INSERT INTO ALARMCONFIGURATION(AlarmName, AlarmDescription, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('Temperature warning', 'Temperature is approaching high values!', @AlarmLevelId, 1, '50','30');
Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE AlarmLevel='3';
INSERT INTO ALARMCONFIGURATION(AlarmName, AlarmDescription, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('Temperature alarm', 'Temperature is too high!', @AlarmLevelId, 1, '100','51');

-- Low Temperatures
Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE AlarmLevel='2';
INSERT INTO ALARMCONFIGURATION(AlarmName, AlarmDescription, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('Temperature warning', 'Temperature is approaching low values!', @AlarmLevelId, 1, '20','10');
Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE AlarmLevel='3';
INSERT INTO ALARMCONFIGURATION(AlarmName, AlarmDescription, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('Temperature alarm', 'Temperature is too low!', @AlarmLevelId, 1, '20','0');

-- Other alarms
Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE AlarmLevel='3';
INSERT INTO ALARMCONFIGURATION(AlarmName, AlarmDescription, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('IOERROR', 'IO Error! Check hardware', @AlarmLevelId, 1, '0','0');
Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE AlarmLevel='1';
INSERT INTO ALARMCONFIGURATION(AlarmName, AlarmDescription, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('Setpoint Notification', 'Setpoint is too low. Please increase setpoint value.', @AlarmLevelId, 3, '20','0');
Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE AlarmLevel='1';
INSERT INTO ALARMCONFIGURATION(AlarmName, AlarmDescription, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('Setpoint Notification', 'Setpoint is too high. Please decrease setpoint value.', @AlarmLevelId, 3, '100','50');

Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE AlarmLevel='3';
INSERT INTO ALARMCONFIGURATION(AlarmName, AlarmDescription, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('System Error!', 'Communication error between control system and datalogging.', @AlarmLevelId, 5, '0','0');

