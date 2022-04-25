/*
	setup of TAGCONFIGURATION table

	Last updated 24/04/2022
*/

-- Remove earlier configuration
DELETE FROM TAGCONFIGURATION;

INSERT INTO 
	TAGCONFIGURATION (TagName, ItemId, ItemUrl, TagDescription, TagUnit)
VALUES
	('tagRealProcessValue',			'ns=2;s=Tag1', 'opc.tcp://localhost:62640/', 'Real Process Value in C ',						'C'),
	('tagSimProcessValue',			'ns=2;s=Tag2', 'opc.tcp://localhost:62640/', 'Simulated Process Value in C ',					'C'),
	('tagSetpoint',					'ns=2;s=Tag3', 'opc.tcp://localhost:62640/', 'Setpoint in C',									'C'),
	('tagControlValue',				'ns=2;s=Tag4', 'opc.tcp://localhost:62640/', 'Control value',									'V'),
	('tagConnectedRandomNumbers',	'ns=2;s=Tag5', 'opc.tcp://localhost:62640/', 'Random string of letters updated every cycle',	' '),
	('tagIOError',					'ns=2;s=Tag6', 'opc.tcp://localhost:62640/', 'I/O Status',	  									'C');
