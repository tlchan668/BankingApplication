using BankingLibrary;
using System;

namespace BankingApplication {
    class Program {
        static void Main(string[] args) {

            //test data
            var chk = new Account();
            chk.Deposit(100);
            chk.Withdrawl(75);

        }
    }
}
