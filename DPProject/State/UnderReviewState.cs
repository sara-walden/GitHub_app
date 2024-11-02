using DPProject.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProject.State
{
    internal class UnderReviewState : ItemsState
    {
        public UnderReviewState(ItemContext itemContext) : base(itemContext)
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
            return $"You can't do this action";
        }

        public override string UnderReview(ItemContext itemContext)
        {
            return "This file is under review";
        }

    }
}
