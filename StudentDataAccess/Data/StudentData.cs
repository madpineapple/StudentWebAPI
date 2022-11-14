using DataAccess.Models;
using DataAccess.StudentDBAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
  public class StudentData : IStudentData
  {
    private readonly ISqlDataAccess _db;

    public StudentData(ISqlDataAccess db)
    {
      _db = db;
    }
    public Task<IEnumerable<Students>> GetStudents() =>
      _db.LoadData<Students, dynamic>("dbo.spStudent_GetAll", new { });

    public async Task<Students?> GetStudent(int id)
    {
      var results = await _db.LoadData<Students, dynamic>(
        storedProcedure: "dbo.spStudent_Get",
        new { StudentId = id });
      Console.WriteLine("Succes!");
      return results.FirstOrDefault();
    }

    public Task InsertStudent(Students students) =>
      _db.SaveData(storedProcedure: "dbo.spStudent_Insert", new
      {
        students.fname,
        students.lname,
        students.age,
        students.dateOfEnrollment,
        students.grade,
        students.GPA
      });

    public Task UpdateStudent(Students students) =>
      _db.SaveData(storedProcedure: "dbo.spStudent_Update", students);

    public Task DeleteStudent(int id) =>
      _db.SaveData(storedProcedure: "dbo.spStudent_Delete", new { StudentId = id });
  }
}
