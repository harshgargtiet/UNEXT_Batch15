// See https://aka.ms/new-console-template for more information


using BankPrograms;

BankDetails bankDetails = new BankDetails(1234, 53275668, "Vridhi", "Active");

bankDetails.WelcomeMessage();

Console.WriteLine("Check via \n 1. Customer ID \n 2. Account Number");

int ch =Convert.ToInt32(Console.ReadLine());

switch(ch)
{
    case 1:
        bankDetails.GetAccountDetails(1234);
        break;
    case 2:
        bankDetails.GetAccountDetails(5327668L);
        break;
        
}


//topics covered :
/*
 interface 
Exception 
ArgumentException 
Garbage collection 
-> throw exception from stub, catch from driver 

 * */
