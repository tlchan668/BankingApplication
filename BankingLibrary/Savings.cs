using System;
using System.Collections.Generic;
using System.Text;

namespace BankingLibrary {
    public class Savings :InterestAccount{

        private void setDesc(string desc) {
            this.Desc = desc;
        }

        public Savings(double interestRate) : base(interestRate){
            setDesc("Savings");//if don't use set desc method here then would not get set
        }

        public Savings() : base() {//default constructor and need to join to parent constructor
            //would not get acct# generated or constructors initialized
            this.Desc = "Savings";
            setDesc("Savings");
        }
       
    }
}
