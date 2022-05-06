USE SCADADB
GO

DROP TABLE ALARM;
DROP TABLE ACKNOWLEDGE;
DROP TABLE PERSON;
DROP TABLE ALARMCONFIGURATION;
DROP TABLE ALARMLEVEL;
DROP TABLE TAGDATA;
DROP TABLE TAGCONFIGURATION;
GO

CREATE TABLE TAGCONFIGURATION
( 
	TagId                integer  IDENTITY ( 1,1 )  NOT NULL ,
	TagName              varchar(50)  NULL ,
	ItemId               varchar(100)  NULL ,
	ItemUrl              varchar(100)  NULL ,
	TagDescription       varchar(100)  NULL ,
	TagUnit              varchar(50)  NULL ,
	PRIMARY KEY  CLUSTERED (TagId ASC)
)
go

CREATE TABLE TAGDATA
( 
	TagDataId            integer  IDENTITY ( 1,1 )  NOT NULL ,
	TagValue             float  NULL ,
	TagTimestamp         datetime  NULL ,
	TagStatus            varchar(50)  NULL ,
	TagId                integer  NULL ,
	PRIMARY KEY  CLUSTERED (TagDataId ASC),
	 FOREIGN KEY (TagId) REFERENCES TAGCONFIGURATION(TagId)
)
go

CREATE TABLE ALARMLEVEL
( 
	AlarmLevelId         integer  IDENTITY ( 1,1 )  NOT NULL ,
	AlarmLevel           varchar(50)  NULL ,
	AlarmLevelDescription varchar(100)  NULL ,
	PRIMARY KEY  CLUSTERED (AlarmLevelId ASC)
)
go

CREATE TABLE ALARMCONFIGURATION
( 
	AlarmConfigurationId integer  IDENTITY ( 1,1 )  NOT NULL ,
	AlarmDescription     varchar(100)  NULL ,
	AlarmName            varchar(50)  NULL ,
	AlarmLevelId         integer  NULL ,
	AlarmUpperLimit      float  NULL ,
	TagId                integer  NULL ,
	AlarmLowerLimit      float  NULL ,
	PRIMARY KEY  CLUSTERED (AlarmConfigurationId ASC),
	 FOREIGN KEY (AlarmLevelId) REFERENCES ALARMLEVEL(AlarmLevelId),
	 FOREIGN KEY (TagId) REFERENCES TAGCONFIGURATION(TagId)
)
go

CREATE TABLE PERSON
( 
	PersonId             integer  IDENTITY ( 1,1 )  NOT NULL ,
	PersonName           varchar(50)  NULL ,
	PersonTitle          varchar(50)  NULL ,
	PersonUsername       varchar(50)  NULL ,
	PersonPassword		 varchar(50)  NULL ,
	PRIMARY KEY  CLUSTERED (PersonId ASC)
)
go

CREATE TABLE ACKNOWLEDGE
( 
	AcknowledgeId        integer  IDENTITY ( 1,1 )  NOT NULL ,
	PersonId             integer  NULL ,
	AckTimeStamp         datetime  NULL ,
	AckStatus            bit  NULL ,
	PRIMARY KEY  CLUSTERED (AcknowledgeId ASC),
	 FOREIGN KEY (PersonId) REFERENCES PERSON(PersonId)
)
go

CREATE TABLE ALARM
( 
	AlarmId              integer  IDENTITY ( 1,1 )  NOT NULL ,
	AcknowledgeId        integer  NULL ,
	AlarmConfigurationId integer  NULL ,
	AlarmTimeStamp       datetime  NULL ,
	Value                float  NULL ,
	AckTimeStamp         datetime  NULL ,
	PRIMARY KEY  CLUSTERED (AlarmId ASC),
	 FOREIGN KEY (AlarmConfigurationId) REFERENCES ALARMCONFIGURATION(AlarmConfigurationId),
	 FOREIGN KEY (AcknowledgeId) REFERENCES ACKNOWLEDGE(AcknowledgeId)
)
go

