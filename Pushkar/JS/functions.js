// Functions and Scope
function greet(name) {
    const greeting = "Hello, " + name + "!";
    ()=>{
        console.log("HELLO  IM AN ARROW FUNCTION")
    }
    return greeting;
}

const message = greet("John");
console.log(message);


