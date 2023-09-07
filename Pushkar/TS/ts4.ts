
  // Define an interface for a student
interface Student {
    id: number;
    name: string;
    age: number;
    displayInfo(): void;
  }
  
  // Create an abstract class that implements the Student interface
  abstract class AbstractStudent implements Student {
    constructor(public id: number, public name: string, public age: number) {}
  
    // Implement the displayInfo method required by the interface
    displayInfo() {
      console.log(`Student ID: ${this.id}`);
      console.log(`Student Name: ${this.name}`);
      console.log(`Student Age: ${this.age}`);
    }
  
    // Abstract method that must be implemented by subclasses
    abstract study(): void;
  }
  
  // Create a concrete class that extends the abstract class
  class CollegeStudent extends AbstractStudent {
    constructor(id: number, name: string, age: number, public collegeName: string) {
      super(id, name, age);
    }
  
    // Implement the abstract study method
    study() {
      console.log(`${this.name} is studying at ${this.collegeName}`);
    }
  }
  
  // Create an instance of the CollegeStudent class
  const student = new CollegeStudent(1, "Alice", 20, "XYZ College");
  
  // Access properties and methods
  student.displayInfo();
  student.study();
  

