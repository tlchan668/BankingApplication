using System;
using System.Collections.Generic;
using System.Text;

namespace BankingLibrary {
    public class InterestAccount : Account{

        public decimal InterestRate { get; private set; }

        public void CalculateInterest(int Months) {//calculate every month but pay once a quarter
            var interest = this.Balance * (this.InterestRate / 12) * Months;
            Deposit(interest);
            //Console.WriteLine($"Calculated interest is {interest}");
        }


        public InterestAccount(double interestRate) : this(){//this calling own constructor
                                                              //base calling parent constructor  
            InterestRate = Convert.ToDecimal(interestRate);
        }

        //default constructor derived class should call bass class constructor
        public InterestAccount() : base() {
            this.Desc = "Interest Account";

        }

        //have to override the toString
        public override string ToString() {
            return base.ToString() + $", Interest= {InterestRate}";
            //or return $"{base.ToString(), Interest={InterestRate}";
           
        }
    }
}
