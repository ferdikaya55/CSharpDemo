using GenericClass;
using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int,string> myList = new MyList<int, string>();
            myList.Add(34, "Istanbul");
            myList.Add(06, "Ankara");
            myList.Add(54, "Sakarya");
            myList.Add(55, "Samsun");
            myList.Add(35, "Izmir");

            Console.WriteLine("Il Sayısı: " + myList.Count);
            

        }
    }
}
