using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    public abstract class Operation
    {
        public string Name
        {
            get
            {
                return this.GetType().ToString().Split('.')[2];
            }
        }

        public abstract void Execute();

        protected bool TryGetNumbers(out List<int> numbers)
        {
            numbers = new List<int>();
            Console.Out.WriteLine("Enter numbers separated by a comma");
            string numberstring = Console.In.ReadLine();
            string[] numberline = numberstring.Split(',');
            Console.Out.WriteLine(string.Empty);
            
            for (int i = 0; i < numberline.Length; i = i + 1)
            {
                if (!int.TryParse(numberline[i], out int number))
                {
                    Console.Out.WriteLine("Please Enter Integers");
                    return false;
                }
                else
                {
                    numbers.Add(number);
                }
            }
          
            return true;
        }
    }
}
