using MagicSchoolApi.Model;
using MagicSchoolApi.Models;
using System.Text.Json;

namespace MagicSchoolApi.Repository
{
    public interface ITeacherRepository
    {
        public Teacher FetchTeacherById(int id);
    }
    public class TeacherRepository : ITeacherRepository
    {
        public Teacher FetchTeacherById(int id)
        {
            var json = File.ReadAllText("Resources\\teachers.json");
            var teachers = JsonSerializer.Deserialize<List<Teacher>>(json);
            
            if (id > teachers?.Count) throw new Exception("No matching Id");

            var teacher = teachers?.Find(t => t.Id == id);

            return teacher ?? throw new Exception("No teacher found");
        }
    }
}
