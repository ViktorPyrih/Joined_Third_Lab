using Joined_Third_Lab.TimeResolvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joined_Third_Lab.Services
{
    class MaksymService
    {
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
            Console.WriteLine("Difference realise: {0}", computer.Difference(time1,time2));
            Console.WriteLine("AddOneHour realise: {0}", computer.WhatLesson(time1));

            Console.WriteLine(new string('=', 35));
        }

        public void processTask2()
        {
            Console.WriteLine("Result of the query: ");
            List<Structures.Student> list = Adapter.StudentInfoAdapter.students;
            list = list.Where(stud => stud.scholarship == 0).ToList();
            var result = list.Select(stud => new { Student = stud, average = (stud.mathematicsMark + stud.informaticsMark + stud.physicsMark) / 3 });
            int k = 0;
            foreach (var val in result)
            {
                k++;
                Structures.Student student = val.Student;
                Console.WriteLine("Number     Name     Surname     Patronymic       Average mark");
                Console.WriteLine($"{k,-11}{student.firstName,-9}{student.surName,-12}{student.patronymic,-17}{0:f1}", val.average);
            }
            Console.WriteLine(new string('-', 61));
        }
    }
}
