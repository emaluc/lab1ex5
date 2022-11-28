using System;

namespace lab1ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se citesc doua numere de la tastatura, x,y. 
             Scrieti un program care va afisa cele doua valori in ordine crescatoare.*/

            Console.WriteLine("Introduceti primul numar");
            int primulNumar = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar");
            int alDoileaNumar = int.Parse(Console.ReadLine());
            
            Console.WriteLine("vom afisa numerele in ordine crescatoare");

            if (primulNumar > alDoileaNumar)
            {
                Console.WriteLine(alDoileaNumar + " " + primulNumar);
            }
            else
            {
                Console.WriteLine(primulNumar + " " + alDoileaNumar);
            }
        }
    }
}
