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


int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());

// Parametrised constructor
StudentDetails studentDetails = new StudentDetails(rollno, name, address, phno);

Console.WriteLine(studentDetails.Rollno);
Console.WriteLine(studentDetails.Name);
Console.WriteLine(studentDetails.Address);
Console.WriteLine(studentDetails.Phno);
