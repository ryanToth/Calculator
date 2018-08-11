using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    public class Subtraction : Operation
    {
        public override void Execute()
        {
            Console.Out.WriteLine("Enter numbers separated by a comma");
            string numbers = Console.In.ReadLine();
            string[] numberline = numbers.Split(',');
            Console.Out.WriteLine(string.Empty);
            int result = 0;

            for (int i = 0; i < numberline.Length; i = i + 1)
            {
                if (!int.TryParse(numberline[i], out int subtracts))
                {
                    Console.Out.WriteLine("Please Enter Integers");
                    return;
                }
                else
                {
                    if (i != 0)
                    {
                        subtracts = -subtracts;
                    }
                    result = result + subtracts;
                }
            }
            Console.Out.WriteLine("Difference: " + result);
        }
    }
}
