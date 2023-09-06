// Define an array named "fruits"
const fruits = [1,"apple", "banana", "orange", "mango", "grape"];

// Function to print fruits
function printFruits(arr) {
  for (const fruit of arr) {
    console.log(fruit);
  }
  for (const fruit in arr) {
    console.log(fruit);
  }
}

const mob = {
  0: "naman",
  1: "puskar",
  2: "will it work, normally we can't iterate objects"
}

console.log(mob[1]);
for(let item of mob) {
  console.log(item)
}

// Call the "printFruits" function with the "fruits" array
printFruits(fruits);

// Create an object named "person"
const person = {
  name: "Your Name",
  age: 25, // Your age
  city: "Your City",
};

// Function to print person info
console.log(person);
function printPersonInfo(obj) {
  for (const key in obj) {
    console.log(`${key}: ${obj[key]}`);
  }
}

// Call the "printPersonInfo" function with the "person" object
printPersonInfo(person);

// Create a new array named "numbers" containing numbers 1 to 5
const numbers = [1, 2, 3, 4, 5];
console.log("numbers :    ",numbers);

//  Add the number 6 to the end of the array
numbers.push(6);
console.log("numbers after push :    ",numbers);

//  Remove the first element from the array
numbers.shift();
console.log("numbers after shift  :    ",numbers);

// Add the number 0 to the beginning of the array
numbers.unshift(0);

//  Print the updated "numbers" array to the console
console.log("numbers after unshift :    ",numbers);

