using BT_QLHS.Models;
using BT_QLHS.Services.Repositories;

namespace BT_QLHS.Services.Implements
{
    public class StudentClassImplement : IStudentClass
    {
        public static List<StudentClass> _studentClasses = new List<StudentClass>()
        {
            new StudentClass
            {
                Id = 1,
                ClassId= 1,
                StudentId = 1
            },
            new StudentClass
            {
                Id = 1,
                ClassId= 1,
                StudentId = 2
            },
            new StudentClass
            {
                Id = 1,
                ClassId= 2,
                StudentId = 3
            },
        };

        public List<Student> getStudentOfAClass(int classID)
        {
            var list = _studentClasses.Where(c => c.ClassId == classID).ToList();
            var result = (from c in list
                         join s  in StudentImplement._students on c.StudentId equals s.Id
                         select s).ToList();
            return result;
        }
        public List<StudentClass> getAll()
        {
            return _studentClasses;
        }
    }
}
