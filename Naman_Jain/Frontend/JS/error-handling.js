// Handling Errors (try-catch)
try {
    // This code will throw an error
    const result = 10 / 0.00000000000000;
    console.log("Result:", result);
    throw EvalError("Yo Error");
} catch (error) {
    console.error("Error:", error.message);
    alert(error.message)
}
