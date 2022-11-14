CREATE PROCEDURE [dbo].[spStudent_Delete]
  @StudentId int
AS
begin
  delete
  from dbo.[Students]
  where StudentId = @StudentId;
end
