using System;
using System.Collections.Generic;
using System.Text;

namespace Swin_Adventure
{
    public interface IHaveInventory
    {
        GameObject Locate(string id);
        GameObject Take(string id);

        string Name
        {
            get;
        }
    }
}
