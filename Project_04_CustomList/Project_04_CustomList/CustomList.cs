using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Project_04_CustomList
{
    public class CustomList<T> : IEnumerable
    {
        // ------------------------------------------------------------------------------------VARIABLES (HAS A...)----------------------------------------------------------------------

        public T[] items = new T[4];
        int index;

        public int Count { get { return count; } }

        public string String { get; set; }
        public int Number { get; set; }

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

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public bool Remove(T item)
        {
            bool isFound = false;
            T[] temp = new T[Capacity];
            for (int i = 0, j = 1; i < count; i++, j++)
            {
                if (item.Equals(items[i]))
                {
                    isFound = true;
                    count--;
                }

                if(isFound == true)
                {
                    temp[i] = items[j];
                }
                else
                {
                    temp[i] = items[i];
                }
            }
            items = temp;
            return true;
            //if (index < 0 && index >= Capacity)
            //        {
            //            return items[index];
            //        }

        }
        public CustomList<T> Zip(CustomList<T> odd, CustomList<T> even)
        {
            CustomList<T> finalList = new CustomList<T>();

            int index = 0;

            for (int i = 0; i < odd.count + even.count; i++)
            {
                finalList.Add(odd[index]);
                finalList.Add(even[index]);
                index++;
            }
            return finalList;


            //if (even.count != odd.count)
            //{
            //    finalList[index++] = even;
            //    finalList[index++] = odd;
            //}
            //else
            //{
            //    return finalList;
            //}
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            return base.ToString();
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
            yield return "DONE!";
        }

        public static CustomList<T> operator+ (CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> finalList = new CustomList<T>();
            for (int i = 0; i < firstList.Count; i++)
            {
                finalList.Add(firstList[i]);
            }
            for (int i = 0; i < secondList.Count; i++)
            {
                finalList.Add(secondList[i]);
            }
            return finalList;
        }
    public static CustomList<T> operator-(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> finalList = new CustomList<T>();
            for (int i = 0; i < firstList.Count; i++)
            {
                finalList.Remove(firstList[i]);
            }
            for (int i = 0; i < secondList.Count; i++)
            {
                finalList.Remove(secondList[i]);
            }
            return finalList;
        }



    }
}
