using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Operation
    {
        public string Name { get; }
        public Action Function { get; }

        public Operation(string name, Action function)
        {
            this.Name = name;
            this.Function = function;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
