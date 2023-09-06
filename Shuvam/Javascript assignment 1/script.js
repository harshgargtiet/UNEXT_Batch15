// Function to generate a random color in hexadecimal format
function getRandomColor() {
    const letters = "0123456789ABCDEF";
    let color = "#";
    for (let i = 0; i < 6; i++) {
        color += letters[Math.floor(Math.random() * 16)];
    }
    return color;
}

// Function to change the background color of a specified element to a random color
function changeColor(elementId) {
    const element = document.getElementById(elementId);
    if (element) {
        const randomColor = getRandomColor();
        element.style.backgroundColor = randomColor;
    }
}

// Function to generate random text
function getRandomText() {
    const texts = [
        "Random Text 1",
        "Random Text 2",
        "Random Text 3",
        "Lorem Ipsum",
        "JavaScript is fun",
        "Hello, World!",
    ];
    const randomIndex = Math.floor(Math.random() * texts.length);
    return texts[randomIndex];
}

// Function to change the text content of a specified element to random text
function changeText(elementId) {
    const element = document.getElementById(elementId);
    if (element) {
        const randomText = getRandomText();
        element.textContent = randomText;
    }
}

// Function to create an unordered list and append it to a specified element
function createList(elementId) {
    const element = document.getElementById(elementId);
    if (element) {
        const ul = document.createElement("ul");
        // Create list items
        const items = ["Item 1", "Item 2", "Item 3"];
        items.forEach((itemText) => {
            const li = document.createElement("li");
            li.textContent = itemText;
            ul.appendChild(li);
        });
        element.appendChild(ul);
    }
}

// Function to remove a list item from the specified element
function removeListItem(elementId) {
    const element = document.getElementById(elementId);
    if (element) {
        const ul = element.querySelector("ul"); // Find the <ul> element
        if (ul && ul.children.length > 0) {
            // Remove the first list item (you can modify this logic as needed)
            ul.removeChild(ul.children[0]);
        }
    }
}
