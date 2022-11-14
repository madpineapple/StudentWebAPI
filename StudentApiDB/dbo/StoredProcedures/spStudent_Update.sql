CREATE PROCEDURE [dbo].[spStudent_Update]
  @StudentId int,
  @fname nvarchar(50),
  @lname nvarchar(50),
  @age int,
  @dateOfEnrollment date,
  @grade int,
  @GPA decimal
AS
begin
  update dbo.[Students]
  set 
    fname = @fname,
    lname = @lname,
    age = @age,
    dateOfEnrollment = @dateOfEnrollment,
    grade = @grade,
    GPA = @GPA
  where StudentId = @StudentId;
end