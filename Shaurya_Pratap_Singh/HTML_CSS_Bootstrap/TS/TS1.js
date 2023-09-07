var mynumber = 42;
var mystring = "Hello, TypeScript!";
console.log(mynumber + "   " + mystring);
//=================
var n1 = 42;
var s1 = "Hello!";
var b1 = true;
console.log(n1 + "   " + s1);
var myNumber = "Hi";
console.log(myNumber);
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
