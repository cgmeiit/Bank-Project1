using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Banking_System
{
    class Child_Account
    {
        //fields
        private decimal deposit = 0;
        private decimal withdraw =0;
        private decimal balance = 200.00M;
        private double accountNumber = 0;
        private string name = "Unemployed Professional ";
        private decimal lastDeposit = 0;
        private decimal lastWithdrawl = 0;
        private decimal newBalance = 0;
        //used private random from the crystal ball.
        private Random random = new Random();



        //properties all props may not be used just added them for Switch Case Porgram cs
        protected string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public decimal Deposit
        {
            get { return deposit; }
            set {this.deposit = value; }
        }
        public decimal Withdraw
        {
            get { return withdraw; }
            set {this.withdraw = value; }
        }
            
        public decimal Balance
        {
            get { return balance; }
            set {this.balance = value; }
        }
        public double AccountNumber
        {
            get { return accountNumber;}
            set { this.accountNumber = value; }
        }
        public decimal NewBalance
        {
            get { return newBalance; }
            set { this.newBalance = value; }
        }
        public decimal LastDeposit
        {
            get { return lastDeposit; }
            set { this.lastDeposit = value; }
        }
        public decimal LastWithdrawl
        {
            get { return lastWithdrawl; }
            set { this.lastWithdrawl = value; }
        }

        //method
        public void Withdraw1()
        {
            //ingredients: Balance, customer-inputted amount to withdraw
            //output: "success, new balance", streamwriter output.
            Console.WriteLine("Your current balance is {0}. Enter the amount to withdraw.", this.Balance);
            decimal userInput = decimal.Parse(Console.ReadLine());
            this.lastWithdrawl = userInput;
            decimal tempBalance = this.Balance;
            this.NewBalance = this.Balance - userInput;
            if (this.NewBalance < 0)
            {
                this.Balance = tempBalance;
                Console.WriteLine("Insufficient funds. Transaction cancelled.");
                Console.WriteLine("Current balance is {0}.", this.Balance);
            }
            else
            {
                this.Balance = this.NewBalance;
                Console.WriteLine("Transaction successful, current balance is {0}", this.Balance);
            }

            //redo or exit
            Console.WriteLine("Another transaction? Enter Y or N");
            char menu = char.Parse(Console.ReadLine().ToUpper());
            if (menu == 'Y')
            { Program.MainMenu(); }
            else return;
        }

        public void Deposit1()
        {
            //ingredients: Balance, customer-inputted amount to withdraw
            //output: "success, new balance", streamwriter output.
            // Console.WriteLine("Enter the amount to Deposit.",this.balance);
            //decimal userInput = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Your current balance is {0}. Enter the amount to deposit.", this.Balance);
            decimal userInput = decimal.Parse(Console.ReadLine());
            this.LastDeposit = userInput;
            this.NewBalance = this.Balance + userInput;
            this.Balance = this.NewBalance;

            Console.WriteLine("Another transaction? Enter Y or N");
            char menu = char.Parse(Console.ReadLine().ToUpper());
            if (menu == 'Y')
            { Program.MainMenu(); }
            else return;






        }
        private double assignAccount()
        {
            double AccountNum = random.Next(100000, 999999);
            return AccountNum;
        }
        protected double getAccount()
        {
            double newAccountNumber = assignAccount();
            return newAccountNumber;
        }
        public void ViewAccount()
        {

            AccountNumber = getAccount();
            // Console.WriteLine("Customer Account Information:");
            Console.WriteLine("\nCustomer {0}\n", this.Name);
            Console.WriteLine("===========================");
            Console.WriteLine("ACCOUNT #: {1}", this.Name, AccountNumber);
            Console.WriteLine("CURRENT BALANCE: ${0}", balance);
            Console.WriteLine("===========================\n");
            Console.WriteLine("Another transaction? Enter Y or N");
            char menu = char.Parse(Console.ReadLine().ToUpper());
            if (menu == 'Y')
            { Program.MainMenu(); }
            else return;
        }

        //Constructors
        public Child_Account()
        {
        }

        public Child_Account(decimal balance)
        {
            this.Balance = balance;
        }

        public Child_Account(decimal balance, double accountNumber)
        {
            this.Balance = balance;
            this.AccountNumber = accountNumber;
        }

    }







}



