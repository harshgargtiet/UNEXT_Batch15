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

// Optional: Function to remove an element
function removeElement(elementId) {
    const element = document.getElementById(elementId);
    if (element && element.parentNode) {
        element.parentNode.removeChild(element);
    }
}
