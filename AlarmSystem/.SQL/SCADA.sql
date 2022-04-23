
CREATE TABLE TAGCONFIGURATION
( 
	TagId                integer  IDENTITY ( 1,1 )  NOT NULL ,
	TagName              varchar(50)  NULL ,
	ItemId               varchar(100)  NULL ,
	ItemUrl              varchar(100)  NULL ,
	Description          varchar(100)  NULL ,
	Unit                 char(18)  NULL ,
	PRIMARY KEY  CLUSTERED (TagId ASC)
)
go

CREATE TABLE TAGDATA
( 
	TagDataId            integer  IDENTITY ( 1,1 )  NOT NULL ,
	Value                float  NULL ,
	Timestamp            datetime  NULL ,
	Status               varchar(20)  NULL ,
	Quality              varchar(20)  NULL ,
	TagId                integer  NULL ,
	PRIMARY KEY  CLUSTERED (TagDataId ASC),
	 FOREIGN KEY (TagId) REFERENCES TAGCONFIGURATION(TagId)
)
go

CREATE TABLE ALARMLEVEL
( 
	AlarmLevelId         integer  IDENTITY ( 1,1 )  NOT NULL ,
	Level                varchar(50)  NULL ,
	Description          varchar(100)  NULL ,
	PRIMARY KEY  CLUSTERED (AlarmLevelId ASC)
)
go

CREATE TABLE ALARMCONFIGURATION
( 
	AlarmConfigurationId integer  IDENTITY ( 1,1 )  NOT NULL ,
	Description          varchar(100)  NULL ,
	Name                 varchar(50)  NULL ,
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
	Name                 varchar(50)  NULL ,
	Title                varchar(50)  NULL ,
	Username             varchar(50)  NULL ,
	PRIMARY KEY  CLUSTERED (PersonId ASC)
)
go

CREATE TABLE ACKNOWLEDGE
( 
	AcknowledgeId        integer  IDENTITY ( 1,1 )  NOT NULL ,
	PersonId             integer  NULL ,
	TimeStamp            datetime  NULL ,
	Status               bit  NULL ,
	PRIMARY KEY  CLUSTERED (AcknowledgeId ASC),
	 FOREIGN KEY (PersonId) REFERENCES PERSON(PersonId)
)
go

CREATE TABLE ALARM
( 
	AlarmId              integer  IDENTITY ( 1,1 )  NOT NULL ,
	AcknowledgeId        integer  NULL ,
	AlarmConfigurationId integer  NULL ,
	TimeStamp            datetime  NULL ,
	Value                float  NULL ,
	PRIMARY KEY  CLUSTERED (AlarmId ASC),
	 FOREIGN KEY (AlarmConfigurationId) REFERENCES ALARMCONFIGURATION(AlarmConfigurationId),
	 FOREIGN KEY (AcknowledgeId) REFERENCES ACKNOWLEDGE(AcknowledgeId)
)
go
