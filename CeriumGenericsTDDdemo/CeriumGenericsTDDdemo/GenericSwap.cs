using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeriumGenericsTDDdemo
{
    public class GenericSwap
    {
        public void SwapMethod<T>(ref T firstItem, ref T secondItem)
        {
            T temporary;
            temporary = firstItem;
            firstItem = secondItem;
            secondItem = temporary;
        }
    }
}
