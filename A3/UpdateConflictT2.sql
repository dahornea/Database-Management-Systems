SET TRAN ISOLATION LEVEL SNAPSHOT
BEGIN TRAN
WAITFOR DELAY '00:00:05'
-- T1 has updated and has a lock on the row
-- T2 will wait for the lock to be released
UPDATE Fishermen SET Name = 'John' WHERE Fid = 4
COMMIT TRAN