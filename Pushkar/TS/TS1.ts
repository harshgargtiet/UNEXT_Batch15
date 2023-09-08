
{
let mynumber: number  = 42;
let mystring= "Hello , typescript"

console.log("my nuimber",mynumber);
console.log("my string",mystring);
}

// let mynumber = "hello"
// console.log("my nuimber outside",mynumber);

let numbers : number[]=[1,2,3,4];
let strings = ["apple","banan","cherry"];
//
// tuple 
let mydata :[string , number ]=["hello",42];
// enumerated type

enum Color{
    Red,
    Green,
    Blue,
}

let selectedColor: Color = Color.Green;
console.log(selectedColor);

// functions is typescript

function add(x: number,y:number):number{
    return x+y;
}

let result = add(3,5);
console.log(result);

// type is ;like class 
type MathFunction = (x: number, y : number )=> number;
let Multiply : MathFunction= (x,y)=> x*y;
console.log("multiply",Multiply(3,5));
console.log("typeof multip;ly", typeof(Multiply))

// function with default values
function greet(name: string, greeting: string = "Hello")
: string {
    return `${greeting}, ${name}!`;
  }
  
  let message = greet("John"); // Uses default greeting
  message = greet("John","Howdy")

  // function overloading
function abc(a: string, b: string): string;
function abc(a: number, b: number): number;
function abc(a: any, b: any): any 
{
  return a + b;
}

abc(9,7);
abc ("Hi" , "Hello");