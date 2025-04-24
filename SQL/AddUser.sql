CREATE PROCEDURE AddUser
    @displayName NVARCHAR(100),
    @userName NVARCHAR(100),
    @password NVARCHAR(MAX),
    @idUserRole INT
AS
BEGIN
    -- Tắt NOCOUNT nếu đang bật
    SET NOCOUNT OFF;

    BEGIN TRY
        INSERT INTO Users (DisplayName, UserName, Password, IdUserRole)
        VALUES (@displayName, @userName, @password, @idUserRole);

        RETURN @@ROWCOUNT; -- Trả về số dòng bị ảnh hưởng
    END TRY
    BEGIN CATCH
        -- Xử lý lỗi nếu có
        THROW;
    END CATCH
END;