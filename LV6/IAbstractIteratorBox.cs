using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6
{
    interface IAbstractIteratorBox
    {
        Product First();
        Product Next();
        bool IsDone { get; }
        Product Current { get; }
    }
}
