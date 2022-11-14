using DataAccess.Models;

namespace DataAccess.Data
{
  public interface IStudentData
  {
    Task DeleteStudent(int id);
    Task<Students?> GetStudent(int id);
    Task<IEnumerable<Students>> GetStudents();
    Task InsertStudent(Students students);
    Task UpdateStudent(Students students);
  }
}