using SimplePrograms;

//default constructor
//Calculations calculations = new Calculations();

/*
Console.WriteLine("Enter 2 numbers");
double number1 = Convert.ToDouble(Console.ReadLine());
double number2 = Convert.ToDouble(Console.ReadLine());

//parameterised constructor
Calculations calculations = new
                        Calculations(number1, number2);

int ans = calculations.Addition();

Console.WriteLine(ans);
*/

/* int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());

#pragma warning disable CS8604 // Possible null reference argument.
StudentDetails studentDetails = new StudentDetails(rollno,name,address,phno);
#pragma warning restore CS8604 // Possible null reference argument.

Console.WriteLine(studentDetails.Rollno);
Console.WriteLine(studentDetails.Name);
Console.WriteLine(studentDetails.Address);
Console.WriteLine(studentDetails.Phno);
*/

/*
// Method overloading
BankDetails bankDetails = new BankDetails(12345, 111111111L, "Priya", "Inactive");

bankDetails.WelcomeMessage();

Console.WriteLine("1. Custid 2. Accno 3. Name");

int ch = Convert.ToInt32(Console.ReadLine());

switch (ch)
{
    case 1:
        bankDetails.GetAccountDetails(12345);
        break;
    case 2:
        bankDetails.GetAccountDetails(111111111L);
        break;
    case 3:
        bankDetails.GetAccountDetails("Priya");
        break;
    default: break;
}
*/


/*
// Method overloading
UpdateBankDetails updateBankDetails = new UpdateBankDetails(12345, 111111111L, "Priya", "Inactive");
updateBankDetails.WelcomeMessage(); // update message from child class and not base class

Console.WriteLine("1. Custid 2. Accno 3. Name");

int ch = Convert.ToInt32(Console.ReadLine());

switch (ch)
{
    case 1:
        updateBankDetails.GetAccountDetails(12345);
        break;
    case 2:
        updateBankDetails.GetAccountDetails(111111111L);
        break;
    case 3:
        updateBankDetails.GetAccountDetails("Priya");
        break;
    default: break;
}
*/


// Interface
Bikes olabike = new Bikes("Electric bike", "2 Stroke", 2);
Bikes thunderbird = new Bikes("RE", "Bullet", 2);

olabike.MakeSound("zzzz");
thunderbird.MakeSound("dubdub");

