USE [User_Pass]
GO
/****** Object:  StoredProcedure [dbo].[Tinder_Clone_Login_Register]    Script Date: 10/23/2024 1:32:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[Tinder_Clone_Login_Register]
	-- Add the parameters for the stored procedure here
	@userName nvarchar(50)='',
	@pass nvarchar(254)='',
	@fullName nvarchar(200)=' ',
	@gender int =-1
	 
AS
BEGIN
	if exists(select 1 from USER_LIST where [username]=userName)
	Begin
		select 'ten dang nhap da ton tai'
		return
	End
	Insert Into USER_LIST Values (@userName, @pass,@fullName,@gender)
	select ''
END