-----------------VIEWS-----------------
IF EXISTS (SELECT name FROM sysobjects WHERE name = 'GetAlarmConfigurations' AND type = 'V')
DROP VIEW GetAlarmConfigurations
GO

CREATE VIEW GetAlarmConfigurations
AS
SELECT
ALARMCONFIGURATION.AlarmConfigurationId,
ALARMCONFIGURATION.AlarmName,
ALARMCONFIGURATION.AlarmDescription,
ALARMCONFIGURATION.AlarmLowerLimit,
ALARMCONFIGURATION.AlarmUpperLimit,
ALARMLEVEL.AlarmLevel,
TAGCONFIGURATION.TagName
FROM ALARMCONFIGURATION
INNER JOIN ALARMLEVEL ON ALARMCONFIGURATION.AlarmLevelId = ALARMLEVEL.AlarmLevelId
INNER JOIN TAGCONFIGURATION ON ALARMCONFIGURATION.TagId = TAGCONFIGURATION.TagId
go
---------------------------------------
IF EXISTS (SELECT name FROM sysobjects WHERE name = 'GetAlarmHistory' AND type = 'V')
DROP VIEW GetAlarmHistory
GO
CREATE VIEW GetAlarmHistory
AS
SELECT
ALARM.AlarmId,
ALARMCONFIGURATION.AlarmName,
ALARMCONFIGURATION.AlarmDescription,
ALARM.AlarmTimeStamp,
ALARM.Value,
ALARM.AckTimeStamp,
ALARMLEVEL.AlarmLevel,
TAGCONFIGURATION.TagUnit,
PERSON.PersonName
FROM ALARM
INNER JOIN ALARMCONFIGURATION ON ALARM.AlarmConfigurationId = ALARMCONFIGURATION.AlarmConfigurationId
INNER JOIN ALARMLEVEL ON ALARMCONFIGURATION.AlarmLevelId = ALARMLEVEL.AlarmLevelId
INNER JOIN TAGCONFIGURATION ON ALARMCONFIGURATION.TagId = TAGCONFIGURATION.TagId
INNER JOIN ACKNOWLEDGE ON ALARM.AcknowledgeId = ACKNOWLEDGE.AcknowledgeId
INNER JOIN PERSON ON ACKNOWLEDGE.PersonId = PERSON.PersonId
go
---------------------------------------
IF EXISTS (SELECT name FROM sysobjects WHERE name = 'GetAlarms' AND type = 'V')
DROP VIEW GetAlarms
GO
CREATE VIEW GetAlarms
AS
SELECT
ALARM.AlarmId,
ALARMCONFIGURATION.AlarmName,
ALARMCONFIGURATION.AlarmDescription,
ALARMCONFIGURATION.AlarmConfigurationId,
ALARM.AlarmTimeStamp,
ALARM.Value,
ACKNOWLEDGE.AckStatus,
ALARMLEVEL.AlarmLevel,
TAGCONFIGURATION.TagUnit
FROM ALARM
INNER JOIN ALARMCONFIGURATION ON ALARM.AlarmConfigurationId = ALARMCONFIGURATION.AlarmConfigurationId
INNER JOIN ACKNOWLEDGE ON ALARM.AcknowledgeId = ACKNOWLEDGE.AcknowledgeId
INNER JOIN ALARMLEVEL ON ALARMCONFIGURATION.AlarmLevelId = ALARMLEVEL.AlarmLevelId
INNER JOIN TAGCONFIGURATION ON ALARMCONFIGURATION.TagId = TAGCONFIGURATION.TagId
WHERE ACKNOWLEDGE.AckStatus = 0
go

