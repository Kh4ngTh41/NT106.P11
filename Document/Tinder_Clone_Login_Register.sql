
alter procedure Tinder_Clone_Login_Register
	@userName nvarchar(50),
	@pass nvarchar(254),
	@fullName nvarchar(200),
	@gender int
AS
Begin
if exists(select 1 from USER_LIST where [username] = @username)
Begin
	select 'Da ton tai ten dang nhap'
	return
End
Insert INTO USER_LIST Values (@username,@pass,@fullname,@gender)
select ''
END
GO
