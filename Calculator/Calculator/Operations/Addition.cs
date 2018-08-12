using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    class Addition : Operation
    {
        public override void Execute()
        {
            int result = 0;
            if (this.TryGetNumbers(out List<int> numbers))
            {
                for (int i = 0; i < numbers.Count; i = i + 1)
                {
                    result = result + numbers[i];
                }
                Console.Out.WriteLine("Sum: " + result);
            }
        }
    }
}
