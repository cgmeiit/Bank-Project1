using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Banking_System
{
    class Program
    {
        

        static void Main(string[] args)
        {

            //transaction list - the road not taken
            //List<decimal> transactionList = new List<decimal>();
            //decimal summedBalance = transactionList.Sum();

            //BANNER, establish strinwriter file

            Console.WriteLine(Banner());

            //string text = "AccountSummary.txt";
            StreamWriter write = new StreamWriter(@"AccountSummary.txt");
            Child_Account currentBalance = new Child_Account();

            using (write)
            {
                write.WriteLine(Banner());
                write.WriteLine("");
                write.WriteLine("Account Number: " + currentBalance.AccountNumber);
                write.WriteLine("Starting balance: $" + currentBalance.Balance);
                write.WriteLine("New Balance : " + currentBalance.NewBalance);

            }

            //Main menu method
            MainMenu();


        }
        static public void MainMenu()
        {
            DateTime thisDay = DateTime.Now;
            string todaysDate = thisDay.ToString("F");
            string sbDone;

            Console.WriteLine("1 | View Victim Information");
            Console.WriteLine("2 | View Account Balance");
            Console.WriteLine("3 | Deposit Funds");
            Console.WriteLine("4 | Withdraw Funds ");
            Console.WriteLine("5 | Exit");



            int menuItem = int.Parse(Console.ReadLine());



            switch (menuItem)
            {
                case 1:

                    Console.Clear();
                    Banner();
                  //  Console.WriteLine("View Client Information");
                    //instantiated
                    Parent_Client_Class clientinfo = new Parent_Client_Class();
                    clientinfo.ViewClientInfo();
                    break;

                case 2:
                    Console.Clear();
                    Banner();
                    Console.WriteLine("VIEW ACCOUNT NUMBER AND BALANCE");
                   Child_Account vbalance = new Child_Account();
                    vbalance.ViewAccount();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("DEPOSIT FUNDS");
                    Child_Account deposit = new Child_Account();
                    deposit.Deposit1();

                    //stringbuilder, then dumping result to streamwriter
                    StringBuilder sb = new StringBuilder();
                    sb.Append(todaysDate);
                    sb.Append("\t+\t$");
                    sb.Append(deposit.LastDeposit + "\t$");
                    sb.Append(deposit.NewBalance + "\r\n");
                    sbDone = sb.ToString();
                    using (StreamWriter sw = File.AppendText(@"AccountSummary.txt"))
                    {
                        sw.WriteLine(sbDone);
                    }

                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Enter Amount To Withdraw");
                    //instantiated
                   // decimal userInput2 = decimal.Parse(Console.ReadLine());
                    Child_Account withdrawl = new Child_Account();
                    withdrawl.Withdraw1();
                   // Console.WriteLine("LastWithdrawal is " + withdrawl.Withdraw);

                    StringBuilder sbw = new StringBuilder();
                    sbw.Append(todaysDate);
                    sbw.Append("\t-\t");
                    sbw.Append(withdrawl.LastWithdrawl + "\t");
                    sbw.Append(withdrawl.LastWithdrawl + "\r\n");
                    sbDone = sbw.ToString();

                    using (StreamWriter sw = File.AppendText(@"AccountSummary.txt"))
                    {
                        sw.WriteLine(sbDone);
                    }


                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("Thank you for Banking with Broke Bank ");
                    break;
                                        
                    
                default:
                break;

            }
            

        }

        internal static void MainMenu(double accountnumber, decimal balance)
        {
            throw new NotImplementedException();
        }

        static public string Banner()
        {
            string[] header = new string[] {"+++++++++++++++++++++++", "CYNTHIA AND ERICA'S GET IN THE BACK OF LINE BANK","***********************\n" };
            StringBuilder sb = new StringBuilder();
            foreach(string value in header)
            {
                sb.Append(value);
                sb.Append("\r\n");

            }
            string headDone = sb.ToString();
            return headDone;
            

            

        }
        
        


    }
}


        

    

