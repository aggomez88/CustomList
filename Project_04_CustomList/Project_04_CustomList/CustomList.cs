using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_04_CustomList
{
    public class CustomList<T>
    {
        public void Add(T item)
        {
            // VARIABLES (HAS A...)
            int count = 1;
            int capacity = 4;
                        
            T[] items = new T[4];
            T[] temp = new T[capacity * 2];

            

            // CONSTRUCTOR
            public CustomList ()
            {

            }

            // METHODS (CAN DO...)
            for (int i = 0; i < count; i++)
            {
                temp[i] = items[i];
                count++;
                if (i == count || i == capacity) ;
                {
                    continue;
                }
            }

        }
    }
}
