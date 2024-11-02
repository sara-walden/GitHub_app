using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPProject.Composite;

namespace DPProject.State
{
    internal class StagedState : ItemsState
    {
        public StagedState()
        {
        }

        public StagedState(ItemContext itemContext) : base(itemContext)
        {
        }

        public override string Commited(ItemContext itemContext)
        {

            itemContext.State = new CommitedState(itemContext);
            return $"{itemContext.Name} goes to commited state";
        }

        
        public override string Merged(ItemContext itemContext1, ItemContext itemContext2)
        {
            return $"You can't do this action";
        }

        
        public override string Staged(ItemContext itemContext)
        {
            return $"{itemContext.Name} was staged";
        }

       

        public override string UnderReview(ItemContext itemContext)
        {
            return $"You can't do this action";
        }
    }
}
