using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class StudentDataBase
    {
        private List<Student> list;

        public void Add(Student student)
        {
            list.Add(student);
        }
        //Esto es un constructor
        public StudentDataBase()
        {
            list = new List<Student>();
        }
        //funcion parar saber si en nuestra base de datos hay un chaval con un nombre determiando
        public bool ContainsStudent(string name)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Student student = list[i];
                if (student.GetName() == name)
                    return true;
            }
            return false;
        }
    }
}
