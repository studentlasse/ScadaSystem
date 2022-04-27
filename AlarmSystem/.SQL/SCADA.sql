
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
	TagStatus            varchar(20)  NULL ,
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
