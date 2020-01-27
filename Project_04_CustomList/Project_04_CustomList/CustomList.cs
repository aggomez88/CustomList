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

        public T[] items = new T[4];
        int index;

        public int Count { get { return count; } }

        private int count;
        public int Capacity;

        public T this[int index] // indexer properties
        {
            //need a conditional to prevent out of range access
            //look back at properties slideshow
            
            get
            {
                if (true)
                {
                    //out of range IF its within range, else throw exception
                    return items[index];
                }
                
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
            count = 0;
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
            count++;
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (item.Equals(items[i]))
                {
                    count--;
                }
                else
                {
                    T[] temp = new T[Count];                                            //create new T Array and set equal to new count 
                }
            }
            

            return true;
        }
       

        //if (index < 0 && index >= Capacity)
        //        {
        //            return items[index];
        //        }
    }
}
