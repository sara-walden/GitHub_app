using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProject
{
    internal class FactorsConfirms
    {
        public List<FactorsConfirms> factorsConfirms { get; set; }
        public string TheFileIsUnderReview() {
            return $"The file was checked";
                }
    }
}
