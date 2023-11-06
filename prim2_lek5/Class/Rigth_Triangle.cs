using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim2_lek5.Class
{
    internal class Rigth_Triangle:Triangle
    {
        public Rigth_Triangle(double a,double b)
        {
            if (a > 0 && b > 0)
            {
                this.a = a;
                this.b = b;
                c=Math.Sqrt(a*a + b*b);
                Name = "прямокутний трикутник";
            }
            else
                throw new ArgumentOutOfRangeException("Negative a ,b");
        }
       public override double S()
        {
            return 0.5 * a * b;
        }
       public override double P()
        {
            return a + b;
        }
        public override double r()
        {
            return a*b/(a+b+c);
        }
        public string C()
        {
            return "Прямокутний трикутник. Гіпотенуза = " +c.ToString();
        }
    }
}
