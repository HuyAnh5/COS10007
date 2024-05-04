// See https://aka.ms/new-console-template for more information

namespace Semester_Test
{
    public class FileSystem
    {
        private List<Thing> _contents;

        public FileSystem()
        {
            _contents = new List<Thing>();
        }

        public void Add(Thing toAdd)
        {
            _contents.Add(toAdd);
        }

        public void PrintContents()
        {
            Console.WriteLine("This file system contains: \n");
            foreach (Thing folder in _contents)
            {
                folder.Print();
            }
        }
    }
}