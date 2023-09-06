// Function to change the background color of a specified element
function changeColor(elementId, color) {
    const element = document.getElementById(elementId);
    if (element) {
        element.style.backgroundColor = color;
    }
}

// Function to add text content to a specified element
function addText(elementId, text) {
    const element = document.getElementById(elementId);
    if (element) {
        element.textContent = text;
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
