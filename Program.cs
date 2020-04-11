using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Jovan", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Nikola", 30, "191128", "Math");
            teacher.GetNameAndAge();

            Student student = new Student("Mohamad", 19, "2828", "mohamad@amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
