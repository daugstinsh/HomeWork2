using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki, kā Jūs godāt?");
            string userName = Console.ReadLine();
            Console.WriteLine("Labdien, augsti godātais, " + userName);


            // ------------------------------------------------------------;

            
            Console.WriteLine("Kāds ir Jūsu vecums?");
            string userage = Console.ReadLine();

            int age = int.Parse(userage);
            int nextYearAge = age + 1;
            Console.WriteLine("Nākamo gadu Jums paliek " + nextYearAge);


            // ------------------------------------------------------------;

            Console.WriteLine("12 vai 66 ir lielāks skaitlis?");

            int MaxNumber1 = 12;
            int MaxNumber2 = 66;

            int maxResult = Math.Max(MaxNumber1, MaxNumber2);

            Console.WriteLine("Lielāks skaitlis ir " + maxResult);

            // ------------------------------------------------------------;

            Console.WriteLine("11 vai 9 ir mazāks skaitlis?");

            int MaxNumber3 = 9;
            int MaxNumber4 = 11;

            int minResult = Math.Min(MaxNumber3, MaxNumber4);

            Console.WriteLine("Mazākais skaitlis ir " +minResult);

            // ------------------------------------------------------------;

            Console.WriteLine("Ievadiet divus skaitļus. Noteiksim lielāko skaitli :)");

            string MaxNumber5 = Console.ReadLine();
            string MaxNumber6 = Console.ReadLine();
            int MaxResult = Math.Max(MaxNumber5, MaxNumber6);

            Console.WriteLine("Lielāks skaitlis ir " + MaxResult);

            //--------------------------------------------------------------;










        }
    }
}
