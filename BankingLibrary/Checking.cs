using System;
using System.Collections.Generic;
using System.Text;
using BankingLibrary;

namespace BankingLibrary {
    public class Checking {

        public InterestAccount iacct { get; private set; }//using composition don't inherit methods so create methods

        public int checkNbr { get; private set; }

        public void Deposit(decimal amount) {
            //let interest acct to the deposit
            //these were not in constructors
            iacct.Deposit(amount);
        }

        public bool Withdrawl(decimal amount) {
            checkNbr++;
            return iacct.Withdrawl(amount);
        }

        public void Transfer(decimal amount, Account toAcct) {
            iacct.Transfer(amount, toAcct);
        }

        public void Transfer (decimal amount, Checking toAcct) {
            iacct.Transfer(amount, toAcct.iacct);
        }
        public Checking(double intRate) {
            iacct = new InterestAccount(intRate);
            iacct.Desc = "Checking";
        }
        public Checking() : this(0.02){//use our constructor to create an instance of interest  
            //iacct = new InterestAccount(0.02);//represents a default value
            //want this constructor to call other one so put this

        }

        public void Debug() {
            Console.WriteLine($"checking acct={iacct}");
            Console.WriteLine(this.ToString());
        }
    }
}
