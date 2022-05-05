DELETE FROM PERSON
DELETE FROM ACKNOWLEDGE

-- Updating The PERSON table
INSERT INTO PERSON(PersonName, PersonTitle, PersonUsername) VALUES ('Henrik', 'Engineer', '251247');

-- Update ACKNOWLEDGE table
Declare @PersonId int;
Select @PersonId = PersonId FROM PERSON WHERE PersonName = 'Henrik';
INSERT INTO ACKNOWLEDGE(PersonId, AckTimeStamp, AckStatus) VALUES (@PersonId, CURRENT_TIMESTAMP, '0');
INSERT INTO ACKNOWLEDGE(PersonId, AckTimeStamp, AckStatus) VALUES (@PersonId, CURRENT_TIMESTAMP, '1');