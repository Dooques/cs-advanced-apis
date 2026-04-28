using MagicSchoolApi.Models;
using MagicSchoolApi.Repository;

namespace MagicSchoolApi.Service
{
    public interface ITeacherService
    {
        public List<Teacher> GetAllTeachers();
    }
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public List<Teacher> GetAllTeachers()
        {
            return _teacherRepository.FetchAllTeachers();

        }
    }
}
