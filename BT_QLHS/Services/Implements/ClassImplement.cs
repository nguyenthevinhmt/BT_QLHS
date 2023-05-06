using BT_QLHS.Models;
using BT_QLHS.Services.Repositories;

namespace BT_QLHS.Services.Implements
{
    public class ClassImplement : IClass
    {
        private static List<Class> _classes = new List<Class>();
        public void Create(Class cls)
        {
            if (cls.Id < 1)
            {
                throw new Exception("ID lớp học phải lớn hơn 0");
            }
            var check = _classes.FirstOrDefault(c => c.Id == cls.Id);
            if (check != null)
            {
                throw new Exception("ID lớp học đã tồn tại");
            }
            _classes.Add(cls);
        }

        public void CreateListStudent(List<Class> classes)
        {
            if (classes.Count < 1)
            {
                throw new Exception("Danh sach phai co it nhat 1 lop hoc");
            }
            _classes.AddRange(classes);
        }

        public void Delete(int id)
        {
            var result = _classes.FirstOrDefault(c => c.Id == id);
            if (result != null)
            {
                _classes.Remove(result);
            }
            else
            {
                throw new Exception("Lop hoc khong ton tai");
            }
        }

        public List<Class> GetAll()
        {
            return _classes;
        }

        public Class GetById(int id)
        {
            var result = _classes.FirstOrDefault(c => c.Id == id);
            if (result == null)
            {
                throw new Exception("Không tìm thấy lớp học");
            }
            return result;
        }

        public void Update(int id, Class newClass)
        {
            var result = _classes.FirstOrDefault(c => c.Id == id);
            if (result == null)
            {
                throw new Exception("Không tìm thấy lớp học");
            }
            result.Id = newClass.Id;
            result.ClassName = newClass.ClassName;
            result.ClassCode = newClass.ClassCode;
            result.ClassMaxSize = newClass.ClassMaxSize;
        }
        public List<Class> GetPage(int PageNumber, int PageSize)
        {
            if (PageNumber == 0 || PageSize == 0)
            {
                throw new Exception("sizePage hoặc countPage phải lớn hơn 0");
            }
            var classes = _classes.Skip((PageNumber - 1) * PageSize)
                .Take(PageSize)
                .ToList();
            return classes;
        }
    }
}
