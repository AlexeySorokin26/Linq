namespace Linq
{
    using System.Collections.Generic;

    public class Student
    {
        public string Name { get; set; }
        public Student(string Name = "noname")
        {
            this.Name = Name;
        }
    }
}
