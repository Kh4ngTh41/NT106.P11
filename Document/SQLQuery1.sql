Create procedure Tinder_Clone_Login_Register
	@username nvarchar(50),
	@pass nvarchar(254),
	@fullname nvarchar(200),
	@gender int
AS
Begin
if exists(select 1 from T_User where [user_name] = @username)
Begin
	select "Da ton tai ten dang nhap"
	return
End
Insert INTO T_USER Values (@username,@pass,@fullname,@gender)