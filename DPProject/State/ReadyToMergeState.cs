using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPProject.Composite;
using File = DPProject.Composite.File;

namespace DPProject.State
{
    internal class ReadyToMergeState : ItemsState
    {
        //State State;
        public ReadyToMergeState(ItemContext itemContext) : base(itemContext)
        {
        }

        public ReadyToMergeState()
        {
        }

        public void RequstReview()
        {
           
            Review review=new Review();
            review.ThisReview();
            item.State = new UnderReviewState(item);
        }

       
       

        public override string Staged(ItemContext itemContext)
        {
            return $"You can't do this action";
        }

        public override string Merged(ItemContext itemContext1, ItemContext itemContext2)
        {
            itemContext1.State=new MergedState(itemContext1);
            return $"{itemContext1.Name} goes to merged state";
        }

        public override string UnderReview(ItemContext itemContext)
        {
            return $"You can't do this action";
        }

        public override string Commited(ItemContext itemContext)
        {
            return $"You can't do this action";
        }
    }
}
