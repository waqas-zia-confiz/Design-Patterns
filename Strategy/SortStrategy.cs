using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface SortStrategy
    {
        void Sort(List<string> list);
    }
}
