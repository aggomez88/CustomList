using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_04_CustomList
{
    public class CustomList<T>
    {
        // ------------------------------------------------------------------------------------VARIABLES (HAS A...)----------------------------------------------------------------------

        public T[] items = new T[0];
        int index;

        public int Count;
        public int Capacity;

        public T this[int index] // indexer properties
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }

        // ---------------------------------------------------------------------------------------CONSTRUCTOR-----------------------------------------------------------------------------

        public CustomList()
        {
            index = 0;
            Count = 0;
            Capacity = 4;

            items = new T[Capacity];
        }

        // --------------------------------------------------------------------------------------METHODS (CAN DO...)----------------------------------------------------------------------

        public void Add(T item)
        {
            if(Count == Capacity)
            {
                T[] temp = new T[Capacity *= 2];
                for (int i = 0; i < Count; i++)
                {
                    temp[i] = items[i];
                }
                items = temp;
            }
            items[Count] = item;
            Count++;
        }
       

        //if (index < 0 && index >= capacity)
        //        {
        //            return items[index];
        //        }
    }
}
