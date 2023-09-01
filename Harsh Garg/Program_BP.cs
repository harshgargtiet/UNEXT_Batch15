using Basic_Programs;
using System.Drawing;

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
//Encapsulation
/*int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());

//Parameterised constructor
StudentDetails studentDetails = new StudentDetails(rollno, name, address,phno);
Console.WriteLine(studentDetails.Rollno);
Console.WriteLine(studentDetails.Name);
Console.WriteLine(studentDetails.Address);
Console.WriteLine(studentDetails.Phno);*/

//Inheritance
/*int rollno = Convert.ToInt32(Console.ReadLine());
string? name = Console.ReadLine();
string? address = Console.ReadLine();
long phno = Convert.ToInt64(Console.ReadLine());
int mark1= Convert.ToInt32(Console.ReadLine());
int mark2= Convert.ToInt32(Console.ReadLine());
int mark3= Convert.ToInt32(Console.ReadLine());

//Parameterised constructor
StudentGrades studentgrades= new StudentGrades(rollno,name,address,phno,mark1,mark2,mark3,"");
Console.WriteLine(studentgrades.Rollno);
Console.WriteLine(studentgrades.Name);
Console.WriteLine(studentgrades.Address);
Console.WriteLine(studentgrades.Phno);
//studentMarks.CalculatedScore();
Console.WriteLine(studentgrades.CalculatedAvg());
Console.WriteLine(studentgrades.CalculatedTotal());
studentgrades.CalculateGrade();*/

//POLYMORPHISM (Method Overloading & Method Overriding)
/*
UpdateBankDetails bankDetails=new UpdateBankDetails(1234,67000032183L,"Shaurya","Inactive");
bankDetails.WelcomeMessage();
Console.WriteLine("1. CustID  2. Acc No. 3. Name");
int ch = Convert.ToInt32(Console.ReadLine());

switch(ch)
{
    case 1:
        bankDetails.GetAccountDetails(1234);
        break;
    case 2:
        bankDetails.GetAccountDetails(67000032183L);
        break;
    case 3:
        bankDetails.GetAccountDetails("Shaurya");
        break;
}

Bikes olabike = new Bikes("Electric Bike","2 Stroke",2);
Bikes thunderbird = new Bikes("RE", "Bullet", 2);
olabike.makeSound("zzzzzzzz");
thunderbird.makeSound("DugDugDugDug");

//Exception
try
{
    BankAccount account = new BankAccount("1234567890", 1000);
    Console.WriteLine($"Account Number: {account.GetAccountNumber()}, Balance: {account.GetBalance()}");

    account.Withdraw(500);
    Console.WriteLine($"Withdraw 500, Balance: {account.GetBalance()}");

    account.Deposit(200);
    Console.WriteLine($"Deposit 200, Balance: {account.GetBalance()}");

    account.Withdraw(2000);
}
catch (Exception ex)
{
    Console.WriteLine($"Exception: {ex.Message}");
}
*/
//Assignment - 1 [30/08/23]
/*Dog dog = new Dog("Tyson",12);
dog.MakeSound();
Cat cat = new Cat("HelloKitty",7);
cat.MakeSound();
Bird bird = new Bird("Tweety",5);
bird.MakeSound();*/
//Assignment - 2 [30/08/23]
/*Reactangle rectangle = new Reactangle("Dabba", 22.7);
rectangle.GetInfo();
Circle circle = new Circle("Roti", 12);
circle.GetInfo();
*/
// ARRAYS
//ArrayManipulations arrayManipulations = new ArrayManipulations();
//arrayManipulations.disp1d();
//arrayManipulations.disp2d();
//arrayManipulations.dispJA();

//FILE HANDLING
//FileHandling fileHandling = new FileHandling();
//fileHandling.CreateFile();
//fileHandling.WriteData();
//fileHandling.ReadData();
//fileHandling.FileProperties();
//fileHandling.CopyMoveFile();
//fileHandling.DeleteFile();

//NON GENERIC COLLECTIONS
//NonGenericCollections nonGenericCollections=new NonGenericCollections();
//nonGenericCollections.ArrayListElements();
//nonGenericCollections.StackElements();
//nonGenericCollections.QueueElements();
//nonGenericCollections.HashElements();
//nonGenericCollections.SortedListElements();

//GENERIC COLLECTIONS
GenericCollection genericCollection = new GenericCollection();
//genericCollection.ListElements();
//genericCollection.StackElements();
//genericCollection.QueueElements();
//genericCollection.HashElements();
genericCollection.SortedListElements();
