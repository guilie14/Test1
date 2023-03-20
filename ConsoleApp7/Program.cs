using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControlStudent control = new ControlStudent();

            while (true)
            {
                Console.WriteLine("\nCHUONG TRINH QUAN LY SINH VIEN C#");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Add");
                Console.WriteLine("**  2. Update by ID");
                Console.WriteLine("**  3. Delete by ID");
                Console.WriteLine("**  4. Find by name");
                Console.WriteLine("**  5. Sort by Average **");
                Console.WriteLine("**  6. Sort by Name");
                Console.WriteLine("**  7. Sort by ID");
                Console.WriteLine("**  8. All List");
                Console.WriteLine("**  0. Exits");
                Console.WriteLine("*******************************************************");
                Console.Write("Nhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
