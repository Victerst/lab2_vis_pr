using System;
using System.Text;


namespace RomanNumber
{
    public class RomanNumber : ICloneable, IComparable
    {
        private ushort _number;
        private static  int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private static string[] basic_roman_numerals = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        public RomanNumber(ushort n)
        {
            if (n <= 0) throw new RomanNumberException($"!Число {n} < 0 или = 0!");
            else this._number = n;
        }

        public static RomanNumber Add(RomanNumber? n1, RomanNumber? n2)
        {
            int num = n1._number + n2._number;
            if (num <= 0) throw new RomanNumberException("!Не удалось сложить числа, так как сумма получилась = 0 или < 0!");
            else
            {
                RomanNumber result = new((ushort)num);
                return result;
            }
        }

        public static RomanNumber Sub(RomanNumber? n1, RomanNumber? n2)
        {
            int num = n1._number - n2._number;
            if (num <= 0) throw new RomanNumberException("!Разность чисел < 0 или = 0!");
            else
            {
                RomanNumber result = new((ushort)num);
                return result;
            }
        }

        public static RomanNumber Mul(RomanNumber? n1, RomanNumber? n2)
        {
            int num = n1._number * n2._number;
            if (num <= 0) throw new RomanNumberException("!Произведение двух чисел < 0 или = 0!");
            else
            {
                RomanNumber result = new((ushort)num);
                return result;
            }
        }

        public static RomanNumber Div(RomanNumber? n1, RomanNumber? n2)
        {

            if (n2._number == 0) throw new RomanNumberException("!На 0 делить нельзя!");
            else
            {
                int num = n1._number / n2._number;
                if (num == 0) throw new RomanNumberException("!Частное не может = 0!");
                else
                {
                    RomanNumber result = new((ushort)num);
                    return result;
                }
            }
        }

        public override string ToString()
        {
            int tmp = _number;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 13; i++)
            {
                while (tmp >= values[i])
                {
                    tmp -= (ushort)values[i];
                    result.Append(basic_roman_numerals[i]);
                }
            }
            if (result.ToString() == "")
                throw new RomanNumberException("Преобразование чисел в римские цифры невозможно");
            else
                return result.ToString();

        }

        public object Clone()
        {
            return new RomanNumber(_number);
        }

        public int CompareTo(object obj)
        {
            if (obj is RomanNumber basic_roman_numerals)
                return _number.CompareTo(basic_roman_numerals._number);
            else
                throw new RomanNumberException("!Это не Римская цифра!");
        }

    }

}
