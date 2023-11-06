using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim_lek5.Class
{
    public class Arif: ISeries
    {
        int a1;
        int d;
        int ai;
        public Arif()
        {
            a1 = 0;
            d = 1;
        }
        public int GetNext()
        {
            ai = ai + d;
            return ai;
        }
        public void Reset()
        {
            ai = a1;
        }
        public void SetStart(int x, int x1)
        {
            a1 = x;
            d = x1;
            ai = a1;
        }
       
    }
}
