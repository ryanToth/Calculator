using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MainMenu : IDisposable
    {
        private string separatorLine = "* * * * * * * * * * * * * * * * * * * * *";
        private List<Operation> operations;

        public MainMenu(List<Operation> operations)
        {
            this.operations = operations;
        }

        public bool Exit { get; set; }

        public void Print()
        {
            Console.Out.WriteLine(separatorLine);
            Console.Out.WriteLine(" Welcome to Sidney's Awesome Calculator");
            Console.Out.WriteLine(separatorLine);

            for (int i = 0; i < this.operations.Count; i++)
            {
                PrintOperation(this.operations.ElementAt(i).ToString(), i + 1);
            }

            Console.Out.WriteLine(separatorLine);
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
                this.operations.ElementAt(choice-1).Function();
            }
            else
            {
                this.PrintError();
            }

            Console.Out.WriteLine(string.Empty);
        }

        private void PrintError()
        {
            Console.Out.WriteLine("Error");
        }

        private void PrintOperation(string name, int num)
        {
            Console.Out.WriteLine($"\t{num}. {name}");
        }
        
        public void Dispose()
        {
            Console.Out.WriteLine(separatorLine);
            Console.Out.WriteLine("Good-Bye!");
            Console.Out.WriteLine(separatorLine);
        }
    }
}
