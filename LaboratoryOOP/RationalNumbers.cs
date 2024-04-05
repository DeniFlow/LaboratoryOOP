using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace LaboratoryOOP
{
    class RationalNumbers
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public RationalNumbers(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Делитель не может быть равен 0!");
            }
            Numerator = numerator;
            Denominator = denominator;
            int nod = GSD();
            Numerator /= nod;
            Denominator /= nod;

        }
        public int GSD()
        {
            int numerator = Math.Abs(Numerator);
            int denominator = Math.Abs(Denominator);
            int nod = 0;
            while (numerator != 0 && denominator != 0)
            {
                if (numerator > denominator)
                {
                    numerator = numerator % denominator;
                }
                else
                {
                    denominator = denominator % numerator;
                }
            }

            nod = numerator + denominator;
            return nod;
        }




        public override string ToString()
        {

            if (Denominator < 0 != Numerator < 0)
            {
                if (Math.Abs(Denominator) == 1)
                {
                    return $"Число: -{Math.Abs(Numerator)}";
                }
                return $"Число: -{Math.Abs(Numerator)}/{Math.Abs(Denominator)}";
            }
            if (Math.Abs(Denominator) == 1)
            {
                return $"Число: {Math.Abs(Numerator)}";
            }
            return $"Число: {Math.Abs(Numerator)}/{Math.Abs(Denominator)}";
        }

        public static RationalNumbers operator -(RationalNumbers number1) => new RationalNumbers(-number1.Numerator, number1.Denominator);
        public static RationalNumbers operator +(RationalNumbers number1, RationalNumbers number2)
        {
            return new RationalNumbers(number1.Numerator * number2.Denominator + number2.Numerator * number1.Denominator, number1.Denominator * number2.Denominator);
        }

        public static RationalNumbers operator -(RationalNumbers number1, RationalNumbers number2)
        {
            return number1 + (-number2);
        }
        public static RationalNumbers operator *(RationalNumbers number1, RationalNumbers number2)
        {
            return new RationalNumbers(number1.Numerator * number2.Numerator, number1.Denominator * number2.Denominator);
        }

        public static bool operator >(RationalNumbers number1, RationalNumbers number2)
        {
            return (number1.Numerator / number1.Denominator) > (number2.Numerator / number2.Denominator);
        }

        public static bool operator <(RationalNumbers number1, RationalNumbers number2)
        {
            return (number1.Numerator / number1.Denominator) < (number2.Numerator / number2.Denominator);
        }
        public static bool operator ==(RationalNumbers number1, RationalNumbers number2)
        {
            return (Convert.ToDouble(number1.Numerator) / number1.Denominator) == (Convert.ToDouble(number2.Numerator) / number2.Denominator);
        }
        public static bool operator !=(RationalNumbers number1, RationalNumbers number2)
        {
            return (number1.Numerator / number1.Denominator) != (number2.Numerator / number2.Denominator);
        }

    }
}
