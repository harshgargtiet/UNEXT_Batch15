// Function to cause a TypeError
function causeTypeError() {
    const obj = null;
    obj.someMethod(); // Accessing a property or method of null
}

// Function to cause a ReferenceError
function causeReferenceError() {
    var y;
    const x = y; // Using an undefined variable
    console.log(x,y);
}

// Function to cause a SyntaxError
function causeSyntaxError() {
    eval("alert('Hello, world!');"); // Using eval() with a string that contains an illegal statement
}
