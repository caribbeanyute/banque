using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque
{
    class Account : IAccount
    {
        private Double accountBalance = 1000000 * new Random().NextDouble();
        public void checkBalance()
        {
            throw new NotImplementedException();
        }

        public void deposit(Double depositAmt)
        {
            if (depositAmt < 0)
            {
                throw new ApplicationException("Can deposit a negative amount");
            }
            else
            {
                accountBalance = accountBalance + depositAmt;
            }
            throw new NotImplementedException();
        }

        public void withdraw(Double withdrawAmt)
        {
            if (withdrawAmt < 0)
            {
                throw new ApplicationException("Can't deposit negative amount");
            }
            else if (withdrawAmt > accountBalance)
            {
                throw new ApplicationException("Can't deposit negative amount");
            }
            else
            {
                accountBalance -= accountBalance;
            }
            throw new NotImplementedException();
        }
    }
}
