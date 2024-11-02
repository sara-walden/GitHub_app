using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPProject.Composite;

namespace DPProject.State
{
    internal class DraftState : ItemsState
    {
        private Branch branch;

        public DraftState(ItemContext item) : base(item)
        {
        }

        public DraftState()
        {
            
        }

        public override string Commited(ItemContext itemContext)
        {
            return $"You can't do this action";
        }
        public override string Merged(ItemContext itemContext1, ItemContext itemContext2)
        {
            return $"You can't do this action";
        }

       
        public override string Staged(ItemContext itemContext)
        {
            itemContext.State = new StagedState(itemContext);
            return $"The {itemContext.Name} goes to staged state";
        }

   
        public override string UnderReview(ItemContext itemContext)
        {
            return $"You can't do this action";
        }
    }
}
