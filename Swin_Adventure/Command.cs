using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
namespace SwinAdventure
{
    public abstract class Command : IdentifiableObject
    {
        public Command(string[] ids) : base(ids)
        {
        }

        public abstract string Execute(Player p, string[] text);
    }
}

