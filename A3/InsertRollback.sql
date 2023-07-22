CREATE OR ALTER PROCEDURE addRowFishRecover @Species varchar(50) AS
BEGIN 
        SET NOCOUNT ON
        BEGIN TRAN
        BEGIN TRY
            DECLARE @maxId INT
            SET @maxId = 1
            SELECT TOP 1 @maxId = Fid + 1 FROM Fish ORDER BY Fid DESC
            DECLARE @error VARCHAR(max)
            SET @error = ''
            IF(@Species IS NULL)
            BEGIN
                SET @error = 'Species cannot be null'
                RAISERROR('Species cannot be null', 16, 1)
            END
            INSERT INTO Fish VALUES(@maxId, @Species)
            EXEC sp_log_changes '', @Species, 'Add row to fish', @error
            COMMIT TRAN
        END TRY
        BEGIN CATCH
            ROLLBACK TRAN
            EXEC sp_log_changes '', '', 'rolled back fish data', ''
        END CATCH
END

GO
CREATE OR ALTER PROCEDURE addRowFishTanksRecover @Name varchar(50), @Quantity INT, @No_Of_Fish INT AS
BEGIN
        SET NOCOUNT ON
        BEGIN TRAN 
        BEGIN TRY
                DECLARE @maxId INT
                SET @maxId = 1
                SELECT TOP 1 @maxId = FTid + 1 FROM FishTanks ORDER BY FTid DESC
                DECLARE @error VARCHAR(max)
                SET @error = ''
                IF(@Name IS NULL)
                BEGIN
                    SET @error = 'Name cannot be null'
                    RAISERROR('Name cannot be null', 16, 1)
                END
                IF(@Quantity < 0)
                BEGIN
                    SET @error = 'Quantity cannot be negative'
                    RAISERROR('Quantity cannot be negative', 16, 1)
                END
                IF(@No_Of_Fish < 0)
                BEGIN
                    SET @error = 'Number of fish cannot be negative'
                    RAISERROR('Number of fish cannot be negative', 16, 1)
                END
                INSERT INTO FishTanks VALUES(@maxId, @Name, @Quantity, @No_Of_Fish)
                EXEC sp_log_changes '', @Name, 'Add row to fish tanks', @error
                COMMIT TRAN
        END TRY
        BEGIN CATCH
                ROLLBACK TRAN
                EXEC sp_log_changes '', '', 'rolled back fish tanks data', ''
        END CATCH
END

GO
CREATE OR ALTER PROCEDURE addRowFishInFishTanksRecover AS
BEGIN 
        SET NOCOUNT ON
        BEGIN TRAN
        BEGIN TRY
                DECLARE @maxId INT
                SET @maxId = 1
                SELECT TOP 1 @maxId = Fid + 1 FROM FishInFishTanks ORDER BY Fid DESC
                DECLARE @error VARCHAR(max)
                SET @error = ''
                INSERT INTO FishInFishTanks VALUES(@maxId, 1, 1)
                EXEC sp_log_changes '', '1', 'Add row to fish in fish tanks', @error
                COMMIT TRAN
        END TRY
        BEGIN CATCH
                ROLLBACK TRAN
                EXEC sp_log_changes '', '', 'rolled back fish in fish tanks data', ''
        END CATCH
END

GO
CREATE OR ALTER PROCEDURE successfulAddRollback AS
BEGIN
        BEGIN TRAN
        BEGIN TRY
                EXEC addRowFishRecover 'Goldfish'
                EXEC addRowFishTanksRecover 'Tank1', 10, 5
                EXEC addRowFishInFishTanksRecover
        END TRY
        BEGIN CATCH
                ROLLBACK TRAN
                EXEC sp_log_changes '', '', 'rolled back all data', ''
                RETURN
        END CATCH
        COMMIT TRAN
END

GO 
CREATE OR ALTER PROCEDURE failAddRollback AS
BEGIN
        BEGIN TRAN
        BEGIN TRY
                EXEC addRowFishRecover 'Goldfish'
                EXEC addRowFishTanksRecover 'Tank1', 10, 5
                EXEC addRowFishInFishTanksRecover
        END TRY
        BEGIN CATCH
                ROLLBACK TRAN
                EXEC sp_log_changes '', '', 'rolled back all data', ''
                RETURN
        END CATCH
        COMMIT TRAN
END

EXEC successfulAddRollback
EXEC failAddRollback

