using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    class Parent_Client_Class
    {   //fields
        private string name = ("Unemployed Professional ");
        private string address = ("2222 Need Work St Cleveland Ohio 44411 ");
        private string accountOpened = ("April 13 2013");
        

        //Properties 
        public string Name
        {
            get { return name; }
            set {this.name = value; }
        }
        public string Address
        {
            get { return address; }
            set { this.address = value; }
        }
        public string AccountOpened
        {
            get { return accountOpened; }
            set {this.accountOpened = value; }
        }
        

        //method
        public void ViewClientInfo()
        {
            Console.WriteLine("Information for Client\n{0}" + "\n{1}" + "\nDate Accounted Opened:\n{2}", this.name, this.address, this.accountOpened);

            
            Console.WriteLine("Another transaction? Enter Y or N");
            char menu = char.Parse(Console.ReadLine().ToUpper());
            if (menu == 'Y')
             { Program.MainMenu(); } 
            else return;
        }

        //constructor
        public Parent_Client_Class()
        {
            //default 
                 
        }
        public Parent_Client_Class(string name)
        {
            this.Name = name;

        }
        public Parent_Client_Class(string name,string address)
        {
            this.Name = name;
            this.Address = address;


        }
        public Parent_Client_Class(string name,string address,string accountOpened)
        {
            this.Name = name;
            this.Address = address;
            this.AccountOpened = accountOpened;

        }

    }
}
