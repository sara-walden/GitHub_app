using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProject.Composite
{
    internal class Folder : ItemContext
    {
       
        public List<ItemContext>  Items { get; set; }

        public Folder(string name):base(name) 
        {
            name = name;

            Items = new List<ItemContext>();
        }

        public  void Add(ItemContext item)
        {
            Items.Add(item);
        }

        public  void Remove(ItemContext item)
        {
            var itemToRemove = Items.Find(i => i.Name == item.Name);
            Items.Remove(itemToRemove);
          
        }
        public override string ShowDetails(string indent)
        {
            indent += "\n";
            string s = $"{indent}{Name}";
            foreach (var item in Items)
            {
                s += "\t";
                s += item.ShowDetails(indent);
            }
            return s;
        }

        public override ItemContext Clone()
        {
            Folder folder = new(this.Name);
            folder.Items = this.Items;
            folder.State = this.State;
            return folder;

        }

        public override string Open(ItemContext itemContext)
        {
            return $"{itemContext.Name} is open";
        }

    }
}

