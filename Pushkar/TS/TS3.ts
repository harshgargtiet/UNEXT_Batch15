class Student {
  private id: number;
  public name: string;
  protected age: number;

  constructor(id: number, name: string, age: number) {
    this.id = id;
    this.name = name;
    this.age = age;
  }

  // Method to display student information
  displayInfo() {
    console.log(`Student ID: ${this.id}`);
    console.log(`Student Name: ${this.name}`);
    console.log(`Student Age: ${this.age}`);
  }
}

// Creating instances of Student class
const student1 = new Student(1, "Alice", 20);
const student2 = new Student(2, "Bob", 22);

// Accessing public properties and methods
console.log(student1.name); 
student1.displayInfo();

// Attempting to access private property (will result in an error)
 //console.log(student1.id); // Error: Property 'id' is private


 //======================
// Inheritance
class CollegeStudent extends Student {
  private collegeName: string;

  constructor(id: number, name: string, age: number, collegeName: string) {
    super(id, name, age);
    this.collegeName = collegeName;
  }

  // Override the displayInfo method
  displayInfo() {
    super.displayInfo();
    // console.log(super.age); // Call the parent class method
    console.log(`College Name: ${this.collegeName}`);
  }
}

// Creating an instance of CollegeStudent
const collegeStudent = new CollegeStudent(3, "Charlie", 21, "XYZ College");

// Accessing properties and methods from the base class
console.log(collegeStudent.name); // Output: Charlie
collegeStudent.displayInfo();

// Attempting to access protected property (can be accessed in derived classes)
 //console.log(collegeStudent.age); // Error: Property 'age' is protected


//=======================

class MathUtil {
    static PI: number = 3.14159;
  
    static add(x: number, y: number): number {
      return x + y;
    }
  }
  
  console.log(MathUtil.PI);
  let sum = MathUtil.add(5, 3);
  console.log(sum);

  //==============

  