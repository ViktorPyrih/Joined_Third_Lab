using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joined_Third_Lab.Services
{
    public class ViktorService
    {
        public void processTask1() 
        {
            Input input = new Input();
            IFrac computer = new FracComputer();
            Console.WriteLine("Print some data to run this task(2 fracs and single natural val):");
            Structures.Frac frac1 = input.inputFrac();
            Structures.Frac frac2 = input.inputFrac();
            int n = input.inputNaturalInt();
            Console.WriteLine("First frac double value is {0}", Math.Round(computer.doubleVal(frac1), 3));
            Console.WriteLine("Second frac double value is {0}", Math.Round(computer.doubleVal(frac2), 3));
            Console.WriteLine(frac1 + " + " + frac2 + " = " + computer.ToStringWithIntegerPart(computer.plus(frac1, frac2)));
            Console.WriteLine(frac1 + " - " + frac2 + " = " + computer.ToStringWithIntegerPart(computer.minus(frac1, frac2)));
            Console.WriteLine(frac1 + " * " + frac2 + " = " + computer.ToStringWithIntegerPart(computer.multiply(frac1, frac2)));
            try
            {
                Console.WriteLine(frac1 + " / " + frac2 + " = " + computer.ToStringWithIntegerPart(computer.divide(frac1, frac2)));
            }
            catch (ArithmeticException e)
            {
                MessageBox.Show(e.ToString());
            }
            Console.WriteLine($"First sum({n}) = n/(n + 1) = " + computer.caclSum1(n));
            try
            {
                Console.WriteLine($"Second sum({n}) = (n + 1)/(2*n) = " + computer.caclSum2(n));
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.ToString());
            }
            Console.WriteLine(new string('-', 35));
        }

        public void processTask2() 
        {
            Console.WriteLine("Result of the query: ");
            List<Structures.Student> list = Adapter.StudentInfoAdapter.students;
            list = list.Where(stud => stud.scholarship == 0).ToList();
            var result = list.Select(stud => new { Student = stud, average = (stud.mathematicsMark + stud.informaticsMark + stud.physicsMark) / 3.0 });
            int k = 0;
            Console.WriteLine("Number     Name     Surname     Patronymic       Average mark");
            foreach (var val in result) 
            {
                k++;
                Structures.Student student = val.Student;
                Console.WriteLine($"{k, -11}{student.firstName, -9}{student.surName, -12}{student.patronymic, -17}{val.average:f1}");
            }
            Console.WriteLine(new string('-', 61));
        }
    }
}
