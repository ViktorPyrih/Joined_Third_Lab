﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joined_Third_Lab
{
    public class FracComputer : IFrac
    {
        public string ToStringWithIntegerPart(Structures.Frac frac)
        {
            long intPart = frac.nom / frac.denom;
            long val = frac.nom % frac.denom;
            long newNom = intPart != 0 ? Math.Abs(val) : val;

            return (intPart != 0 ? Convert.ToString(intPart) : "") + new Structures.Frac(newNom, frac.denom);
        }

        public double doubleVal(Structures.Frac frac) 
        {
            return (double)frac.nom / frac.denom;
        }

        public Structures.Frac plus(Structures.Frac frac1, Structures.Frac frac2) 
        {
            long newNom = frac1.nom * frac2.denom + frac2.nom * frac1.denom;
            long newDenom = frac1.denom * frac2.denom;
            long greatestCommonDivisor = findGreatestCommonDivisor(newNom, newDenom);

            return new Structures.Frac(newNom / greatestCommonDivisor, newDenom / greatestCommonDivisor);
        }

        public Structures.Frac minus(Structures.Frac frac1, Structures.Frac frac2)
        {
            return plus(frac1, new Structures.Frac(-frac2.nom, frac2.denom));
        }

        public Structures.Frac multiply(Structures.Frac frac1, Structures.Frac frac2) 
        {
            long newNom = frac1.nom * frac2.nom;
            long newDenom = frac1.denom * frac2.denom;
            long greatestCommonDivisor = findGreatestCommonDivisor(newNom, newDenom);

            return new Structures.Frac(newNom / greatestCommonDivisor, newDenom / greatestCommonDivisor);
        }

        public Structures.Frac divide(Structures.Frac frac1, Structures.Frac frac2) {
            if (frac2.nom == 0) 
            {
                throw new ArithmeticException("Error! Dividing by '0'!");
            }

            return multiply(frac1, new Structures.Frac(frac2.denom, frac2.nom));
        }

        public Structures.Frac caclSum1(int n) 
        {
            if (n <= 0) throw new ArgumentException("'n' must be greater than 0!");
            Structures.Frac frac = new Structures.Frac(0, 1);
            for (int i = 1; i <= n; i++) 
            {
                Structures.Frac tmp = new Structures.Frac(1, i * (i + 1));
                frac = plus(frac, tmp);
            }

            return frac;
        }

        public Structures.Frac caclSum2(int n)
        {
            if (n <= 1) throw new ArgumentException("'n' must be greater than 0!");
            Structures.Frac frac = new Structures.Frac(1, 1);
            for (int i = 2; i <= n; i++)
            {
                Structures.Frac tmp = new Structures.Frac(i * i - 1, i * i);
                frac = multiply(frac, tmp);
            }

            return frac;
        }

        private long findGreatestCommonDivisor(long a, long b) 
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != 0 && b != 0) 
            {
                if (a >= b) a %= b;
                else b %= a;
            }

            return a + b;
        }
    }
}