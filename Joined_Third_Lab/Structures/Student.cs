using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string[] data = lineWithAllData.Substring(0, lineWithAllData.Length - 1).Replace(")", "").Split();
            number = int.Parse(data[0]);
            surName = data[1];
            firstName = data[2];
            patronymic = data[3];
            sex = Convert.ToChar(data[4]);
            int[] arr = data[5].Split('.').Select(int.Parse).ToArray();
            dateOfBirth = new DateTime(arr[2], arr[1], arr[0]);
            mathematicsMark = byte.Parse(data[6]);
            physicsMark = byte.Parse(data[7]);
            informaticsMark = byte.Parse(data[8]);
            scholarship = int.Parse(data[9]);
        }
    }
}
