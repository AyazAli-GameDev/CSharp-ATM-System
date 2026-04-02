class BankAccount
{
    //Properties for an Account
    public long AccountNumber { get; private set;}
    public string AccountHolderName { get; private set;}
    public decimal BalanceInAccount { get; private set;}
    private int AccountPinCode;


    // Creating Constructor
    public BankAccount(long accountNumber, string name, decimal initialBalance, int pinCode)
    {
        AccountNumber = accountNumber;
        AccountHolderName = name;
        BalanceInAccount = initialBalance;
        AccountPinCode = pinCode;
    }

    //Creating method that verify pincode
    public bool VerifyPinCode(int pinCode)
    {
        return AccountPinCode == pinCode;
    }

    //Creating method that deposit the money
    public void DepositAmount(decimal depositAmout)
    {
        if(depositAmout > 0)
        {
            BalanceInAccount += depositAmout;
            Console.WriteLine($"Amount Successfully deposited in your account : {depositAmout:C}. \nNew Balance in your account : {BalanceInAccount:C}.");
        }
        else
        {
            Console.WriteLine("Kindly deposit amount must be greater than 0 ....!!");
        }
    }

    //Creating method that use to withdraw the money
    public void WithdrawMoney(decimal withdrawMoney)
    {
        if(withdrawMoney > 0 && withdrawMoney <= BalanceInAccount)
        {
            BalanceInAccount -= withdrawMoney;
            Console.WriteLine($"Withdrawal successful : {withdrawMoney:C}. \nRemaining Balance in your account is : {BalanceInAccount:C}.");
        }
        else
        {
            Console.WriteLine("Insufficient balance or Invalid amount");
        }
    }

    //Method that show the user account information
    public void ShowInformation()
    {
        Console.WriteLine($"Name : {AccountHolderName}.\nAccount Number : {AccountNumber}.\nBalance : {BalanceInAccount}");
    }
}