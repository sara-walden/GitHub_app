using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPProject.State;

namespace DPProject.Composite
{
    internal class File: ItemContext
    {
      
        public File(string name) : base(name)
        {
           
        }


        public override ItemContext Clone()
        {
            File file = new(this.Name);
            file.State = this.State;
            return file;
        }

        public override string ShowDetails(string indent)
        {
            indent += "\t";
            return $"{indent}{Name}";

        }
        public override string Open(ItemContext itemContext)
        {
            return $"{itemContext.Name} is open";
        }
    }
}
