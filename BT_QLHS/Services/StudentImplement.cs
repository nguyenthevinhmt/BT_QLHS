using BT_QLHS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;

namespace BT_QLHS.Services
{
    public class StudentImplement : IStudent
    {
        private static List<Student> _students = new List<Student>();
        //private static int _id = 0;

        public void Create(Student student)
        {
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
            return result;
        }

        public void Update(int id, Student newStudent)
        {
            var result = _students.FirstOrDefault(c => c.Id == id);
            if (result != null) {
                result.Ten = newStudent.Ten;
                result.MSSV = newStudent.MSSV;
                result.DoB = newStudent.DoB;
            }
            else
            {
                throw new Exception("Không tồn tại sinh viên");
            }
        }
    }
}
