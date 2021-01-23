using System;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayi Giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (IsPrimeNumber(number))
            {
                Console.WriteLine("Girilen Sayı Asaldır..",number);
            }
            else
            {
                Console.WriteLine("Girilen Sayı Asal Sayı Değildir..");
            }
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = false;
            int check = 0;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    check = 1; // sayı asal değil
                    break;
                }
            }
            if (check==1)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }

        // Method overloading: methodu aynı isimle aynı geri dönüş değeriyle fakat farklı parametreler ile kullanmaktır.
        static int Addition(int number1, int number2)
        {
            return number1 + number2;

        }
        static int Addition(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }
        static void Addition2(int number, params int[] numbers)
        {
            // params parametresi istediğimiz kadar değer girmemizi sağlar.
        }

    }
}
