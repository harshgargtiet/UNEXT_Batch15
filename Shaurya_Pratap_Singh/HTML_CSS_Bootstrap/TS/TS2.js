function add(x, y) {
    return x + y;
}
var result = add(3, 5);
console.log(result); // Output: 8
var multiply = function (x, y) { return x * y; };
console.log(multiply);
console.log(multiply(1, 2));
//=================
function greet(name, greeting) {
    if (greeting === void 0) { greeting = "Hello"; }
    return "".concat(greeting, ", ").concat(name, "!");
}
var message = greet("John"); // Uses default greeting
console.log(message);
message = greet("John", "Howdy");
console.log(message);
function abc(a, b) {
    return a + b;
}
console.log(abc(9, 7));
console.log(abc("Hi", "Hello"));
//=====================
