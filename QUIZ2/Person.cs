using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz1_nikakhorbaladze
{
    class Person
    {
        private int age;
        public string Name { get; set; }

        public Person(int age, string name)
        {
            this.age = age;
            Name = name;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + age);
        }
    }
}
