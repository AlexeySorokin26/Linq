namespace Linq
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static string[] GetAllStudents(Classroom[] classes)
        {
            return classes.SelectMany(s => s.Students).ToArray();
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Classroom[] classes = new[]
            {
                new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"} },
                new Classroom { Students = {"Anna", "Viktor", "Vladimir"} },
                new Classroom { Students = {"Bulat", "Alex", "Galina"} }
            };  

            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));

            Console.ReadKey();

        }
    }
}
