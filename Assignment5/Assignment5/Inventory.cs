using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Inventory
    {
        ItemType itemTyoe;
        int slots;
        List<Item> items;

        public Inventory(int slots)
        {
            items = new List<Item>(slots);
        }

        public void Add(Item item)
        {

            items.Add(item);
            throw new NotImplementedException();
        }

        public void Remove(Item item)
        {
            items.Remove(item);
            throw new NotImplementedException();
        }
        public void ShowInventory()
        {
            int i;
            foreach (Item t in items)
            {
                i = items.IndexOf(t);
                items[i].Show();
            }
            throw new NotImplementedException();
        }
    }
}
