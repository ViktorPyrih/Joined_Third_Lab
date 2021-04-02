using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Joined_Third_Lab.Adapter
{
    public class StudentInfoAdapter
    {
        public static List<Structures.Student> students { get; set; } = new List<Structures.Student>(); 
        private string path = "input_file.txt";
        public void subtractStudentInfoList() 
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    students.Add(new Structures.Student(s));
                }
            }
        }
    }
}
