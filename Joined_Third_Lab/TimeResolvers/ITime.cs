using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joined_Third_Lab.TimeResolvers
{
    public interface ITime
    {
        int TimeSinceMidnight(Structures.Time t);
        Structures.Time TimeSinceMidnight(int t);
        Structures.Time AddOneSecond(Structures.Time t);
        Structures.Time AddOneMinute(Structures.Time t);
        Structures.Time AddOneHour(Structures.Time t);
        Structures.Time AddSeconds(Structures.Time t , int s);
        int Difference(Structures.Time t1, Structures.Time t2);
        string WhatLesson(Structures.Time t);
    }
}
