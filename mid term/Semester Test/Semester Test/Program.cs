using Semester_Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Semester_Test
{
    class Program
    {
        static void Main(string[] args)
        {

            

            // Creating a file system
            FileSystem fileSystem = new FileSystem();

            // Adding files to the file system
            fileSystem.Add(new File("Document", "txt", 1024));
            fileSystem.Add(new File("Image", "png", 2048));


            

            // Adding a folder that contains files to the file system
            Folder folder1 = new Folder("Folder1");
            folder1.Add(new File("Document", "doc", 512));
            folder1.Add(new File("Spreadsheet", "xlsx", 768));
            fileSystem.Add(folder1);
            

            Folder Folderabc = new Folder("Folderabc");
            Folderabc.Add(folder1);
            Folderabc.Add(new File("Document", "doc", 15));
            fileSystem.Add(Folderabc);

            // Adding a folder that contains a folder that contains files to the file system
            Folder folder2 = new Folder("Folder2");
            Folder subfolder = new Folder("Subfolder");
            subfolder.Add(new File("Script", "js", 256));
            folder2.Add(subfolder);
            fileSystem.Add(folder2);

            // Adding an empty folder to the file system
            fileSystem.Add(new Folder("EmptyFolder"));

            // Printing the contents of the file system
            fileSystem.PrintContents();
        }
    }
}
