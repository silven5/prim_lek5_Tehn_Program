using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim2_lek5.Class
{
    internal abstract class Triangle:IFigure2D
    {
        public double a, b,c;
        string name = "";
        public string  Name {  get
            { return name; }
            set { name = value; } 
        }
        public abstract double S();
        public abstract double P();
        public abstract double r();
    }
}
