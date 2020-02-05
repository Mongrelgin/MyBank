using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBankLib;

namespace MyBank
{
    class MyBank
    {
        static void Main(string[] args)
        {
            var AccFirst = new BankAccount("Ivan", 50000);
            Console.WriteLine($"Account {AccFirst.Number} was created for {AccFirst.Owner} with {AccFirst.Balance}");
            AccFirst.MakeDeposit(2000, DateTime.Now, "Present");
            AccFirst.MakeWithdrawal(17000, DateTime.Now, "Watch");
            Console.WriteLine(AccFirst.GetAccountHistory());
            Console.WriteLine(AccFirst.Balance);
            Console.ReadKey();
        }
    }
}
