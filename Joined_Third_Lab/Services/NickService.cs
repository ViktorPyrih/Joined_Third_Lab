using Joined_Third_Lab.TimeResolvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joined_Third_Lab.Services
{
    class NickService
    {
        private const string FILE = "data_new.txt";

        public void processTask1()
        {
            Input input = new Input();
            ITime computer = new TimeComputer();
            Console.WriteLine("Print some data to run this task(2 times and 2 natural val (seconds and time in second)):");
            Structures.Time time1 = input.inputTime();
            Structures.Time time2 = input.inputTime();
            int s = input.inputNaturalInt();
            int t = input.inputNaturalInt();
            Console.WriteLine("TimeSinceMidnight realise 1: {0}", computer.TimeSinceMidnight(time1));
            Console.WriteLine("TimeSinceMidnight realise 2: {0}", computer.TimeSinceMidnight(t));
            Console.WriteLine("AddOneSecond realise: {0}", computer.AddOneSecond(time1));
            Console.WriteLine("AddOneMinute realise: {0}", computer.AddOneMinute(time1));
            Console.WriteLine("AddOneHour realise: {0}", computer.AddOneHour(time1));
            Console.WriteLine("AddSeconds realise: {0}", computer.AddSeconds(time1, s));
            Console.WriteLine("Difference realise: {0}", computer.Difference(time1, time2));
            Console.WriteLine("AddOneHour realise: {0}", computer.WhatLesson(time1));

            Console.WriteLine(new string('=', 35));
        }

        public void processTask2()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Result of the query: ");
            Console.WriteLine("Result of the query: ");
            List<Structures.Student> list = Adapter.StudentInfoAdapter.students;
            list = list.Where(stud => stud.mathematicsMark <= 2 || stud.informaticsMark <= 2 || stud.physicsMark <= 2 && stud.scholarship != 0).ToList();
            var result = list.Select(stud => new { Student = stud });
            int k = 0;
            sb.AppendLine("Number     Surname     Mathematics     Informatics     Physics     Scholarship(edited)");
            foreach (var val in result)
            {
                k++;
                Structures.Student student = val.Student;
                sb.AppendLine($"{k,-11}{student.surName,-12}{student.mathematicsMark,-16}{student.informaticsMark,-16}{student.physicsMark,-12}{0, -10}");
                Console.WriteLine($"{k,-11}{student.surName,-12}{student.mathematicsMark,-16}{student.informaticsMark,-16}{student.physicsMark,-12}{0,-10}");
            }
            sb.AppendLine(new string('=', 61));
            Console.WriteLine(new string('=', 61));
            writeToFile(sb.ToString());
        }

        private void writeToFile(string str)
        {
            using (StreamWriter sw = new StreamWriter("data_new.txt"))
                sw.WriteLine(str);
        }
    }
}
