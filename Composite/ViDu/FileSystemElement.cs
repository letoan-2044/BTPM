using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    public abstract class FileSystemElement
    {
        protected string name;

        public FileSystemElement(string name)
        {
            this.name = name;
        }

        public abstract void Add(FileSystemElement element);
        public abstract void Remove(FileSystemElement element);
        public abstract void Display(int indent);
    }
}
