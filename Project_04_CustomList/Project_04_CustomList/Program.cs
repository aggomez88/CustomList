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

            myList.ToString(2);
            myList.ToString(4);
            myList.ToString(6);
            myList.ToString(8);
            myList.ToString(4);

            //for(int i = 0; i < myList.Count; i++)
            //{
            //    Console.WriteLine($"Testing: {myList[i]}");
            //}
            //Console.ReadLine();
        }
    }
}
