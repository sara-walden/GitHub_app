using DPProject.Composite;
using DPProject.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProject
{
    internal class CommitedState: ItemsState
    {
        public CommitedState()
        {
        }

        public CommitedState(ItemContext item) : base(item)
        {
        }

        
        public override string Commited(ItemContext itemContext)
        {
            return $"{itemContext.Name} was commited";
        }


        public override string Merged(ItemContext itemContext1,ItemContext itemContext2)
        {
            itemContext1.State = new MergedState(itemContext1);
            return $"{itemContext1.Name} goes to merged state";
        }

        public void RequstReview()
        {

            Review review = new Review();
            review.ThisReview();
            item.State = new UnderReviewState(item);
        }

      
        public override string Staged(ItemContext itemContext)
        {
            itemContext.State = new StagedState(itemContext);
            return $"{itemContext.Name} goes to staged state";
        }
        public override string UnderReview(ItemContext itemContext)
        {
            return $"You can't do this action";
        }
    }


       

        
        
    
}
