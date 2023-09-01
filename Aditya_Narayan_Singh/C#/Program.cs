using SimplePrograms;
/*
//default constructor
//Calculations calculations = new Calculations();


Console.WriteLine("Enter 2 numbers");
double number1 = Convert.ToDouble(Console.ReadLine());
double number2 = Convert.ToDouble(Console.ReadLine());

//parameterised constructor
Calculations calculations = new
                        Calculations(number1, number2);



/*int ans = calculations.Addition();

Console.WriteLine(ans);
/*
int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());

// parameterised constructor
#pragma warning disable CS8604 // Possible null reference argument.
StudentDetails studentdetails = new StudentDetails(rollno,
    name, address, phno);
#pragma warning restore CS8604 // Possible null reference argument.

Console.WriteLine(studentdetails.Rollno);
Console.WriteLine(studentdetails.Name);
Console.WriteLine(studentdetails.Address);
Console.WriteLine(studentdetails.Phno);
*/

/*
//Inheritence
int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());

int mark1 = Convert.ToInt32(Console.ReadLine());
int mark2 = Convert.ToInt32(Console.ReadLine());
int mark3 = Convert.ToInt32(Console.ReadLine());

StudentMarks studentsMarks = new StudentMarks(rollno, 
    name, address, phno, mark1, mark2, mark3);

Console.WriteLine(studentsMarks.Rollno);
Console.WriteLine(studentsMarks.Name);
Console.WriteLine(studentsMarks.Address);
Console.WriteLine(studentsMarks.Phno);

studentsMarks.CalculateScores();
*/

/*
// Multilevel inheritance

int rollno = Convert.ToInt32(Console.ReadLine());

string? name = Console.ReadLine();

string? address = Console.ReadLine();

long phno = Convert.ToInt64(Console.ReadLine());



int mark1 = Convert.ToInt32(Console.ReadLine());

int mark2 = Convert.ToInt32(Console.ReadLine());

int mark3 = Convert.ToInt32(Console.ReadLine());



StudentGrades studentGrades = new StudentGrades(rollno, name, address, phno, mark1,

    mark2, mark3, "");



Console.WriteLine(studentGrades.Rollno);

Console.WriteLine(studentGrades.Name);

Console.WriteLine(studentGrades.Address);

Console.WriteLine(studentGrades.Phno);



Console.WriteLine(studentGrades.CalculateTotal());

Console.WriteLine(studentGrades.CalculateAverage());

Console.WriteLine(studentGrades.CalculateGrade());
*/

/*
// Method Overloading
BankDetails bankDetails = new BankDetails(12345, 987654321L,
    "Aditya", "Inactive");

bankDetails.WelcomeMessage();

Console.WriteLine("1. CustId   2. Accno    3. Name");

int ch = Convert.ToInt32(Console.ReadLine());

switch (ch)
{
    case 1:
        bankDetails.GetAccountDetails(12345);
        break;
    case 2:
        bankDetails.GetAccountDetails(987654321L);
        break;
    case 3:
        bankDetails.GetAccountDetails("Aditya");
        break;
}
*/

//Method Overriding
UpdateBankDetails updatebankDetails = new UpdateBankDetails(12345, 987654321L,
    "Aditya", "Inactive");

updatebankDetails.WelcomeMessage();

Console.WriteLine("1. CustId   2. Accno    3. Name");

int ch = Convert.ToInt32(Console.ReadLine());

switch (ch)
{
    case 1:
        updatebankDetails.GetAccountDetails(12345);
        break;
    case 2:
        updatebankDetails.GetAccountDetails(987654321L);
        break;
    case 3:
        updatebankDetails.GetAccountDetails("Aditya");
        break;
}
