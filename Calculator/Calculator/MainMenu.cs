using Calculator.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MainMenu
    {
        public static string SeparatorLine = "* * * * * * * * * * * * * * * * * * * * *";
        private List<Operation> operations;

        private static MainMenu instance = null;
        public static MainMenu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainMenu();
                    instance.operations = new List<Operation>()
                    {
                        new Addition(),
                        new Subtraction(),
                        new Multiplication(),
                        new Exit()
                    };
                }

                return instance;
            }
        }

        private MainMenu()
        {

        }

        public bool Exit { get; set; }

        public void Print()
        {
            Console.Out.WriteLine(SeparatorLine);
            Console.Out.WriteLine(" Welcome to Sidney's Awesome Calculator");
            Console.Out.WriteLine(SeparatorLine);

            for (int i = 0; i < this.operations.Count; i++)
            {
                this.PrintOperation(this.operations.ElementAt(i).Name, i + 1);
            }

            Console.Out.WriteLine(SeparatorLine);
            Console.Out.WriteLine(string.Empty);
            this.TakeInput();
        }

        private void TakeInput()
        {
            Console.Out.Write("Input the number the operation you would like: ");
            string input = Console.In.ReadLine();
            Console.Out.WriteLine(string.Empty);

            if (int.TryParse(input, out int choice) && choice <= operations.Count && choice >= 0)
            {
                Operation operation = this.operations.ElementAt(choice - 1);

                Console.Out.WriteLine(SeparatorLine);
                Console.Out.WriteLine(operation.Name);
                Console.Out.WriteLine(SeparatorLine);
                Console.Out.WriteLine(string.Empty);

                operation.Execute();
            }
            else
            {
                this.PrintError();
            }

            this.WaitForInputToContinue();

            //Console.Out.WriteLine(Environment.NewLine);
        }

        private void PrintError()
        {
            Console.Out.WriteLine("Error");
        }

        private void PrintOperation(string name, int num)
        {
            Console.Out.WriteLine($"\t{num}. {name}");
        }

        private void WaitForInputToContinue()
        {
            Console.Out.WriteLine(Environment.NewLine);
            Console.Out.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
