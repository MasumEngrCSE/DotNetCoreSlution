using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignPattern
{
    #region Composite Pattern

    /*
     
    The Composite Pattern is a structural pattern that allows you to compose objects into tree structures to represent part-whole hierarchies.
    This pattern is useful when you want to treat individual objects and compositions of objects uniformly, simplifying the client code.

    Here's an example of the Composite Pattern:

    Suppose we're building a file system representation where we have files and directories. Both files and directories are treated as "components," 
    and we want to be able to navigate through them and calculate the total size of directories.


     */

    #endregion

    using System;
    using System.Collections.Generic;

    // Component interface
    public abstract class FileSystemComponent
    {
        public abstract int GetSize();
    }

    // Leaf: File
    public class CPFile : FileSystemComponent
    {
        private int size;

        public CPFile(int size)
        {
            this.size = size;
        }

        public override int GetSize()
        {
            return size;
        }
    }

    // Composite: Directory
    public class CPDirectory : FileSystemComponent
    {
        private List<FileSystemComponent> components = new List<FileSystemComponent>();

        public void AddComponent(FileSystemComponent component)
        {
            components.Add(component);
        }

        public override int GetSize()
        {
            int totalSize = 0;
            foreach (var component in components)
            {
                totalSize += component.GetSize();
            }
            return totalSize;
        }
    }



    #region In this example

    /*
     
    In this example, the FileSystemComponent class is the abstract base class for both files and directories.
    File is a leaf component representing a file with a specific size, and Directory is a composite component representing a directory that can contain other files and directories.

    Now, let's see how you can use these classes:


    class Program
    {
        static void Main(string[] args)
        {
            // Creating files
            File file1 = new File(100); // 100 bytes
            File file2 = new File(200); // 200 bytes
            File file3 = new File(50);  // 50 bytes

            // Creating directories
            Directory directory1 = new Directory();
            directory1.AddComponent(file1);
            directory1.AddComponent(file2);

            Directory directory2 = new Directory();
            directory2.AddComponent(file3);

            // Combining directories
            Directory rootDirectory = new Directory();
            rootDirectory.AddComponent(directory1);
            rootDirectory.AddComponent(directory2);

            // Calculate total size
            int totalSize = rootDirectory.GetSize();
            Console.WriteLine("Total size of the root directory: " + totalSize + " bytes");
        }
    }



    Why Composite Pattern is Necessary:

    Part-Whole Hierarchy: The Composite Pattern is necessary when you have objects that can be composed into tree structures to 
    represent part-whole hierarchies, such as files and directories, or items and categories in an inventory system.

    Uniformity: It allows you to treat individual objects (leaves) and compositions of objects (composites) uniformly.
    This simplifies client code, as you don't need to distinguish between leaf and composite objects when working with them.

    Recursive Structures: When dealing with recursive structures like trees, the Composite Pattern provides 
    a common interface for all elements in the hierarchy.

    Complexity Management: It helps manage the complexity of interacting with hierarchical structures by encapsulating traversal 
    and manipulation logic within the composite objects themselves.

    Flexibility: You can add new types of components (leaves and composites) without changing the client code.

    Code Reusability: Components can be reused in various contexts, and you can create complex structures from simpler components.

    In summary, the Composite Pattern is necessary when you want to represent part-whole hierarchies in a way that allows you to 
    work with individual objects and compositions of objects uniformly, simplifying code and providing flexibility for managing complex structures.


     */


    #endregion

}
