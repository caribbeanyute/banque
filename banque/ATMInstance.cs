using System;
namespace banque
{
    internal class ATMInstance
    {
        private void PrintMenu()
        {
            Console.WriteLine("\n \n Choose an option \n" +
                "1. Withdraw \n" +
                "2. Deposit \n" +
                "3. Check Balance \n" +
                "4. Exit");
        }

        private void ClrScr()
        {
            Console.Clear();
        }

        private void handleDeposit(Account acc)
        {
            Console.WriteLine("Please enter the amount you'd like to deposit");
            try
            {
                // Validating amount
                string amount = Console.ReadLine();
                bool isValidAmount = Utilities.ValidateDecimalString(amount);

                if (!isValidAmount)
                {
                    throw new FormatException();
                }

                decimal depositAmount = decimal.Parse(amount);
                acc.Deposit(depositAmount);
                Console.WriteLine($"Deposit of amount {amount} successful\n  your new balance is { acc.ToMoneyFormat() }");
            }
            catch(FormatException fe)
            {
                Console.WriteLine("Incorrect Format for deposit amount ");
            }
            catch(ApplicationException ae)
            {
                 
            }
            
        }

        private void handleWithdrawal(Account acc)
        {
            decimal withdrawamount = 0;
            Console.WriteLine("Please enter the amount you'd like to withdraw");
            try
            {

                // Validating amount
                string amount = Console.ReadLine();
                bool isValidAmount = Utilities.ValidateDecimalString(amount);

                if (!isValidAmount)
                {
                    throw new FormatException();
                }
                withdrawamount = decimal.Parse(amount);

                acc.Withdraw(withdrawamount);

                Console.WriteLine($"Deposit of amount {amount} successful\n your new balance is { acc.ToMoneyFormat()}");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Incorrect Format for deposit amount ");
            }
            catch (ApplicationException ae)
            {
                Console.WriteLine($"Error: {ae.Message}");

            }

        }

        private void handleCheckBalance(Account acc)

        {
            Console.WriteLine($"Your balance is {acc.ToMoneyFormat()}");
        }
        public ATMInstance()
        {
            Console.WriteLine("WELCOME TO BANQUE \n \n");

            Account custAcc = new Account();

            while (true) {
                this.PrintMenu();
                Console.WriteLine("Please select an option");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        handleWithdrawal(custAcc);
                        break;

                    case "2":
                        handleDeposit(custAcc);
                        break;
                    case "3":
                        handleCheckBalance(custAcc);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine($"Invalid option select {option} ");
                        ClrScr();
                        break;
                }

            }

            System.Console.ReadLine();
        }
    }
}