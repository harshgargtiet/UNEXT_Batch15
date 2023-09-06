class MyClass {
  // Class constructor to initialize properties
  constructor(firstName, lastName, age) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
  }

  // Instance method to get full name
  getFullName() {
    return `${this.firstName} ${this.lastName}`;
  }

  // Instance method to greet
  greet() {
    console.log(`Hello, my name is ${this.getFullName()} and I am ${this.age} years old.`);
  }
  // Static property
  static species = "Homo Sapiens";

  // Static method
  static getSpecies() {
    console.log( MyClass.species);
   //console.log(this.firstName);
   return MyClass.species;
  }

  // Getter for age
  get ageInMonths() {
    return this.age * 12;
  }

  // Setter for age
  set ageInMonths(months) {
    this.age = months / 12;
  }
}


// Access static property and call static method
console.log(MyClass.species); 
console.log(MyClass.getSpecies()); 


const myobj = new MyClass("AAA", "BBB", 25);
myobj.greet();

// Use getter and setter for age
console.log(myobj.ageInMonths); 
myobj.ageInMonths = 420;
console.log(myobj.age); 
