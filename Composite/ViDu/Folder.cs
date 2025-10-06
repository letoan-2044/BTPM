using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    public class Folder : FileSystemElement
    {
        private List<FileSystemElement> elements = new List<FileSystemElement>();

        public Folder(string name) : base(name) { }

        public override void Add(FileSystemElement element)
        {
            elements.Add(element);
        }

        public override void Remove(FileSystemElement element)
        {
            elements.Remove(element);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new string('-', indent) + " 📁 " + name);

            foreach (var element in elements)
            {
                element.Display(indent + 2);
            }
        }
    }
}
