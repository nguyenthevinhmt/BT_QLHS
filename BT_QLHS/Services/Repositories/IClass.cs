using BT_QLHS.Models;

namespace BT_QLHS.Services.Repositories
{
    public interface IClass
    {
        List<Class> GetAll();
        Class GetById(int id);
        void Create(Class cls);
        void Update(int id, Class newClass);
        void Delete(int id);
        void CreateListStudent(List<Class> classes);
        List<Class> GetPage(int size, int page);
    }
}
