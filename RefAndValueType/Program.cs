using System;

namespace RefAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            /* reference type : int,double,float vb. belleğin stack bölgesinde tutulur.
             Veriyi taşıyan ve taşıdığı veriye göre bellek üzerinde yer dolduran değişken türleridir. */
            
            int number1 = 10;
            int number2 = 20;
            number1 = number2;
            number2 = 100;
            Console.WriteLine(number1); // 20

            /* value type : array,class,interface, vb. belleğin heap bölgesinde tutulur.
             Bellek bölgesinde veri yerine adres tutarlar ve o adresin gösterdiği yerde de veri tutulur. Adres üzerinden işlem yapılır.*/
            // stringler istisnadır. referans tip olmalarına rağmen metotlara geçirilirken değer tipmiş gibi kopyalanırlar.

            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300 };
            numbers1 = numbers2;
            numbers2[0] = 999;
            Console.WriteLine(numbers1[0]); // 999

           int num1 = 5; // ref ile çağrılacak değişkene ilk değer ataması yapılmak zorunda.
           Addition(ref num1,6); // ref var olan değişkenin değerini değiştirmek için kullanılır.

            // out anahtar kelimesi kullanılırken ilk değer ataması yapılma zorunluluğu yoktur. Bir metotda birden fazla geri dönüş bekleniyorsa kullanılır.
            bool resultMax;
            int maxValue = MaxValue(5, 2,out resultMax);
            Console.WriteLine(resultMax + " En büyük değer :" + maxValue);
            // ref ve out değer tipli değişkenleri referans tipli değişkenlere çevirir.
        }
        static void Addition(ref int number1 , int number2 )
        {
           int result =  8 + number2;
            Console.WriteLine(result);

        }
        static int MaxValue(int value1,int value2,out bool result)
        {
            if (value1>value2)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return Math.Max(value1,value2);
        }
    }
}