---------------------------------------
IF EXISTS (SELECT name FROM sysobjects WHERE name = 'GetTagConfigurations' AND type = 'V')
DROP VIEW GetTagConfigurations
GO
CREATE VIEW GetTagConfigurations
AS
SELECT 
TAGDATA.TagDataId,
TAGDATA.TagValue,
TAGDATA.TagStatus,
TAGDATA.TagTimestamp,
TAGCONFIGURATION.TagId,
TAGCONFIGURATION.TagName
FROM TAGDATA
INNER JOIN TAGCONFIGURATION ON TAGDATA.TagId = TAGCONFIGURATION.TagId
go
-----------------STORED PROCEDURES-----------------
IF EXISTS (SELECT name FROM sysobjects WHERE name = 'AcknowledgeAlarm' AND type = 'P')
DROP PROCEDURE AcknowledgeAlarm
GO

CREATE PROCEDURE AcknowledgeAlarm
@AlarmId int
AS

update ALARM SET 
AcknowledgeId = 2
where AlarmId = @AlarmId
GO
---------------------------------------------------
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

---------------------------------------------------
IF EXISTS (SELECT name FROM sysobjects WHERE name = 'CreateAlarmConfiguration' AND type = 'P')
DROP PROCEDURE CreateAlarmConfiguration
GO

CREATE PROCEDURE CreateAlarmConfiguration
@AlarmName varchar(50),
@AlarmDescription varchar(100),
@AlarmLevel varchar(50),
@TagName varchar(50),
@AlarmLowerLimit float,
@AlarmUpperLimit float
AS

if not exists (select * from ALARMLEVEL where AlarmLevel = @AlarmLevel)
INSERT INTO ALARMLEVEL (AlarmLevel) VALUES (@AlarmLevel)

if not exists (select * from TAGCONFIGURATION where TagName = @TagName)
INSERT INTO TAGCONFIGURATION (TagName) VALUES (@TagName)

if not exists (select * from ALARMCONFIGURATION where AlarmName = @AlarmName)
INSERT INTO ALARMCONFIGURATION (AlarmName, AlarmDescription, AlarmLowerLimit, AlarmUpperLimit, AlarmLevelId, TagId) 
VALUES (
@AlarmName,
@AlarmDescription,
@AlarmLowerLimit,
@AlarmUpperLimit,
(select AlarmLevelId from ALARMLEVEL where AlarmLevel=@AlarmLevel),
(select TagId from TAGCONFIGURATION where TagName=@TagName)
)
GO

---------------------------------------------------
IF EXISTS (SELECT name FROM sysobjects WHERE name = 'DeleteAlarmConfiguration' AND type = 'P')
DROP PROCEDURE DeleteAlarmConfiguration
GO

CREATE PROCEDURE DeleteAlarmConfiguration
@AlarmConfigurationId int
AS

delete from ALARMCONFIGURATION where AlarmConfigurationId=@AlarmConfigurationId
GO

---------------------------------------------------
IF EXISTS (SELECT Name FROM SYSOBJECTS WHERE Name = 'SaveTagData' AND Type = 'P')
DROP PROCEDURE SaveTagData
GO

CREATE PROCEDURE SaveTagData
@TagName varchar(50),
@TagValue float,
@TagStatus varchar(20)
AS

DECLARE
@TagId int

SELECT @TagId = TagId FROM TAGCONFIGURATION WHERE TagName = @TagName

INSERT INTO TAGDATA 
	(TagValue, TagTimestamp, TagStatus, TagId) 
VALUES
	(@TagValue, GETDATE(), @TagStatus, @TagId) 
GO

---------------------------------------------------
IF EXISTS (SELECT name FROM sysobjects WHERE name = 'SP_TriggerAlarms' AND type = 'P')
DROP PROCEDURE SP_TriggerAlarms
GO

CREATE PROCEDURE SP_TriggerAlarms
@TagValue float,
@AlarmConfigurationId int
AS

DECLARE
@AlarmLowerLimit float,
@AlarmUpperLimit float,
@AlarmName varchar(50),
@AlarmExist int

