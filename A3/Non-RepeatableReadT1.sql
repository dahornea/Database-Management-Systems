INSERT INTO Fishermen VALUES (1, 'John', 100, 1, 1)
BEGIN TRAN
WAITFOR DELAY '00:00:10'
UPDATE Fishermen SET FMName= 'Johnny' WHERE Fid = 1
COMMIT TRAN

INSERT INTO Fishermen VALUES (2, 'Jane', 100, 1, 1)
BEGIN TRAN
WAITFOR DELAY '00:00:10'
UPDATE Fishermen SET FMName= 'Janet' WHERE Fid = 2
COMMIT TRAN