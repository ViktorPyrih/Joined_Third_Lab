using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joined_Third_Lab
{
    public interface IFrac
    {
        string ToStringWithIntegerPart(Structures.Frac frac);
        double doubleVal(Structures.Frac frac);
        Structures.Frac plus(Structures.Frac frac1, Structures.Frac frac2);
        Structures.Frac minus(Structures.Frac frac1, Structures.Frac frac2);
        Structures.Frac multiply(Structures.Frac frac1, Structures.Frac frac2);
        Structures.Frac divide(Structures.Frac frac1, Structures.Frac frac2);
        Structures.Frac caclSum1(int n);
        Structures.Frac caclSum2(int n);
    }
}
