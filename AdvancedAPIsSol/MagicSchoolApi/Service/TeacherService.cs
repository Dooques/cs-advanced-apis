using MagicSchoolApi.Models;
using MagicSchoolApi.Repository;

namespace MagicSchoolApi.Service
{
    public interface ITeacherService
    {
        public Teacher GetTeacherById(int id);
    }
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public Teacher GetTeacherById(int id)
        {
            return _teacherRepository.FetchTeacherById(id);
        }
    }
}
