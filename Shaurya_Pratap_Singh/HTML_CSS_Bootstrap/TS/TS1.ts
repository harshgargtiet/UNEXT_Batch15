
let mynumber = 42; 
let mystring = "Hello, TypeScript!"; 

console.log(mynumber + "   " + mystring)

//=================


let n1 : number = 42;
let s1 : string = "Hello!";
let b1 : boolean = true;

console.log(n1 + "   " + s1)

let myNumber = "Hi";
console.log(myNumber )


//==================

let numbers : number[]= [1, 2, 3, 4];
let strings = ["apple", "banana", "cherry"]; 
console.log(numbers + "   " +  strings);


// //=====================

let mydata : [string, number] = ["John", 25]; 
console.log(mydata);

// //====================

enum Color {
  Red,
  Green,
  Blue,
}

let selectedColor: Color = Color.Green;
console.log(selectedColor);    //(enums are zero-based by default)


