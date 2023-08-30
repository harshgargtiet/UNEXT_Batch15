using ShellSECustom; //default constructor
//Calculations calculations = new Calculations();

/*Console.WriteLine("Enter 2 numbers");
double number1 = Convert.ToDouble(Console.ReadLine()); 
double number2 = Convert.ToDouble(Console.ReadLine()); 
//parameterised constructor
Calculations calculations = new Calculations(number1, number2); 
int ans = calculations.Addition(); 
Console.WriteLine(ans);*/


//Encapsulation

/*int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine(); 
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());


StudentDetails studentDetails = new StudentDetails(rollno, name, address, phno);

Console.WriteLine(studentDetails.Name);
Console.WriteLine(studentDetails.Address);
Console.WriteLine(studentDetails.Rollno);
Console.WriteLine(studentDetails.Phno);*/

//Inheritance



/*int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());
int m1 = Convert.ToInt32(Console.ReadLine());
int m2 = Convert.ToInt32(Console.ReadLine());
int m3 = Convert.ToInt32(Console.ReadLine());


StudentMarks studentMarks = new StudentMarks(rollno, name, address, phno, m1, m2, m3);


Console.WriteLine(studentMarks.Name);
Console.WriteLine(studentMarks.Address);
Console.WriteLine(studentMarks.Rollno);
Console.WriteLine(studentMarks.Phno);
studentMarks.CalculateScores();*/



//grade class

int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());
int m1 = Convert.ToInt32(Console.ReadLine());
int m2 = Convert.ToInt32(Console.ReadLine());
int m3 = Convert.ToInt32(Console.ReadLine());


Grades studentGrade = new Grades(rollno, name, address, phno, m1, m2, m3, "");


Console.WriteLine(studentGrade.Name);
Console.WriteLine(studentGrade.Address);
Console.WriteLine(studentGrade.Rollno);
Console.WriteLine(studentGrade.Phno);

Console.WriteLine(studentGrade.CalculateTotal());
Console.WriteLine(studentGrade.CalculateAverage());
Console.WriteLine(studentGrade.CalculateGrade());


