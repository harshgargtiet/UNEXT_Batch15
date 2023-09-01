using SEShellBasicPrograms;

//default constructor 
//Calculations calculations = new Calculations();

/*
Console.WriteLine("Enter 2 numbers"); 
double number1 = Convert.ToDouble(Console.ReadLine()); 
double number2 = Convert.ToDouble(Console.ReadLine()); 

//parameterised constructor
Calculations calculations = new Calculations(number1, number2); 
int ans = calculations.Addition(); 

Console.WriteLine(ans);
*/

// ------------------------------

// Encapsulation
/*
int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());

//parameterised constructor
StudentDetails studentDetails = new StudentDetails(rollno, name, address, phno);

Console.WriteLine(studentDetails.Rollno);
Console.WriteLine(studentDetails.Name);
Console.WriteLine(studentDetails.Address);
Console.WriteLine(studentDetails.Phno);
*/


// ----------------------------------------
//Inheritance
/*
int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());
int mark1 = Convert.ToInt32(Console.ReadLine());
int mark2 = Convert.ToInt32(Console.ReadLine());
int mark3 = Convert.ToInt32(Console.ReadLine());

StudentMarks studentMarks = new StudentMarks(rollno, name, address, phno, mark1, mark2, mark3);

Console.WriteLine(studentGrades.Rollno);
Console.WriteLine(studentGrades.Name);
Console.WriteLine(studentGrades.Address);
Console.WriteLine(studentGrades.Phno);

studentGrades.CalculateScores();
*/

// -------------------------------------------
// ML Inheritance
/*
int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());

int mark1 = Convert.ToInt32(Console.ReadLine());
int mark2 = Convert.ToInt32(Console.ReadLine());
int mark3 = Convert.ToInt32(Console.ReadLine());

StudentGrades studentGrades = new StudentGrades(rollno, name, address, phno, 
    mark1, mark2, mark3, "");

Console.WriteLine(studentGrades.Rollno);
Console.WriteLine(studentGrades.Name);
Console.WriteLine(studentGrades.Address);
Console.WriteLine(studentGrades.Phno);

Console.WriteLine(studentGrades.CalculateTotal());
Console.WriteLine(studentGrades.CalculateAverage());
Console.WriteLine(studentGrades.CalculateGrade());
*/


// -----------------------------------------------------------
// Method Overloading
/*
BankDetails bankDetails = new BankDetails(12345, 9876543210, 
    "Jaishnav", "Inactive");

bankDetails.WelcomeMessage();
Console.WriteLine("1. CustID  2. AccNo  3. Name");
int ch = Convert.ToInt32(Console.ReadLine());  

switch(ch)
{
    case 1:
        bankDetails.GetAccountDetails(12345);
        break;
    case 2:
        bankDetails.GetAccountDetails(9876543210);
        break;
    case 3:
        bankDetails.GetAccountDetails("Jaishnav");
        break;
}
*/


// ----------------------------------------
//Method Overriding
/*
UpdateBankDetails updateBankDetails = new UpdateBankDetails(12345, 9876543210,
    "Jaishnav", "Inactive");

updateBankDetails.WelcomeMessage();
Console.WriteLine("1. CustID  2. AccNo  3. Name");
int ch = Convert.ToInt32(Console.ReadLine());

switch (ch)
{
    case 1:
        updateBankDetails.GetAccountDetails(12345);
        break;
    case 2:
        updateBankDetails.GetAccountDetails(9876543210);
        break;
    case 3:
        updateBankDetails.GetAccountDetails("Jaishnav");
        break;
}
*/

Bikes olabike = new Bikes("Scooter", "Motor", 2);
Bikes thunderbird = new Bikes("RE", "4 stroke", 2);

olabike.MakeSound("zzzzzz");
thunderbird.MakeSound("dubdub");
