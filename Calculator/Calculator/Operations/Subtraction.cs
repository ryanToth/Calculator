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
            int result = 0;
            if (this.TryGetNumbers(out List<int> numbers))
            {
                for (int i = 0; i < numbers.Count; i = i + 1)
                {
                    if (i != 0)
                    {
                        numbers[i] = -numbers[i];
                    }
                    result = result + numbers[i];
                }
                Console.Out.WriteLine("Difference: " + result);
            }
        }
    }
}
