using DPProject.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProject.State
{
    internal abstract class ItemsState
    {
        public ItemContext item;

        protected ItemsState(ItemContext item)
        {
            this.item = item;
        }
        public ItemsState()
        {
            
        }

        public abstract string Staged(ItemContext itemContext);

        public abstract string Merged(ItemContext itemContext1, ItemContext itemContext2);

        public abstract string UnderReview(ItemContext itemContext);

        public abstract string Commited(ItemContext itemContext);

    }
}
