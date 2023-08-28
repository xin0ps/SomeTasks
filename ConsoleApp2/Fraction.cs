using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ConsoleApp2
{
    internal class Fraction
    {
        private int Numerator;
        private int Denominator;

        public Fraction() { Numerator = 1; Denominator = 1; }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public double ToDouble()
        {
            return (double)Numerator / Denominator;
        }

        public override string ToString()
        {
            return Numerator + "/" + Denominator;
        }

        public Fraction Add(Fraction b)
        {
            int commonDenominator = Denominator * b.Denominator;
            int newNumerator = Numerator * (commonDenominator / Denominator) + b.Numerator * (commonDenominator / b.Denominator);
            return new Fraction(newNumerator, commonDenominator);
        }

        public Fraction Multiply(Fraction b)
        {
            return new Fraction(Numerator * b.Numerator, Denominator * b.Denominator);
        }

        public Fraction Divide(Fraction b)
        {
            return new Fraction(Numerator * b.Denominator, Denominator * b.Numerator);
        }

        public Fraction Subtract(Fraction b)
        {
            int commonDenominator = Denominator * b.Denominator;
            int newNumerator = Numerator * (commonDenominator / Denominator) - b.Numerator * (commonDenominator / b.Denominator);
            return new Fraction(newNumerator, commonDenominator);
        }
    }
}


