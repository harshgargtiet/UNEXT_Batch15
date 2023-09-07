// Handling Errors (try-catch)
try {
    // This code will throw an error
    const result = 10 / 0;
    console.log("Result:", result);
    throw new Error("divide by zero");
} catch (error) {
    console.log ("Error:", error.message);
}
