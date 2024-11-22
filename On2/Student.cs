using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On2
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        
        public Student(int id, string name, int Age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = Age;
        }

        public void Show()
        {
            Console.WriteLine(Id + " | " + Name + " | " + Age);
        }
    }
}
