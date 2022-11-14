using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using DataAccess.Models;
using System.Runtime.CompilerServices;
using DataAccess.Data;
namespace WebPortfolioAPI.Controllers
{
  [EnableCors("_myAllowSpecificOrigins")]
  [Route("api/[controller]")]
  [ApiController]
  public class StudentController : Controller
  {

    private readonly IStudentData _studentData;

    public StudentController(IStudentData studentData)
    {
      _studentData = studentData;
    }

    [HttpGet]
    public async Task<IResult> GetStudents()
    {
      try
      {
        return Results.Ok(await _studentData.GetStudents());
      }
      catch (Exception ex)
      {
        return Results.Problem(ex.Message);
      }
    }

    [HttpGet("{id}")]
    public async Task<IResult> GetStudent(int id)
    {
      try
      {
        var students = await _studentData.GetStudent(id);
        if (students == null)
        {
          return Results.NotFound();
        }
        return Results.Ok(students);
      }
      catch (Exception ex)
      {
        return Results.Problem(ex.Message);
      }
    }

    [HttpPost]
    public async Task<IResult> InsertStudent(Students students)
    {
      try
      {
        await _studentData.InsertStudent(students);
        return Results.Ok(students);
      }
      catch (Exception ex)
      {
        return Results.Problem(ex.Message);
      }
    }

    [HttpPut]
    public async Task<IResult> UpdateStudent(Students students)
    {
      try
      {
        await _studentData.UpdateStudent(students);
        return Results.Ok();
      }
      catch (Exception ex)
      {
        return Results.Problem(ex.Message);
      }
    }

    [HttpDelete]
    public async Task<IResult> DeleteStudent(int id)
    {
      try
      {
        await _studentData.DeleteStudent(id);
        return Results.Ok();
      }
      catch (Exception ex)
      {
        return Results.Problem(ex.Message);
      }
    }
  }
}
