using System;

namespace RomanNumber
{
     class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RomanNumber n1 = new RomanNumber(3998);
                RomanNumber n2 = new RomanNumber(1);
                RomanNumber n3 = new RomanNumber(9);
                RomanNumber n4 = new RomanNumber(3);
                RomanNumber n5 = new RomanNumber(50);
                RomanNumber n6 = new RomanNumber(30);

                Console.WriteLine(">>> Сложение чисел в Римской системе счисления:");
                Console.WriteLine($"{n1.ToString()} + {n2.ToString()} = {RomanNumber.Add(n1, n2).ToString()} \n");

                Console.WriteLine(">>> Сложение чисел в Римской системе счисления:");
                Console.WriteLine($"{n1.ToString()} + {n3.ToString()} = {RomanNumber.Add(n1, n3).ToString()} \n");

                Console.WriteLine(">>> Вычитание чисел в Римской системе счисления:");
                Console.WriteLine($"{n5.ToString()} - {n6.ToString()} = {RomanNumber.Sub(n5, n6).ToString()} \n");

                Console.WriteLine(">>> Умножение чисел в Римской системе счисления:");
                Console.WriteLine($"{n5.ToString()} * {n6.ToString()} = {RomanNumber.Mul(n5, n6).ToString()} \n");

                Console.WriteLine(">>> Деление чисел в Римской системе счисления:");
                Console.WriteLine($"{n3.ToString()} / {n4.ToString()} = {RomanNumber.Div(n3, n4).ToString()} \n");

                
                //Console.WriteLine($"{n2.ToString()} - {n2.ToString()} = {RomanNumber.Sub(n2, n2).ToString()} \n");

                RomanNumber[] massive = { n1, n2, n3, n4, n5, n6 };
                Array.Sort(massive);
                Console.WriteLine(">>> Сортировка массива Римских чисел:");

                foreach (var num in massive)
                {   
                    Console.WriteLine(num.ToString());
                }

            }

            catch (RomanNumberException exceptions)
            {
                Console.WriteLine($": {exceptions.Message}");
            }

        }
    }
}
