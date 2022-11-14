CREATE PROCEDURE [dbo].[spStudent_Insert]
  @fname nvarchar(50),
  @lname nvarchar(50),
  @age int,
  @dateOfEnrollment date,
  @grade int,
  @GPA decimal
AS
begin
  insert into dbo.[Students] (fname,lname,age,dateOfEnrollment,grade,GPA)
  values (@fname, @lname, @age, @dateOfEnrollment, @grade, @GPA);
end
