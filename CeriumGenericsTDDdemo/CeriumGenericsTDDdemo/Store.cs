using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeriumGenericsTDDdemo
{
    public class Store
    {
        public int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public void SellItems<T>(Player player, int amount) where T: Item, new()
        {
            for (int i = 0; i < amount; i++)
            {
                T item = new T();
                player.inventory.items.Add(item);
            }
            
        }
        public void SellLemons(Player player)
        {
            for (int i = 0; i < 3; i++)
            {
                Lemon lemon = new Lemon();
                player.inventory.lemons.Add(lemon);
            }
        }
        public void SellCups(Player player)
        {
            for (int i = 0; i < 3; i++)
            {
                Cup cup = new Cup();
                player.inventory.cups.Add(cup);
            }
        }
    }
}
