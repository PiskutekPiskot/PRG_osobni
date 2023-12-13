using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class Student
    {
        public string name;
        public int id;
        public int year;
        public Dictionary<string,List<double>>subjects;
        public Student(string name,int id,int year, Dictionary<string, List<double>> subjects) 
        {
            this.name = name;
            this.id = id;
            this.year = year;
            this.subjects = subjects;

        }
    }
}
