using SwinAdventure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swin_Adventure
{
    public class GameObject : IdentifiableObject
    {
        string _description, _name;

        public GameObject(string[] ids, string name, string desc) : base(ids)
        {
            _name = name;
            _description = desc;
        }

        public string Name
        {
            get { return _name; }
        }

        public virtual string ShortDescription
        {
            get
            {
                return "a " + _name + " " + FirstID;
            }
        }

        public virtual string LongDescription
        {
            get
            {
                return _description;
            }
        }
    }
}
