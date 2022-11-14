CREATE PROCEDURE [dbo].[spStudent_Get]
  @StudentId int
AS
begin
  select * 
  from dbo.[Students]
  where StudentId = @StudentId;
end

