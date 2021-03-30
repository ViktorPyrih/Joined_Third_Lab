using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joined_Third_Lab.TimeResolvers
{
    public class TimeComputer : ITime
    {
        private static int secPerDay = 86400;

        public int TimeSinceMidnight(Structures.Time t)
        {
            Specification(ref t);
            return t.h * 3600 + t.m * 60 + t.s;
        }

        public Structures.Time TimeSinceMidnight(int t)
        {
            t %= secPerDay;
            if (t < 0)
                t += secPerDay;
            int h = t / 3600;
            int m = (t / 60) % 60;
            int s = t % 60;
            return new Structures.Time(h, m, s);
        }

        public Structures.Time AddOneSecond(Structures.Time t)
        {
            t.s += 1;
            Specification(ref t);
            return t;
        }

        public Structures.Time AddOneMinute(Structures.Time t)
        {
            t.m += 1;
            Specification(ref t);
            return t;
        }

        public Structures.Time AddOneHour(Structures.Time t)
        {
            t.h += 1;
            Specification(ref t);
            return t;
        }

        public Structures.Time AddSeconds(Structures.Time t, int s)
        {
            t.s += s;
            Specification(ref t);
            return t;
        }

        public int Difference(Structures.Time t1, Structures.Time t2)
        {
            Specification(ref t1);
            Specification(ref t2);
            int time1 = TimeSinceMidnight(t1);
            int time2 = TimeSinceMidnight(t2);
            return time1 - time2;
        }

        public string WhatLesson(Structures.Time t)
        {
            Specification(ref t);
            int time = TimeSinceMidnight(t);
            if (time < 8 * 3600)
                return "Пари не розпочалися";

            else if (time >= 8 * 3600 && time < 9 * 3600 + 20 * 60)
                return "1 пара";

            else if (time >= 9 * 3600 + 20 * 60 && time < 9 * 3600 + 40 * 60)
                return "Перерва між 1-ою і 2-ою парою";

            else if (time >= 9 * 3600 + 40 * 60 && time < 11 * 3600)
                return "2 пара";

            else if (time >= 11 * 3600 && time < 11 * 3600 + 20 * 60)
                return "Перерва між 2-ою і 3-ою парою";

            else if (time >= 11 * 3600 + 20 * 60 && time < 12 * 3600 + 40 * 60)
                return "3 пара";

            else if (time >= 12 * 3600 + 40 * 60 && time < 13 * 3600)
                return "Перерва між 3-ою і 4-ою парою";

            else if (time >= 13 * 3600 && time < 14 * 3600 + 20 * 60)
                return "4 пара";

            else if (time >= 14 * 3600 + 20 * 60 && time < 14 * 3600 + 40 * 60)
                return "Перерва між 4-ою і 5-ою парою";

            else if (time >= 14 * 3600 + 40 * 60 && time < 16 * 3600)
                return "5 пара";

            else if (time >= 16 * 3600 && time < 16 * 3600 + 20 * 60)
                return "Перерва між 5-ою і 6-ою парою";

            else if (time >= 16 * 3600 + 20 * 60 && time < 17 * 3600 + 40 * 60)
                return "6 пара";

            else if (time >= 17 * 3600 + 40 * 60)
                return "Пари Скінчились";

            return time.ToString();
        }

        public void Specification(ref Structures.Time t)
        {
            if (t.s >= 60)
            {
                int temp = (int)Math.Floor((decimal)t.s / 60);
                t.s -= 60 * temp;
                t.m += temp;
            }
            if (t.m >= 60)
            {
                int temp = (int)Math.Floor((decimal)t.m / 60);
                t.m -= 60 * temp;
                t.h += temp;
            }
            if (t.h >= 24)
            {
                int temp = (int)Math.Floor((decimal)t.h / 24);
                t.h -= 24 * temp;
            }
        }

    }
}
