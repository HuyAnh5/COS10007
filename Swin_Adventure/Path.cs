using SwinAdventure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Swin_Adventure
{
    public class Path : GameObject
    {
        bool _isBlocked;

        Location _source, _destination;

        public Path(string[] idents, string name, string desc, Location source, Location destination) : base(idents, name, desc)
        {
            AddIdentifier("path");
            foreach (string s in name.Split(" "))
            {
                AddIdentifier(s);
            }

            _isBlocked = false;
            _source = source;
            _destination = destination;
        }

        public Location Destination
        {
            get { return _destination; }
        }

        public override string ShortDescription
        {
            get { return Name; }
        }

        public bool IsBlocked
        {
            get { return _isBlocked; }
            set { _isBlocked = value; }
        }
    }
}