select @AlarmLowerLimit = AlarmLowerLimit from ALARMCONFIGURATION where AlarmConfigurationId=@AlarmConfigurationId
select @AlarmUpperLimit = AlarmUpperLimit from ALARMCONFIGURATION where AlarmConfigurationId=@AlarmConfigurationId
select @AlarmName = AlarmName from ALARMCONFIGURATION where AlarmConfigurationId=@AlarmConfigurationId
select @AlarmExist = COUNT(AlarmConfigurationId) from GetAlarms where AlarmConfigurationId = @AlarmConfigurationId

IF((@TagValue BETWEEN @AlarmLowerLimit AND @AlarmUpperLimit) AND (@AlarmExist<1) )
	INSERT INTO ALARM(AlarmTimeStamp, Value, AcknowledgeId, AlarmConfigurationId)
	VALUES(
	CURRENT_TIMESTAMP,
	@TagValue,
	(select AcknowledgeId from ACKNOWLEDGE where AckStatus=0),
	@AlarmConfigurationId
	)
GO

---------------------------------------------------
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

---------------------------------------------------
IF EXISTS (SELECT name FROM sysobjects WHERE name = 'UpdateAlarmConfiguration' AND type = 'P')
DROP PROCEDURE UpdateAlarmConfiguration
GO

CREATE PROCEDURE UpdateAlarmConfiguration
@AlarmConfigurationId int,
@AlarmName varchar(50),
@AlarmDescription varchar(100),
@AlarmLevel varchar(50),
@TagName varchar(50),
@AlarmLowerLimit float,
@AlarmUpperLimit float
AS

if not exists (select * from ALARMLEVEL where AlarmLevel = @AlarmLevel)
INSERT INTO ALARMLEVEL (AlarmLevel) VALUES (@AlarmLevel)

if not exists (select * from TAGCONFIGURATION where TagName = @TagName)
INSERT INTO TAGCONFIGURATION (TagName) VALUES (@TagName)

UPDATE ALARMCONFIGURATION SET
AlarmName = @AlarmName,
AlarmDescription = @AlarmDescription,
AlarmLowerLimit = @AlarmLowerLimit,
AlarmUpperLimit = @AlarmUpperLimit,
AlarmLevelId = (select AlarmLevelId from ALARMLEVEL where AlarmLevel=@AlarmLevel),
TagId = (select TagId from TAGCONFIGURATION where TagName=@TagName)
WHERE AlarmConfigurationId = @AlarmConfigurationId
GO

-----------------TRIGGERS-----------------
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
@AlarmValue float,
@Acknowledged bit

select @AlarmId = AlarmId from INSERTED
select @AcknowledgeId = AcknowledgeId from INSERTED
select @AlarmConfigurationId = AlarmConfigurationId from INSERTED
select @AlarmTimeStamp = AlarmTimeStamp from INSERTED
select @AlarmValue = Value from INSERTED
select @Acknowledged = AckStatus from ACKNOWLEDGE where @AcknowledgeId = AcknowledgeId

IF(@Acknowledged=1)
	INSERT INTO ALARM(AcknowledgeId, AlarmConfigurationId, AlarmTimeStamp, Value, AckTimeStamp)
	VALUES(@AcknowledgeId,@AlarmConfigurationId, @AlarmTimeStamp, @AlarmValue, CURRENT_TIMESTAMP)
GO

---------------------------------------------------
IF EXISTS (SELECT name FROM sysobjects WHERE name='TriggerAlarmIO' AND type='TR')
DROP TRIGGER TriggerAlarmIO
GO

CREATE TRIGGER TriggerAlarmIO ON TAGDATA
FOR UPDATE, INSERT, DELETE
AS

DECLARE
-- Input values
@TagId int,
@TagValue float,
@AlarmExist int,
@AlarmConfigurationId int

select @TagId = TagId from INSERTED
select @TagValue = TagValue from INSERTED
select @AlarmConfigurationId = 5
select @AlarmExist = COUNT(AlarmConfigurationId) from GetAlarms where AlarmConfigurationId = @AlarmConfigurationId


