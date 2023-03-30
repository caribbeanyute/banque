using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Account : IAccount
    {
        public decimal AccountBalance { get; set; } = (decimal)new Random().NextDouble() * (100000 - 10) + 10;

        public void Deposit(decimal depositAmt)
        {
            if (depositAmt < 0)
            {
                throw new ApplicationException("Can deposit a negative amount");
            }
            else
            {
                AccountBalance = AccountBalance + depositAmt;
            }

        }

        public void Withdraw(decimal withdrawAmt)
        {
            if (withdrawAmt < 0)
            {
                throw new ApplicationException("Can't deposit negative amount");
            }
            else if (withdrawAmt > AccountBalance)
            {
                throw new ApplicationException($"Withdrawal amount{withdrawAmt} exceeds account balance of ${AccountBalance}");
            }
            else
            {

                AccountBalance -= withdrawAmt;
            }
        }

        public string ToMoneyFormat() => AccountBalance.ToString("C");
    }

