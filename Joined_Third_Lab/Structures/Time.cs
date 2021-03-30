using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joined_Third_Lab.Structures
{
    public struct Time
    {
        public int h, m, s;
        public Time(int h, int m, int s)
        {
            this.h = h;
            this.m = m;
            this.s = s;
        }
        public override string ToString()
        {
            string result = h + ":" + m.ToString("D2") + ":" + s.ToString("D2");
            return result;
        }
    }
}
