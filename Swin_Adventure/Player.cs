using SwinAdventure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swin_Adventure
{
    public class Player : GameObject, IHaveInventory
    {
        Inventory inventory;
        Location location;

        public Player(string name, string desc) :
            base(new string[] { "me", "inventory" }, name, desc)
        {
            inventory = new Inventory();
        }

        public override string LongDescription
        {
            get
            {
                string desc = new string("");
                desc = desc + "You are " + Name + ", " + LongDescription + "\nYou Have:\n" + inventory.ItemList;
                return desc;
            }
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }

            GameObject obj = inventory.Fetch(id);
            if (obj != null)
            {
                return obj;
            }
            if (location != null)
            {
                obj = location.Locate(id);
                return obj;
            }
            else
            {
                return null;
            }
        }

        public Inventory Inventory
        {
            get { return inventory; }
        }

        public Location Location
        {
            get { return location; }
            set { location = value; }
        }

        public void Move(Path path)
        {
            if (path.Destination != null)
            {
                location = path.Destination;
            }
        }

        public GameObject Take(string id)
        {
            return Inventory.Take(id);
        }
    }
}
