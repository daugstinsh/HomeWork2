using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.uzdevums");
            Console.WriteLine("Sveiki, kā Jūs godāt?");
            string userName = Console.ReadLine();
            Console.WriteLine("Labdien, augsti godātais, " + userName);

            // ------------------------------------------------------------;
            Console.WriteLine("2.uzdevums");
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
            Console.WriteLine("3.uzdevums");
            Console.WriteLine("Ievadiet divus skaitļus. Noteiksim lielāko skaitli :)");

            string MyNumbertext10 = Console.ReadLine();
            int MyNumber = int.Parse(MyNumbertext10);
            string MyNumbertext11 = Console.ReadLine();
            int MyNumber1 = int.Parse(MyNumbertext11);
            int largest = Math.Max(MyNumber, MyNumber1);
            Console.WriteLine(largest);

            //--------------------------------------------------------------;
            Console.WriteLine("4.uzdevums");
            Console.WriteLine("Ievadiet divus skaitļus. Noteiksim mazāko skaitli :)");

            string MyNumbertext12 = Console.ReadLine();
            int MyNumber2 = int.Parse(MyNumbertext12);
            string MyNumbertext13 = Console.ReadLine();
            int MyNumber3 = int.Parse(MyNumbertext13);
            int smallest = Math.Max(MyNumber2, MyNumber3);
            Console.WriteLine(smallest);

            // ---------------------------------------------------------------;
            Console.WriteLine("5.uzdevums");
            Console.WriteLine("Ievadiet divus skaitļus. Noteiksim skaitļu dalījumu.");

            string MyNumbertext15 = Console.ReadLine();
            int divisionReminder1 = int.Parse(MyNumbertext15);
            string MyNumbertext16 = Console.ReadLine();
            int divisionReminder2 = int.Parse(MyNumbertext16);
            int divisionreminderResult = divisionReminder1 % divisionReminder2;
            Console.WriteLine(divisionreminderResult);

            //-----------------------------------------------------------------;
            Console.WriteLine("6.uzdevums");
            Console.WriteLine("Ievadiet skaitli. Noteiksim pāra vai nepāra skaitli ievadījāt?.");

            Console.WriteLine(int.Parse(Console.ReadLine()) 
            % 2 == 0 ? "pāra" : "nepāra");
            //----------------------------------------------------------------;
            Console.WriteLine("7.uzdevums");
            Console.WriteLine("Ievadiet taisnleņķa trīsstūra sānu malu garumus!");

            double side1, side2, area;
            Console.Write("Mala 1 : ");
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mala 2 : ");
            side2 = Convert.ToDouble(Console.ReadLine());
            area = (side1 * side2) / 2;
            Console.WriteLine("Taisnleņķa laukums : " + area);
            Console.ReadKey();

            //------------------------------------------------------------------;
            Console.WriteLine("8.uzdevums");
            Console.WriteLine("Vienādsānu trijstūra pamatme garums 5. Lūdzu ievadīet augstumu un tiks aprēķināts laukums trijstūrim!");

            double side3, height, area1;
            Console.ReadLine("Pamatne : 5");
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Augstums : ");
            height = Convert.ToDouble(Console.ReadLine());
            area1 = (side1 * height) / 2;
            Console.WriteLine("Vienādsānu trijstūra laukums : " + area1);
            Console.ReadKey();

            //-----------------------------------------------------------------;







        }
    }
}
