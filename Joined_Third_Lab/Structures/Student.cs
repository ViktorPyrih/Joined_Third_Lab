using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Joined_Third_Lab.Structures
{
    public struct Student
    {
        public int number;
        public string surName;
        public string firstName;
        public string patronymic;
        public char sex;
        public DateTime dateOfBirth;
        public byte mathematicsMark;
        public byte physicsMark;
        public byte informaticsMark;
        public int scholarship;

        public Student(string lineWithAllData)
        {
            string s;
            s = (lineWithAllData.Contains(";") ? lineWithAllData.Substring(0, lineWithAllData.Length - 1) : lineWithAllData);
            string[] data = s.Split();
            number = int.Parse(data[0].Replace(")", "").Replace(".", ""));
            surName = data[1];
            firstName = data[2];
            patronymic = data[3];
            sex = Convert.ToChar(data[4]);
            int[] arr = data[5].Split('.').Select(int.Parse).ToArray();
            dateOfBirth = new DateTime(arr[2], arr[1], arr[0]);
            mathematicsMark = byte.Parse(data[6]);
            physicsMark = byte.Parse(data[7]);
            informaticsMark = byte.Parse(data[8]);
            string pattern = @"\D";
            data[9] = Regex.Replace(data[9], pattern, "");
            scholarship = int.Parse(data[9]);
        }
    }
}
