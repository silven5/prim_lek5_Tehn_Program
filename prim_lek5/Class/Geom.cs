using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim_lek5.Class
{
    public class Geom:ISeries
    {
        int b1;
        int q;
        double bi;
        int i;
        public Geom()
        {
            b1 = 1;
            q = 2;
            i = 1;
        }
        public int GetNext()
        {
            bi = b1 * Math.Pow(q, i - 1);
            i++;
            return Convert.ToInt32(bi);
        }
        public void Reset()
        {
            bi = b1;
        }
        public void SetStart(int x, int x1)
        {
            b1 = x;
            q = x1;
            bi = b1;
            i = 1;
        }

    }
}
