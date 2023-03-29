using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque
{
   internal interface IAccount
    {
        void withdraw();
        void deposit();

        void checkBalance();


    }
}
