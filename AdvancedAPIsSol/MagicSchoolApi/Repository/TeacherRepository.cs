using MagicSchoolApi.Model;
using MagicSchoolApi.Models;
using System.Text.Json;

namespace MagicSchoolApi.Repository
{
    public interface ITeacherRepository
    {
        public List<Teacher> FetchAllTeachers();
    }
    public class TeacherRepository : ITeacherRepository
    {
        public List<Teacher> FetchAllTeachers()
        {
            var json = File.ReadAllText("Resources\\teachers.json");
            var teachers = JsonSerializer.Deserialize<List<Teacher>>(json);
            return teachers;
        }
    }
}
