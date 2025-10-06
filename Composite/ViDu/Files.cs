using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    public class Files : FileSystemElement
    {
        public Files(string name) : base(name) { }

        public override void Add(FileSystemElement element)
        {
            Console.WriteLine("Cannot add to a file.");
        }

        public override void Remove(FileSystemElement element)
        {
            Console.WriteLine("Cannot remove from a file.");
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new string('-', indent) + " 📄 " + name);
        }
    }
}
