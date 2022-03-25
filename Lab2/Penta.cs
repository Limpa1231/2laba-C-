using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Penta : Figure
    {
        public double Side { get; set; }

        public override double GetArea()
        {
            return (5 * Side * Side) / (4 * 0.73);
        }
    }
}
