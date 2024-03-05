using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18P4
{
    class Student:Person
    {
        private string name;
        private string surname;
        private DateTime birthday;
        private string faculty;

        public int Course { get; set; }

        public Student(string name,string surname,DateTime brithday,string faculty,int cours) : base(string name, brithday, surname, cours)
        {
            this.Course = cours;
        }

        public void Info()
        {
            Console.WriteLine($"name={name},");
            Console.WriteLine($"surname={surname}");
            Console.WriteLine($"brithday{birthday}");
            Console.WriteLine($"faculty={faculty}");
            Console.WriteLine($"Cours={Course}");
        }
    }
}