IF((@TagId = 1 and @TagValue < 0) AND (@AlarmExist<1))
	INSERT INTO ALARM(AlarmTimeStamp, Value, AcknowledgeId, AlarmConfigurationId)
	VALUES(
	CURRENT_TIMESTAMP,
	@TagValue,
	(select AcknowledgeId from ACKNOWLEDGE where AckStatus=0),
	@AlarmConfigurationId
	)
GO

---------------------------------------------------
IF EXISTS (SELECT name FROM sysobjects WHERE name='TriggerAlarmSystem' AND type='TR')
DROP TRIGGER TriggerAlarmSystem
GO

CREATE TRIGGER TriggerAlarmSystem ON TAGDATA
FOR UPDATE, INSERT, DELETE
AS

DECLARE
-- Input values
@TagId int,
@TagValue float,
@AlarmExist int,
@AlarmConfigurationId int

select @TagId = TagId from INSERTED
select @TagValue = TagValue from INSERTED
select @AlarmConfigurationId = 8
select @AlarmExist = COUNT(AlarmConfigurationId) from GetAlarms where AlarmConfigurationId = @AlarmConfigurationId


IF((@TagValue < 0 AND @TagId = 5) AND (@AlarmExist < 1))
	INSERT INTO ALARM(AlarmTimeStamp, Value, AcknowledgeId, AlarmConfigurationId)
	VALUES(
	CURRENT_TIMESTAMP,
	@TagValue,
	(select AcknowledgeId from ACKNOWLEDGE where AckStatus=0),
	@AlarmConfigurationId
	)
GO

---------------------------------------------------
IF EXISTS (SELECT name FROM sysobjects WHERE name='TriggerTempAlarms' AND type='TR')
DROP TRIGGER TriggerTempAlarms
GO

CREATE TRIGGER TriggerTempAlarms ON TAGDATA
FOR UPDATE, INSERT
AS

BEGIN
DECLARE
@TagId int,
@TagValue float

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

---------------------------------------------------
IF EXISTS (SELECT name FROM sysobjects WHERE name='TriggerSystemManualMode' AND type='TR')
DROP TRIGGER TriggerSystemManualMode
GO

CREATE TRIGGER TriggerSystemManualMode ON TAGDATA
FOR UPDATE, INSERT, DELETE
AS

DECLARE
-- Input values
@TagId int,
@TagValue float,
@AlarmConfigurationId int,
@AlarmExist int

select @TagId = TagId from INSERTED
select @TagValue = TagValue from INSERTED
select @AlarmConfigurationId = 9
select @AlarmExist = COUNT(AlarmConfigurationId) from GetAlarms where AlarmConfigurationId = @AlarmConfigurationId

IF((@TagValue < 0 AND @TagId = 6) AND (@AlarmExist < 1))
	INSERT INTO ALARM(AlarmTimeStamp, Value, AcknowledgeId, AlarmConfigurationId)
	VALUES(
	CURRENT_TIMESTAMP,
	@TagValue,
	(select AcknowledgeId from ACKNOWLEDGE where AckStatus=0),
	@AlarmConfigurationId
	)
GO

------------------CONFIGURATIONS------------------
-- Remove earlier configuration
DELETE FROM TAGCONFIGURATION;
GO

INSERT INTO 
	TAGCONFIGURATION (TagName, ItemId, ItemUrl, TagDescription, TagUnit)
VALUES
	('tagRealProcessValue',			'ns=2;s=Tag1', 'opc.tcp://localhost:62640/', 'Real Process Value in C ',						'C'),
	('tagSimProcessValue',			'ns=2;s=Tag2', 'opc.tcp://localhost:62640/', 'Simulated Process Value in C ',					'C'),
	('tagSetpoint',					'ns=2;s=Tag3', 'opc.tcp://localhost:62640/', 'Setpoint in C',									'C'),
	('tagControlValue',				'ns=2;s=Tag4', 'opc.tcp://localhost:62640/', 'Control value',									'V'),
	('tagControlSystemOnlineVerification',	'ns=2;s=Tag5', 'opc.tcp://localhost:62640/', 'Random string of letters updated every cycle',	' '),
	('tagAutomatic',					'ns=2;s=Tag6', 'opc.tcp://localhost:62640/', 'I/O Status',	  									'C');

