using System;
using System.Linq;

namespace ConsoleApplication1
{
    class Employee
    {
        private String name;
        private int age;
        private String grade;

        public Employee(String name, int age, String grade)
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }

        public String DisplayDetails()
        {
            return "NAME : " + this.name + " AGE : " + this.age + " GRADE : " + grade;
        }

        public String Name
        {
            get
            {
                return this.name.ToUpper();
            }
            set
            {
                if (value.Any(ch => Char.IsDigit(ch)))
                {
                    Console.WriteLine("Name cannot have digits in it");
                    return;
                }else
                {
                    name = value;
                }
            }
        }
    }
}
