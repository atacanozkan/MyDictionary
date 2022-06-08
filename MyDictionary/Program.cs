using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Bir", 1);
            myDictionary.Add("İki", 2);
            myDictionary.Add("Üç", 3);

            //myDictionary.Add("Bir", 10);

            Console.WriteLine(myDictionary["Bir"]);
            myDictionary["Bir"] = 10;
            Console.WriteLine(myDictionary["Bir"]);

            Console.WriteLine(myDictionary["On"]);
            myDictionary["On"] = 10;
        }
    }
}
