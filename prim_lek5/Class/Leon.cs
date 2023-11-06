using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim_lek5.Class
{
   public class Leon: ISeries
    {
        int f0;
        int f1;
        int fi;
        public Leon()
        {
            f0 = 1;
            f1 = 1;
        }
        public int GetNext()
        {
            fi = f0 + f1 + 1;
            f0 = f1;
            f1 = fi;
            return fi;
        }
        public void Reset()
        {
            f0 = 1;
            f1 = 1;
        }
        public void SetStart(int x, int x1)
        {
            f0 = x;
            f1 = x1;
        }

    }
}
