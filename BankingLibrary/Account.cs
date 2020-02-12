using System;

namespace BankingLibrary {
    public class Account {

       
        public string AccountNumber { get; set; }
        public string Desc { get; set; }
        public decimal Balance { get; set; }
        
        public void Deposit(decimal amount) {
            Balance += amount;

        }
        public void Withdrawl(decimal amount) {
            Balance -= amount;

        }
        public void Transfer(decimal amount, Account toAcct, Account fromAcct) {
            //withdrawl from acct
            fromAcct.Withdrawl(amount);
            toAcct.Deposit(amount);

        }

        public Account() { }//constructor

    }
}
