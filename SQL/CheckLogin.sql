CREATE PROC CheckLogin
@username nvarchar(128),
@password nvarchar(max)
AS
BEGIN
	SELECT UserName
	FROM Users 
	WHERE UserName=@username 
	AND PassWord=@password
END