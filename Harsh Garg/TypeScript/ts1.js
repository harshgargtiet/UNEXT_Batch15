// let mynumber = 42; 
// let mystring = "Hello, TypeScript!"; 
// console.log(mynumber + "   " + mystring)
//=================
// let n1  = 42;
// let s1  = "Hello!";
// let b1  = true;
// console.log(n1 + "   " + s1)
// let myNumber = "Hi";
//console.log(myNumber )
//==================
var numbers = [1, 2, 3, 4];
var strings = ["apple", "banana", "cherry"];
console.log(numbers + "   " + strings);
// //=====================
var mydata = ["John", 25];
console.log(mydata);
// //====================
var Color;
(function (Color) {
    Color[Color["Red"] = 0] = "Red";
    Color[Color["Green"] = 1] = "Green";
    Color[Color["Blue"] = 2] = "Blue";
})(Color || (Color = {}));
var selectedColor = Color.Green;
console.log(selectedColor); //(enums are zero-based by default)
