using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DPProject
{
    internal class User
    {
        public List<Branch> BranchesList { get; set; }

        public void CreateBranch() { 
            
              Branch branch = new Branch();
              BranchesList.Add(branch);

            
        }
       
    }
}
