using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_04_CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> myList = new CustomList<int>();

            myList.Add(2);
            myList.Add(4);
            myList.Add(6);
            myList.Add(8);
            myList.Remove(4);

            //for(int i = 0; i < myList.Count; i++)
            //{
            //    Console.WriteLine($"Testing: {myList[i]}");
            //}
            //Console.ReadLine();
        }
    }
}