---------------------------------------------------
-- Remove earlier configuration
DELETE FROM ALARMCONFIGURATION;
DELETE FROM ALARMLEVEL;
Declare @AlarmLevelId int;


-- Updating the ALARMLEVEL table
INSERT INTO ALARMLEVEL(AlarmLevel, AlarmLevelDescription) VALUES ('Notification', 'Lowest');
INSERT INTO ALARMLEVEL(AlarmLevel, AlarmLevelDescription) VALUES ('Warning', 'Medium');
INSERT INTO ALARMLEVEL(AlarmLevel, AlarmLevelDescription) VALUES ('Alarm', 'Highest');

-- Updating the ALARMCONFIGURATION table
-- High temperatures
Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE AlarmLevel='Warning';
INSERT INTO ALARMCONFIGURATION(AlarmName, AlarmDescription, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('Temperature warning', 'Temperature is approaching high values!', @AlarmLevelId, 1, '50','35');
Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE AlarmLevel='Alarm';
INSERT INTO ALARMCONFIGURATION(AlarmName, AlarmDescription, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('Temperature alarm', 'Temperature is too high!', @AlarmLevelId, 1, '100','51');

-- Low Temperatures
Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE AlarmLevel='Warning';
INSERT INTO ALARMCONFIGURATION(AlarmName, AlarmDescription, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('Temperature warning', 'Temperature is approaching low values!', @AlarmLevelId, 1, '20','10');
Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE AlarmLevel='Alarm';
INSERT INTO ALARMCONFIGURATION(AlarmName, AlarmDescription, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('Temperature alarm', 'Temperature is too low!', @AlarmLevelId, 1, '9','0');

-- Other alarms
Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE AlarmLevel='Alarm';
INSERT INTO ALARMCONFIGURATION(AlarmName, AlarmDescription, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('I/O ERROR!', 'IO Error! Check hardware', @AlarmLevelId, 1, '0','0');
Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE AlarmLevel='Notification';
INSERT INTO ALARMCONFIGURATION(AlarmName, AlarmDescription, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('Setpoint Notification', 'Setpoint is too low. Please increase setpoint value.', @AlarmLevelId, 3, '15','0');
Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE AlarmLevel='Notification';
INSERT INTO ALARMCONFIGURATION(AlarmName, AlarmDescription, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('Setpoint Notification', 'Setpoint is too high. Please decrease setpoint value.', @AlarmLevelId, 3, '100','51');

Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE AlarmLevel='Alarm';
INSERT INTO ALARMCONFIGURATION(AlarmName, AlarmDescription, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('System Error!', 'Communication error between control system and datalogging.', @AlarmLevelId, 5, '0','0');

Select @AlarmLevelId = AlarmLevelId FROM ALARMLEVEL WHERE AlarmLevel='Notification';
INSERT INTO ALARMCONFIGURATION(AlarmName, AlarmDescription, AlarmLevelId, TagId, AlarmUpperLimit, AlarmLowerLimit) VALUES ('Manual mode', 'System is set to manual mode.', @AlarmLevelId, 6, '0','0');

---------------------------------------------------
DELETE FROM PERSON
DELETE FROM ACKNOWLEDGE

-- Updating The PERSON table
INSERT INTO PERSON(PersonName, PersonTitle, PersonUsername, PersonPassword) VALUES ('Operator', 'Operator', 'operator', '1');

-- Update ACKNOWLEDGE table
Declare @PersonId int;
Select @PersonId = PersonId FROM PERSON WHERE PersonName = 'Operator';
INSERT INTO ACKNOWLEDGE(PersonId, AckTimeStamp, AckStatus) VALUES (@PersonId, CURRENT_TIMESTAMP, '0');
INSERT INTO ACKNOWLEDGE(PersonId, AckTimeStamp, AckStatus) VALUES (@PersonId, CURRENT_TIMESTAMP, '1');