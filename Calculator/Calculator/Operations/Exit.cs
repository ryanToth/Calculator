using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    public class Exit : Operation
    {
        public override void Execute()
        {
            MainMenu.Instance.Exit = true;
            Console.Out.WriteLine("Good-Bye!");
        }
    }
}
