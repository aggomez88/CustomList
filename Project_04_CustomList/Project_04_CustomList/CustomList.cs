using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_04_CustomList
{
    public class CustomList<T>
    {
        // -------------------------------------------------------------------------------------------------VARIABLES (HAS A...)----------------------------------------------------------------------
        T[] items;
        int count;
        int capacity;
        public int count
        {

        }


        



        public T this[int index] // indexer properties
        {
            get
            {
                if (index < 0 && index >= capacity)
                {
                    return items[i]
                }
            }
            set
            {

            }
        }


        // ----------------------------------------------------------------------------------------------------------CONSTRUCTOR-----------------------------------------------------------------------------
        public CustomList()
        {
            int count = 0;
            int capacity = 4;

            T[] items = new T[4];
        }

        // ----------------------------------------------------------------------------------------------------METHODS (CAN DO...)------------------------------------------------------------------------------
        public void Add(T item)
        {
            if(count == capacity)
            {
                T[] temp = new T[capacity *= 2];
                for (int i = 0; i < count; i++)
                {
                    temp[i] = items[i];
                }
                items = temp;
            }
            items[count] = item;
            count++;
        }
    }
}
