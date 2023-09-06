// Handling Errors (try-catch)
try {
    // This code will throw an error
    const result = 10 / 0;
    console.log("Result:", result);
    throw EvalError("Trial Err");
} catch (error) {
    console.error("Error:" + error.message);
}
