using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17
{
    public class CalculateUsualInterest : ICalculateInterest
    {
        public double CalculateInterest(Account account)
        {
            double Interest = account.Balance * 0.4;


            if (account.Balance < 1000)
                Interest -= account.Balance * 0.2;

            if (account.Balance < 50000)
                Interest -= account.Balance * 0.4;

            return Interest;
            
        }
    }
}
