using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPProject.State;

namespace DPProject
{
    internal class Review
    {
        FactorsConfirms factorsConfirms=new FactorsConfirms();
        public void ThisReview() {
            factorsConfirms.TheFileIsUnderReview();

        }
    }
}
