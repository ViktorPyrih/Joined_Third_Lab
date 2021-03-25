using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joined_Third_Lab
{
    public class Input
    {
        public TaskEnum setTask()
        {
            string tmp = Console.ReadLine().Trim();
            TaskEnum operation;
            int val;
            if (int.TryParse(tmp, out val) && (val < 1 || val > 2) || !Enum.TryParse(tmp, true, out operation))
            {
                Console.WriteLine("Unsupported operation! Repeat the input, please!");
                return setTask();
            }

            return operation;
        }

        public NameEnum setName()
        {
            string tmp = Console.ReadLine().Trim();
            NameEnum name;
            int val;
            if (int.TryParse(tmp, out val) && (val <= 0 || val > 3) || !Enum.TryParse(tmp, true, out name))
            {
                Console.WriteLine("Unsupported operation! Repeat the input, please!");
                return setName();
            }

            return name;
        }

        public int inputNaturalInt()
        {
            string s = Console.ReadLine();
            int a;
            if (!int.TryParse(s, out a) || a <= 0)
            {
                Console.WriteLine("Wrong value! Repeat the input, please:");
                return inputNaturalInt();
            }

            return a;
        }

        public Structures.Frac inputFrac() 
        {
            long[] arr;
            long denom;
            try
            {
                arr = Console.ReadLine().Split('/').Select(long.Parse).ToArray();
                if (arr.Length == 0 || arr.Length > 2 || arr.Length == 2 && arr[1] == 0)
                {
                    Console.WriteLine("Wrong input! Repeat, please:");
                    return inputFrac();
                }
                if (arr.Length == 1)
                {
                    denom = 1;
                } 
                else 
                {
                    denom = arr[1];
                }
            } 
            catch (FormatException) 
            {
                Console.WriteLine("Wrong input! Repeat, please:");
                return inputFrac();
            }

            return new Structures.Frac(arr[0], denom);
        }
    }
}
