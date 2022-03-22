using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicals
{
    internal class Human
    {
        public string name;
        public string gender;
        public int age;

        public Human(string name, string gender, int age)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
        }

        public void ChangeName(string newName)
        {
            this.name = newName;
        }
    }
}
