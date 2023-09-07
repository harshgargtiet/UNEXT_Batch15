
//literals , string interpolation
const myname = "Alice";
let age = 30;
age += 5;

const message = `My name is ${myname} and I am ${age} years old.`;

console.log(message);





//function parameters ,   default parameters

// function welcome(name = "Guest") {
//   console.log(`Hello, ${name}!`);
// }

const welcome = (ename = "Guest") => 
{
              console.log("Arrow fn");
              console.log(`Hello, ${ename}!`);
}

welcome(); 
welcome("John"); 




// Arrow Function
const add = (a, b) => a + b;

console.log(add);
console.log(add(10, 5));



// Lexical Scoping
const greeting = () => 
{
  const name = "John";
  return () => 
  {
    console.log(`Hello, ${name}!`);
  };
};

const greet = greeting();
console.log(greet);
 greet(); 





// Spread Operator
const arr1 = [1, 2, 3];
console.log(arr1);

const arr2 = [...arr1, 4, 5];
console.log(arr2); 



// Array Destructuring
const numbers = [1, 2, 3];
const [first, second, third] = numbers;

console.log(first); 
console.log(second);
console.log(third); 


// Object Destructuring
const person = { pname: "Alice", page: 25 };
const { dname, dage } = person;

console.log(dname); 
console.log(dage); 

