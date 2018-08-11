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
    }
}
