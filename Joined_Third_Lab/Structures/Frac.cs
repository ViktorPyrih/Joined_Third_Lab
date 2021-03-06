using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joined_Third_Lab.Structures
{
    public struct Frac
    {
        public long nom, denom;
        public Frac(long nom, long denom)
        {
            FracComputer fracComp = new FracComputer();
            long divisor = fracComp.findGreatestCommonDivisor(Math.Abs(nom), Math.Abs(denom));
            this.nom = nom / divisor;
            this.denom = denom / divisor;
        }
        public override string ToString()
        {
            if (nom == 0)
            {
                return "0";
            }
            if (denom == 1) 
            {
                return Convert.ToString(nom);
            }
            string result = "";
            if (nom * denom < 0) 
            {
                result += "-";
            }
            result += Math.Abs(nom) + "/" + Math.Abs(denom);

            return result;
        }
    }
}
