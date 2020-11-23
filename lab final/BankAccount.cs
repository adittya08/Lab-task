using System;

namespace lab_final_1
{
    public abstract class BankAccount
    {

        public string AccountOwnerName { get; set; }

        public string AccountNumber { get; set; }

        public decimal AccountBalance { get; protected set; }

        protected decimal MinAccountBalance { get; set; }

        protected decimal MaxDepositAmount { get; set; }

        protected decimal InteresetRate { get; set; }

        protected string TransactionSummary { get; set; }

        protected BankAccount(string accountOwnerName, string accountNumber)
        {
            AccountOwnerName = accountOwnerName;
            AccountNumber = accountNumber;
            TransactionSummary = string.Empty;
        }

        public abstract void Deposit(decimal amount);

        public abstract void Withdraw(decimal amount);

        public decimal CalculateInterest()
        {
            return (this.AccountBalance * this.InteresetRate) / 100;
        }

        public virtual void GenerateAccountReport()
        {
            Console.WriteLine("Account Owner:{0}, Account Number:{1}, AccountBalance:{2}",
                this.AccountOwnerName, this.AccountNumber, this.AccountBalance);

            Console.WriteLine("Interest Amount:{0}", CalculateInterest());
            Console.WriteLine("{0}", this.TransactionSummary);
        }

        public class SavingBankAccount : BankAccount
        {
            protected int withdrawCount = 0;

            public SavingBankAccount(string accountOwnerName, string accountNumber)
                : base(accountOwnerName, accountNumber)
            {
                this.MinAccountBalance = 500m;
                this.MaxDepositAmount = 500000m;
                InteresetRate = 3.5m;
            }

            public override void Deposit(decimal amount)
            {
                if (amount >= MaxDepositAmount)
                {
                    throw new Exception(string.Format("You can not deposit amount greater than { 0 }", MaxDepositAmount.ToString()));
                }

                AccountBalance = AccountBalance + amount;

                TransactionSummary = string.Format("{0}\n Deposit:{1}",TransactionSummary, amount);
            }

            public override void Withdraw(decimal amount)
            {
                if (withdrawCount > 10)
                {
                    throw new Exception("You can not withdraw amount more than thrice");
                }

                if (AccountBalance - amount <= MinAccountBalance)
                {
                    throw new Exception("You can not withdraw amount from your Savings Account as Minimum Balance limit is reached");
                }

                AccountBalance = AccountBalance - amount;
                withdrawCount++;

                TransactionSummary = string.Format("{0}\n Withdraw:{1}",TransactionSummary, amount);
            }
           

            public class CurrentBankAccount : BankAccount
            {
                public CurrentBankAccount(string accountOwnerName, string accountNumber): base(accountOwnerName, accountNumber)
                {
                    this.MinAccountBalance = 0m;
                    this.MaxDepositAmount = 100000000m;
                    InteresetRate = .25m;
                }

                public override void Deposit(decimal amount)
                {
                    AccountBalance = AccountBalance + amount;
                    TransactionSummary = string.Format("{0}\n Deposit:{1}",TransactionSummary, amount);
                }

                public override void Withdraw(decimal amount)
                {
                    if (AccountBalance - amount <= MinAccountBalance)
                    {
                        throw new Exception("You can not withdraw amount from your Current Account as Minimum Balance limit is reached");
                    }

                    AccountBalance = AccountBalance - amount;
                    TransactionSummary = string.Format("{0}\n Withdraw:{1}",TransactionSummary, amount);
                }
               
                
            }

            public static void Main(string[] args)
            {
                BankAccount savingAccount = new SavingBankAccount("Adittya", "18386933");
                BankAccount currentAccount = new CurrentBankAccount("Arup", "183869331");

                savingAccount.Deposit(40000);
                savingAccount.Withdraw(1000);
                savingAccount.Withdraw(1000);
                savingAccount.Withdraw(1000);


                Console.WriteLine();
                currentAccount.Deposit(190000);
                currentAccount.Withdraw(1000);

                Console.ReadLine();
            }
        }
    }
}
