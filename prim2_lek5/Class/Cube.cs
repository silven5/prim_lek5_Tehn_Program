using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim2_lek5.Class
{
    internal class Cube:IFigure3D
    {
        public string Name { get; set; }
        public Cube()
        {
            Name = "Куб";
        }
        public double V()
        {
            return 1;
        }
         double IFigure3D.V() { return 3; }
        public double S()
        {
            return 1;
        }
    }
}
