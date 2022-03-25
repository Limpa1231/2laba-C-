using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Trapeze : Figure
    {
        public double Top { get; set; }
        public double Bottom { get; set; }

        public override double GetArea()
        {
            return 0.5 * Top * Bottom;
        }
    }
}
