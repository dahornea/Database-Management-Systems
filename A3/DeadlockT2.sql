--table A: Lakes, table B: Fishermen
-- SET DEADLOCK_PRIORITY HIGH
BEGIN TRAN
UPDATE Fishermen SET FMName= 'John' WHERE Fid = 1
WAITFOR DELAY '00:00:10'
UPDATE Lakes SET Name= 'Lake Superior' WHERE Lid = 1
COMMIT TRAN