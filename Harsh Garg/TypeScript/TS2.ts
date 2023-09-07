function add(x: number, y: number)  : number 
{
  return x + y;
}

let result = add(3, 5);
console.log(result); // Output: 8


//============
type MathFunction = (x: number, y: number) => number;

let multiply: MathFunction = (x, y) => x * y;

//=================
function greet(name: string, greeting: string = "Hello")
: string {
    return `${greeting}, ${name}!`;
  }
  
  let message = greet("John"); // Uses default greeting
  message = greet("John","Howdy")
  
  //====================

function abc(a: string, b: string): string;
function abc(a: number, b: number): number;
function abc(a: any, b: any): any 
{
  return a + b;
}

abc(9,7);
abc ("Hi" , "Hello");


//=====================



