using Semester_Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Semester_Test
{
    public class File : Thing
    {
        private string _extension;
        private int _size;

        public File(string name, string extension, int size) : base(name)
        {
            _extension = extension;
            _size = size;
        }

        public override int Size() 
        {  
            return _size;
        }

        public override void Print()
        {
            Console.WriteLine($"--File '{Name}.{_extension}' -- {_size} bytes--");
        }
    }
}


