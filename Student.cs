using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Student
    {
        private string Name;
        private int Nia;

        public void SetNia(int value)
        {
            Nia = value;            //set "algo" = seters
        }
        public void SetName(string value)
        {
            Name = value.ToUpper();
        }

        /*public void SetName(string name) 
        {
            this.Name = name;Si pones el this lo que hace es poner el primer objeto, el siguietne this cogera el segundo y asi sucesivo
            this es coje el st por asi decirlo
        }*/
        public int GetNia()
        {
            return Nia;
        }
        public string GetName()
        {
            return Name;
        }
    }

}
