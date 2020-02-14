using System;

namespace BankingLibrary {
    public abstract class Account {

        private static int NextAcctNbr = 1;
        private const int AcctNbrInc = 9;//can't change stays the same

        public int AccountNumber { get; private set; }//no one outside class can change 
        public string Desc { get; set; } = "Account";
        public decimal Balance { get; set; }

        private int AttemptsToOverdraw = 0;


        
        private bool CheckAmountGTZero(decimal amount) {
            /*if (amount <= 0) {
                return false;
            }
            return true;*/
            //actual way Greg would do ternary operator
            return (amount <= 0) ? false : true;


        }
        public void Deposit(decimal amount) {
            /*if (amount <= 0) {
                return;
            } should use method*/
            if (CheckAmountGTZero(amount)) {

                Balance += amount;
            }
        }   
        private bool IsSufficientFunds(decimal amount) {
            //return (Balance >= amount) ? true : false;
            //if wanted to keep count could not use ternary above
            if (Balance >= amount) {
                return true;
            }
            AttemptsToOverdraw++;
            return false;
        }
        public bool Withdrawl(decimal amount) {
           
            if (CheckAmountGTZero(amount)&&IsSufficientFunds(amount)) { 
                Balance -= amount;
                return true;
            }
            return false;
        }

        public void Transfer(decimal amount, Account toAcct) {

            if (this.Withdrawl(amount)) {//this will execute only if do withdrawl
                toAcct.Deposit(amount);
            }
        }

        //display the contents
        public void Debug() {
            Console.WriteLine(this.ToString());//refering to an instance 
        }

        //print an end of month balance list
        public override string ToString() {
            return $"AcctNbr ={AccountNumber}, Desc={Desc}, Bal={Balance}";
        }

        public Account() { //constructor
                           //assign your acct number
            this.AccountNumber = NextAcctNbr;
            NextAcctNbr += AcctNbrInc;
        }
            

    }
}
