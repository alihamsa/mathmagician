using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Fibonacci : Integer
    {
        public Fibonacci()
        {
            First = 1;
        }
        public override int GetNext(int current)
        {
            return base.GetNext(current);
        }
    }
}
