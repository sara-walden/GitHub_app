using DPProject.State;
using FinalProject.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProject.Composite
{
    internal abstract class ItemContext
    {
        public string Name { get; set; }
        public ItemsState State { get; set; }
        public ItemContext(string Name)
        {
            this.Name = Name;
            State = new DraftState(this);

        }
     
        public abstract string Open(ItemContext itemContext);
      
        public abstract string ShowDetails(string indent);


        internal Stack<Memento> Mementos = new Stack<Memento>();

        public string ErrorMessage()
        {
            return $"You can't do this action, you're in {this.State}";
        }


        public void Backup(string name)
        {
            Console.WriteLine("\nCaretaker: Saving Originator's state...");
            var temp = this.Clone();
            this.Mementos.Push(new Memento(name, temp));
        }



        public virtual void Undo()
        {
            if (this.Mementos.Count > 0)
            {
                var memento = this.Mementos.Pop().GetLastState();

                this.State = memento.State;
            }
            else
            {
                Console.WriteLine("no history");
            }
        }



        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of mementos:");
            foreach (var item in this.Mementos)
            {
                Console.WriteLine(item.GetName());
            }
        }
        public abstract ItemContext Clone();

    }

}

