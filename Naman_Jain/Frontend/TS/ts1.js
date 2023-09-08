{
    var mynumber = 42;
    var mystring = "Hello , typescript";
    console.log("my nuimber", mynumber);
    console.log("my string", mystring);
}
// let mynumber = "hello"
// console.log("my nuimber outside",mynumber);
var numbers = [1, 2, 3, 4];
var strings = ["apple", "banan", "cherry"];
//
// tuple 
var mydata = ["hello", 42];
// enumerated type
var Color;
(function (Color) {
    Color[Color["Red"] = 0] = "Red";
    Color[Color["Green"] = 1] = "Green";
    Color[Color["Blue"] = 2] = "Blue";
})(Color || (Color = {}));
var selectedColor = Color.Green;
console.log(selectedColor);
// functions is typescript
function add(x, y) {
    return x + y;
}
var result = add(3, 5);
console.log(result);
var Multiply = function (x, y) { return x * y; };
console.log("multiply", Multiply(3, 5));
console.log("typeof multip;ly", typeof (Multiply));
// function with default values
function greet(name, greeting) {
    if (greeting === void 0) { greeting = "Hello"; }
    return "".concat(greeting, ", ").concat(name, "!");
}
var message = greet("John"); // Uses default greeting
message = greet("John", "Howdy");
function abc(a, b) {
    return a + b;
}
abc(9, 7);
abc("Hi", "Hello");
