using System;
using System.Collections.Generic;
using System.Linq;

namespace SwinAdventure
{
    public class Inventory
    {
        private List<Item> _items;

        public Inventory()
        {
            _items = new List<Item>();
        }

        public bool HasItem(string id)
        {
            foreach (Item item in _items)
            {
                if (item.AreYou(id))
                {
                    return true;
                }
            }
            return false; 
        }


        public void Put(Item itm)
        {
            _items.Add(itm);
        }

        public Item Take(string id)
        {
            Item item = Fetch(id);
            if (item != null)
            {
                _items.Remove(item);
            }
            return item;
        }

        public Item Fetch(string id)
        {
            foreach (Item item in _items)
            {
                if (item.AreYou(id))
                {
                    return item;
                }
            }
            return null; 
        }

        public string ItemList
        {
            get
            {
                List<string> itemDescriptions = new List<string>();
                foreach (Item item in _items)
                {
                    itemDescriptions.Add("\ta " + item.Name + " (" + item.FirstId + ")");
                }
                return string.Join("\n", itemDescriptions);
            }
        }
    }
}