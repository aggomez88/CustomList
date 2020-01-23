using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeriumGenericsTDDdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //GenericSwap swap = new GenericSwap();
            //int firstItem = 4;
            //int secondItem = 12;

            //swap.SwapMethod<int>(ref firstItem, ref secondItem);

            Store store = new Store();
            Player player = new Player();
            store.SellItems<Lemon>(player, 3);
            store.SellItems<Cup>(player, 4);

            //List<int> numbers = new List<int>();
            //int value = numbers[0];

            List<int> numbers = new List<int>();
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(6);
            numbers.Add(8);
            numbers.Add(10);
        }
    }
}
