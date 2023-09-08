function add(x: number, y: number)  : number 
{
  return x + y;
}

let result = add(3, 5);
console.log(result); // Output: 8


//============
type MathFunction = (x: number, y: number) => number;

let multiply: MathFunction = (x, y) => x * y;
console.log(multiply);
console.log(multiply(1,2));


//=================
function greet(name: string, greeting: string = "Hello")
: string {
    return `${greeting}, ${name}!`;
  }
  
  let message = greet("John"); // Uses default greeting
  console.log(message);
  message = greet("John","Howdy")
  console.log(message);
  
  //====================

function abc(a: string, b: string): string;
function abc(a: number, b: number): number;
function abc(a: any, b: any): any 
{
  return a + b;
}

console.log(abc(9,7));
console.log(abc ("Hi" , "Hello"));


//=====================



