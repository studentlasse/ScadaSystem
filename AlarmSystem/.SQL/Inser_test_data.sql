DELETE FROM ALARM;
DELETE FROM ALARMCONFIGURATION;
DELETE FROM ALARMLEVEL;
DELETE FROM ACKNOWLEDGE;
DELETE FROM PERSON;
DELETE FROM TAGCONFIGURATION;
DELETE FROM TAGDATA;

-- Updating the ALARMLEVEL table
INSERT INTO ALARMLEVEL(Level, Description) VALUES ('1', 'Lowest');
INSERT INTO ALARMLEVEL(Level, Description) VALUES ('2', 'Medium');
INSERT INTO ALARMLEVEL(Level, Description) VALUES ('3', 'Highest');

-- Updating the TAGCONFIGURATION table
INSERT INTO TAGCONFIGURATION(TagName, ItemId, ItemUrl, Description, Unit) VALUES ('OPC Server', '1', 'localhost', 'Data source, opc server', 'Celsius');

-- Updating the TAGDATA table
Declare @TagId int
SELECT @TagId = TagId FROM TAGCONFIGURATION WHERE TagName = 'OPC Server';
INSERT INTO TAGDATA(Value, Timestamp, Status, Quality, TagDataId) VALUES ('42', CURRENT_TIMESTAMP, 'status', 'quality', @TagId);
INSERT INTO TAGDATA(Value, Timestamp, Status, Quality, TagDataId) VALUES ('47', CURRENT_TIMESTAMP, 'status2', 'quality2', @TagId);
INSERT INTO TAGDATA(Value, Timestamp, Status, Quality, TagDataId) VALUES ('54', CURRENT_TIMESTAMP, 'status3', 'quality3', @TagId);
INSERT INTO TAGDATA(Value, Timestamp, Status, Quality, TagDataId) VALUES ('63', CURRENT_TIMESTAMP, 'status4', 'quality4', @TagId);

-- Updating The PERSON table
INSERT INTO PERSON(Name, Title, Username) VALUES ('Henrik', 'Engineer', '251247');

-- Updating the ACKNOWLEDGE table
Declare @PersonId int;
Select @PersonId = PersonId FROM PERSON WHERE Name = 'Henrik';
INSERT INTO ACKNOWLEDGE(PersonId, TimeStamp, Status) VALUES (@PersonId, CURRENT_TIMESTAMP, '0');
INSERT INTO ACKNOWLEDGE(PersonId, TimeStamp, Status) VALUES (@PersonId, CURRENT_TIMESTAMP, '1');

-- Updating the ALARMCONFIGURATION table
-- Fetching AlarmLevelId (3x) and TagId (already defined):
Declare @AlarmLevelId int;

Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE Level='Lowest';
INSERT INTO ALARMCONFIGURATION(Name, Description, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('Notification', 'Temp approaching high values', @AlarmLevelId, @TagId, '50','40');
Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE Level='Medium';
INSERT INTO ALARMCONFIGURATION(Name, Description, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('Warning', 'Temp is too high', @AlarmLevelId, @TagId, '60','50');
Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE Level='Highest';
INSERT INTO ALARMCONFIGURATION(Name, Description, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('Alarm', 'Temp is dangerously high, shut down', @AlarmLevelId, @TagId, '100','60');

-- Updating the ALARM table
Declare @AcknowledgeId int;
Declare @AlarmConfigurationId int;

Select @AcknowledgeId = AcknowledgeId FROM ACKNOWLEDGE WHERE Status='0';
Select @AlarmConfigurationId = @AlarmConfigurationId FROM ALARMCONFIGURATION WHERE Name='Notification';
INSERT INTO ALARM(AlarmConfigurationId, AcknowledgeId, TimeStamp, Value) VALUES (@AlarmConfigurationId, @AcknowledgeId, CURRENT_TIMESTAMP, '42');
INSERT INTO ALARM(AlarmConfigurationId, AcknowledgeId, TimeStamp, Value) VALUES (@AlarmConfigurationId, @AcknowledgeId, CURRENT_TIMESTAMP, '47');
Select @AlarmConfigurationId = @AlarmConfigurationId FROM ALARMCONFIGURATION WHERE Name='Warning';
INSERT INTO ALARM(AlarmConfigurationId, AcknowledgeId, TimeStamp, Value) VALUES (@AlarmConfigurationId, @AcknowledgeId, CURRENT_TIMESTAMP, '54');
Select @AlarmConfigurationId = @AlarmConfigurationId FROM ALARMCONFIGURATION WHERE Name='Alarm';
INSERT INTO ALARM(AlarmConfigurationId, AcknowledgeId, TimeStamp, Value) VALUES (@AlarmConfigurationId, @AcknowledgeId, CURRENT_TIMESTAMP, '63');

-- Updating the ALARMHISTORY table
Select @AcknowledgeId = AcknowledgeId FROM ACKNOWLEDGE WHERE Status='1';

Select @AlarmConfigurationId = @AlarmConfigurationId FROM ALARMCONFIGURATION WHERE Name='Notification';
INSERT INTO ALARMHISTORY(AlarmConfigurationId, AcknowledgeId, TimeStamp, AckTimeStamp, Value) VALUES (@AlarmConfigurationId, @AcknowledgeId, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, '41');
INSERT INTO ALARMHISTORY(AlarmConfigurationId, AcknowledgeId, TimeStamp, AckTimeStamp, Value) VALUES (@AlarmConfigurationId, @AcknowledgeId, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, '43');
Select @AlarmConfigurationId = @AlarmConfigurationId FROM ALARMCONFIGURATION WHERE Name='Warning';
INSERT INTO ALARMHISTORY(AlarmConfigurationId, AcknowledgeId, TimeStamp, AckTimeStamp, Value) VALUES (@AlarmConfigurationId, @AcknowledgeId, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, '56');
Select @AlarmConfigurationId = @AlarmConfigurationId FROM ALARMCONFIGURATION WHERE Name='Alarm';
INSERT INTO ALARMHISTORY(AlarmConfigurationId, AcknowledgeId, TimeStamp, AckTimeStamp, Value) VALUES (@AlarmConfigurationId, @AcknowledgeId, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, '61');
