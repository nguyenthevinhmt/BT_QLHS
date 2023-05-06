using BT_QLHS.Models;
using BT_QLHS.Services.Repositories;

namespace BT_QLHS.Services.Implements
{
    public class StudentImplement : IStudent
    {
        public static List<Student> _students = new List<Student>()
        {
            new Student
            {
                Id = 1,
                Ten = "a",
                MSSV= "b",
                DoB = new DateTime(2002,12,24)
            },
            new Student
            {
                Id = 2,
                Ten = "b",
                MSSV= "c",
                DoB = new DateTime(2003,12,24)
            }
        };
        public void CreateListStudent(List<Student> students)
        {
            if (students.Count < 1)
            {
                throw new Exception("List sinh vien phai chua it nhat 1 sinh vien!");
            }
            _students.AddRange(students);
        }

        public void Create(Student student)
        {
            if (student.Id < 1)
            {
                throw new Exception("Id phai lon hon 0!!");
            }
            var check = _students.FirstOrDefault(s => s.Id == student.Id);
            if(check != null)
            {
                throw new Exception("ID sinh viên đã tồn tại");
            }
            _students.Add(student);
        }

        public void Delete(int id)
        {
            var result = _students.FirstOrDefault(c => c.Id == id);
            if (result != null)
            {
                _students.Remove(result);
            }
            else
            {
                throw new Exception("Sinh vien khong ton tai");
            }
        }

        public List<Student> GetAll()
        {
            return _students;
        }

        public Student GetById(int id)
        {
            var result = _students.FirstOrDefault(c => c.Id == id);
            if (result == null)
            {
                throw new Exception("Sinh vien khong ton tai");
            }
            return result;
        }

        public void Update(int id, Student newStudent)
        {
            var result = _students.FirstOrDefault(c => c.Id == id);
            if (result != null)
            {
                result.Ten = newStudent.Ten;
                result.MSSV = newStudent.MSSV;
                result.DoB = newStudent.DoB;
            }
            else
            {
                throw new Exception("Không tồn tại sinh viên");
            }
        }
        public List<Student> GetPage(int PageNumber, int PageSize)
        {
            if (PageNumber == 0 || PageSize == 0)
            {
                throw new Exception("sizePage hoặc countPage phải lớn hơn 0");
            }
            var students = _students.Skip((PageNumber - 1) * PageSize)
                .Take(PageSize)
                .ToList();
            return students;
        }
    }
}
