using System;

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
    }
}
