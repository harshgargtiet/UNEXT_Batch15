using SimplePrograms;

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
/*
// Encapsulation and Access Modifiers
int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());

StudentDetails studentDetails = new StudentDetails(rollno, name, address, phno);

Console.WriteLine(studentDetails.Rollno);
Console.WriteLine(studentDetails.Name);
Console.WriteLine(studentDetails.Address);
Console.WriteLine(studentDetails.Phno);
*/
/*
int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());

int mark1 = Convert.ToInt32(Console.ReadLine());
int mark2 = Convert.ToInt32(Console.ReadLine());
int mark3 = Convert.ToInt32(Console.ReadLine());

StudentMarks studentMarks = new StudentMarks(rollno, name, address, phno, mark1, mark2, mark3);

Console.WriteLine(studentMarks.Rollno);
Console.WriteLine(studentMarks.Name);
Console.WriteLine(studentMarks.Address);
Console.WriteLine(studentMarks.Phno);

studentMarks.CalculateScores();
*/
/*
BankDetails bankDetails = new BankDetails(12345, 987654321, "Vaibhava", "Inactive");
Console.WriteLine("1. Custid 2. Accno 3.Name");
int ch = Convert.ToInt32(Console.ReadLine());
switch(ch)
{

}
*/

Bikes olabike = new Bikes("Electric Bike", "2 Stroke", 2);
Bikes thunderbird = new Bikes("RE", "Bullet", 2);

olabike.MakeSound("zzzzzz");
thunderbird.MakeSound("xxxxxx");