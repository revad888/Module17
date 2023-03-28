using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17
{
    internal class CalculateCorpAccountInterest : ICalculateInterest
    {
        public double CalculateInterest(Account account)
        {
            double Interest = account.Balance * 0.5;
            
            return Interest;
            
        }
    }
}
