using BankingLibrary;
using System;
using System.Collections.Generic;

namespace BankingApplication {
    class Program {
        static void Main(string[] args) {

            var sav1 = new Savings(0.01);
           // sav1.Debug();
            var sav2 = new Savings();
            //create interestaccount
            /*var int1 = new InterestAccount();
           // int1.Debug();

            var int2 = new InterestAccount(0.12);
            int2.Deposit(100);
            int2.CalculateInterest(3);
            //int2.Debug();*/
            //test data
            var chk1 = new Checking();
            chk1.Deposit(100.25m);
            chk1.Withdrawl(75.00m);
            chk1.Deposit(-10);
            chk1.Withdrawl(1000.00m);
            chk1.Deposit(0);
            chk1.Withdrawl(100.00m);

            var chk2 = new Checking();
            chk2.Deposit(200);
            chk2.Withdrawl(40);

            chk1.Debug();
            chk2.Debug();
            //transfer from checking 1 to checking 2
            chk2.Transfer(100, chk1);//give param of transfer into
            //chk1.Debug();
            //chk2.Debug();

            //polymorphism create a collection
            var accounts = new List<Account>();
            accounts.Add(sav1);
            //accounts.Add(int1);
            //accounts.Add(chk1);
            //accounts.Add(chk2);
            accounts.Add(sav1);
            

            foreach(var account in accounts) {
                Console.WriteLine(account) ;
            }
           

            
         }
    }
}
