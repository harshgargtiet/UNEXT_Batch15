// Function to cause a TypeError
function causeTypeError() {
    const obj = null;
    obj.someMethod(); // Accessing a property or method of null
}

// Function to cause a ReferenceError
function causeReferenceError() {
    const x = y; // Using an undefined variable
}

// Function to cause a SyntaxError
function causeSyntaxError() {
    eval("alert('Hello, world!');"); // Using eval() with a string that contains an illegal statement
}
