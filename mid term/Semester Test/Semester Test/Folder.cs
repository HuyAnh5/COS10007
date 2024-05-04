using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Semester_Test
{
    public class Folder : Thing
    {
        private List<Thing> _contents;

        public Folder(string name) : base(name)
        {
            _contents = new List<Thing>();
        }

        public void Add(Thing toAdd)
        {
            _contents.Add(toAdd);
        }

        public override int Size()
        {
            int totalSize = 0;

            foreach (Thing file in _contents)
            {
                totalSize += file.Size();
            }
            return totalSize;
        }

        public override void Print()
        {

            if (Size() == 0) 
            {
                Console.WriteLine($"The folder '{Name}' is empty! \n");
            }
            else
            {
                Console.WriteLine($"The folder '{Name}' contains {Size()} bytes total: \n");
                foreach (var thing in _contents)
                {
                    thing.Print();
                }
            }
            
        }
        
        
    }
}


