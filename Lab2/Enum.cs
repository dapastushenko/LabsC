using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public enum AccountType
    {
        Checking,
        Deposit

    }
    class Enum
    {
        static void Main(string[] args)
        {
            //Accounts();
            Struct.WLToConsole();
            StructWOut.WLToConsole();

        }

        static void Accounts()
        {
            AccountType goldAccount;
            AccountType platinumAccount;

            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;

            Console.WriteLine("The Customer Account Type is {0}", goldAccount);
            Console.WriteLine("The Customer Account Type is {0}", platinumAccount);
            Console.ReadKey();
        }
    }

    public class Struct
    {
        public enum AccountType
        {
            Checking,
            Deposit
        }

        struct BankAccount
        {
            public long accNo;
            public decimal accBal;
            public AccountType accType;
        }

        public static void WLToConsole()
        {
            BankAccount goldAccount;

            goldAccount.accType = AccountType.Checking;
            goldAccount.accBal = (decimal)3200.00;
            goldAccount.accNo = 123;

            Console.WriteLine("*** Account Summary ***");
            Console.WriteLine("Acct Number {0}", goldAccount.accNo);
            Console.WriteLine("Acct Type {0}", goldAccount.accType);
            Console.WriteLine("Acct Balance ${0}", goldAccount.accBal);
            Console.WriteLine("Enter any key");
            Console.ReadKey();

        }
    }

    public class StructWOut
    {
        public enum AccountType
        {
            Checking,
            Deposit
        }

        struct BankAccount
        {
            public long accNo;
            public decimal accBal;
            public AccountType accType;
        }

        public static void WLToConsole()
        {
            BankAccount goldAccount;

            goldAccount.accType = AccountType.Checking;
            goldAccount.accBal = (decimal)3200.00;
            Console.Write("Enter account number: ");
            goldAccount.accNo = long.Parse(Console.ReadLine());

            Console.WriteLine("*** Account Summary ***");
            Console.WriteLine("Acct Number {0}", goldAccount.accNo);
            Console.WriteLine("Acct Type {0}", goldAccount.accType);
            Console.WriteLine("Acct Balance ${0}", goldAccount.accBal);
            Console.WriteLine("Enter any key");
            Console.ReadKey();

        }
    }
}

