using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim_lek5.Class
{
    internal interface ISeries
    {
        int GetNext(); // повернути наступне число
        void Reset(); // перезапустити
        void SetStart(int х, int x1); // задати початкові значення
    }
}
