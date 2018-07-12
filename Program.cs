using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebittingOfTheAmountByUsingDelegates
{
    class Program
    {
        delegate void GetMessage(); //creating delegate
        static void Main(string[] args)
        {
            GetMessage del; //creating delegate variable
            if (DateTime.Now.Hour < 11)
            {
                del = GoodMorning; //assigning for the variable method address
            }
            else if (DateTime.Now.Hour < 17)
            {
                del = GoodAfternoon;
            }
            else
            {
                del = GoodEvening;
            }

            del.Invoke(); //calling the method
            Console.ReadKey();
        }
        private static void GoodMorning()
        {
            Console.WriteLine("Good Morning!");
        }
        private static void GoodAfternoon()
        {
            Console.WriteLine("Good Afternoon!");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening!");
        }

    }
}
