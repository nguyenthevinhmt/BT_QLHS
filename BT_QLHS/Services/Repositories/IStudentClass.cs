using BT_QLHS.Models;

namespace BT_QLHS.Services.Repositories
{
    public interface IStudentClass
    {
        List<Student> getStudentOfAClass(int classID);
        List<StudentClass> getAll();
    }
}
