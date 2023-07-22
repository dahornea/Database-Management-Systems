--table A: Lakes, table B: Fishermen
BEGIN TRAN
UPDATE Lakes SET Name= 'Lake Superior' WHERE Lid = 1
WAITFOR DELAY '00:00:10'
UPDATE Fishermen SET FMName= 'John' WHERE Fid = 1
COMMIT TRAN
