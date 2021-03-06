﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class StudentDataBase
    {
        private List<Student> studentList;

        public void Add(Student student)
        {
            studentList.Add(student);
        }
        //Esto es un constructor
        public StudentDataBase()
        {
            studentList = new List<Student>();
        }
        //funcion parar saber si en nuestra base de datos hay un chaval con un nombre determiando
        public bool ContainsStudent(string name)
        {
            return GetStudentIndex(name) != -1;
        }
        //dado un nombre de alumno quiero un metodo que me devuelva la posicion de ese alumno en la base de datos
        public int GetStudentIndex(string name)
        {
            if (name == null)
                return -1;
            for (int i = 0; i < studentList.Count; i++)
            {
                Student student = studentList[i];
                if (student.GetName() != null && student.GetName().ToUpper() == name.ToUpper())//SE pone el toupper pare que puedas buscar tanto en mayus como en minus y que no de error
                    return i;
            }
            return -1;
        }

        public void RemoveStudent(string name)
        {
            int index = GetStudentIndex(name);///para saber cual es la posicion de la presona que queremos saber.
            if(index >= 0)
            studentList.RemoveAt(index);
        }
        public void RemoveStudent2(int nia)
        {
            int index = GetStudentIndex2(nia);///para saber cual es la posicion de la presona que queremos saber.
            if (index >= 0)
            studentList.RemoveAt(index);
        }
        public int GetStudentIndex2(int nia)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                Student student = studentList[i];
                if (student.GetNia() == nia)//SE pone el toupper pare que puedas buscar tanto en mayus como en minus y que no de error
                    return i;
            }
            return -1;
        }
    }
}
