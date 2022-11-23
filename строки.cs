using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string s1 = "первая строка";
            string s2 = "вторая строка";

            if (String.CompareOrdinal(s1, s2) != 0)
                Console.WriteLine("Строки s не равны");

            if (String.Compare(s1, 0, s2, 13, 10, true) == 0)
                Console.WriteLine(" в них есть одинаковый текст");

            Console.WriteLine(String.Concat("\n" + "кот, собака ", "рыбка, попугай"));

         
            if (s2.IndexOf("кот") != -1)
                Console.WriteLine("Слово \"кот\" найдено в строке, оно " +
                 "находится на: {0} позиции", s2.IndexOf("это"));


            char[] myCh = { '1', '2', '3', '4', '5', '6' };
            if (s2.IndexOfAny(myCh) != -1)
                Console.WriteLine("Один из символов из массива ch " +
                    "найден в {0}", s2.IndexOfAny(myCh));



            Console.ReadLine();
        }

    }
}
