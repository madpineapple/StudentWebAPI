CREATE PROCEDURE [dbo].[spStudent_GetAll]
AS
begin
  select * 
  from dbo.[Students];
end
