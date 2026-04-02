using System;

class Program
{
    static void Main(string[] args)
    {
        //Creating object of BankAccount class and assigning arguments through named parameters
        BankAccount account = new BankAccount(accountNumber: 123456, pinCode: 2256, name: "Ayaz Ali", initialBalance: 5000);

        //Now take input pinCode and verify it 
        Console.Write("ENTER PIN : ");
        int pinCode = int.Parse(Console.ReadLine());

        if (account.VerifyPinCode(pinCode))
        {
            Console.WriteLine("Login Successful!!!");

            //Menu of Bank ATM 
            while (true)
            {
                Console.WriteLine("\n---ATM MENU---\n");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Desposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option : ");

                //Taking input from user for choice
                string userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    //if user's choice is 1 then accout information method will call
                    account.ShowInformation();
                }
                else if (userChoice == "2")
                {
                    //Deposit method will be called
                    Console.Write("Enter amount to deposit : ");
                    decimal depositAmout = decimal.Parse(Console.ReadLine());
                    account.DepositAmount(depositAmout);
                }
                else if (userChoice == "3")
                {
                    //Withdraw method will be called
                    Console.Write("Enter amout to withdraw : ");
                    decimal withdrawMoney = decimal.Parse(Console.ReadLine());
                    account.WithdrawMoney(withdrawMoney);
                }
                else if (userChoice == "4")
                {
                    //Here in this block exit method will call
                    Console.WriteLine("Thanks for using our system ");
                    Console.WriteLine("Loggin out ..... !!!");
                    break;
                }
                else
                {
                    Console.WriteLine("INVALID OPTION TRY AGAIN ...");
                }
            }
        }
        else
        {
            Console.WriteLine("INVALID PIN");
        }
    }
}