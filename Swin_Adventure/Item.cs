using SwinAdventure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swin_Adventure
{
    public class Item : GameObject
    {
        private bool _canBeTaken;

        public bool CanBeTaken
        {
            get { return _canBeTaken; }
        }

        public Item(string[] idents, string name, string desc) : base(idents, name, desc)
        {
            _canBeTaken = true;
        }

        public Item(string[] idents, string name, string desc, bool canBeTaken) : base(idents, name, desc)
        {
            _canBeTaken = canBeTaken;
        }
    }
}
