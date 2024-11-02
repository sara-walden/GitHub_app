using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPProject.Composite;

namespace DPProject.State
{
    internal class MergedState : ItemsState
    {
        public MergedState()
        {
        }

        public MergedState(ItemContext itemContext) : base(itemContext)
        {
        }

        public override string Commited(ItemContext itemContext)
        {
            return $"{itemContext.Name} is commited";
        }

        public override string Merged(ItemContext itemContext1, ItemContext itemContext2)
        {
            itemContext1.State=new ReadyToMergeState(itemContext1);
            return $"{itemContext1.Name} is ready to merge";
        }

        public override string Staged(ItemContext itemContext)
        {
            return $"You can't do this action";
        }

       
        public override string UnderReview(ItemContext itemContext)
        {
            return $"You can't do this action";
        }
    }
}
