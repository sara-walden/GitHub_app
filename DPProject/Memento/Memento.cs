using DPProject.Composite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Memento
{
    internal class Memento 
    {
        private string name;
        private DateTime date;
        private ItemContext lastState;
        public Memento(string name, ItemContext lastState)
        {
            this.name = name;
            this.date = DateTime.Now;
            this.lastState = lastState;
        }

        public DateTime GetDate()
        {
            return this.date;
        }

        public ItemContext GetLastState()
        {
            return this.lastState;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
