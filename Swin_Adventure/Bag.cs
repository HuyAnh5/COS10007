using SwinAdventure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swin_Adventure
{
    public class Bag : Item, IHaveInventory
    {
        Inventory _inventory;

        public Bag(string[] ids, string name, string desc) : base(ids, name, desc)
        {
            _inventory = new Inventory();
        }

        public Bag(string[] ids, string name, string desc, bool canBeTaken) : base(ids, name, desc, canBeTaken)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            return _inventory.Fetch(id);
        }

        public GameObject Take(string id)
        {
            return _inventory.Take(id);
        }

        public override string LongDescription
        {
            get
            {
                if (_inventory.Count != 0)
                {
                    return base.LongDescription + "\nThe " + FirstID + " has: \n" + _inventory.ItemList;
                }
                else
                {
                    return base.LongDescription;
                }
            }
        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }
    }
}
