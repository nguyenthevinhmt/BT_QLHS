﻿using BT_QLHS.Models;

namespace BT_QLHS.Services
{
    public interface IStudent
    {
        List<Student> GetAll();
        Student GetById(int id);
        void Create(Student student );
        void Update(int id, Student newStudent);
        void Delete(int id);
    }
}
