using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        public static MainMenu MainMenu;

        static void Main(string[] args)
        {
            List<Operation> operations = new List<Operation>()
            {
                new Operation("Addition", Addition),
                new Operation("Exit", Quit)
            };

            using (MainMenu = new MainMenu(operations))
            {
                while (!MainMenu.Exit)
                {
                    MainMenu.Print();
                }
            }
        }

        public static void Addition()
        {
            Console.Out.WriteLine("Add the Stuff");
        }

        public static void Quit()
        {
            MainMenu.Exit = true;
        }
    }
}
