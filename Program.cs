using System;
using System.Collections.Generic;
namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDataBase db = new StudentDataBase();
            Student st = new Student("Alberto", 5);
            Student s2 = st;
            Student st2 = new Student(null, 7);

            db.Add(st);    //en la lista hay referencias de los objetos y no los objeto como tal
            db.Add(st2);

            st.SetNia(5);
            s2.SetName("Alberto");
            st2.SetNia(7);
            //st2.SetName("Nerea");

            Console.WriteLine("El Nia del alumno es " + st.GetNia() + " y su nombre es " + st.GetName());
            Console.WriteLine("El Nia del alumno es " + st2.GetNia() + " y su nombre es " + st2.GetName());

            //bool test = db.ContainsStudent("Alberto");
            //db.GetStudentIndex("NEREA");
           
            db.RemoveStudent2(5);
        }
    }
}
