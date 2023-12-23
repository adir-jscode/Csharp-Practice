using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public struct Fraction
    {
        private readonly int numerator;
        private readonly int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.numerator * b.denominator + b.numerator * a.denominator, a.denominator * b.denominator);
        }

        public static Fraction operator -(Fraction a)
        {
            return new Fraction(-a.numerator,a.denominator);
        }

        public static Fraction operator -(Fraction a,Fraction b)
        {
            return a + (-b);
        }

        public override string ToString()
        {
            return $""" 
                    {numerator}
                    ---------------
                    {denominator}   
                    """;
        }

    }
}
