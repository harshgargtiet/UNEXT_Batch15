 // Function to change the background color of a specified element
 function changeColor(elementId, color) {
    var element = document.getElementById(elementId);
    if (element) {
        element.style.backgroundColor = 'red';
    } else {
        console.error("Element with ID '" + elementId + "' not found.");
    }
}

// Function to add text content to a specified element
function addText(elementId, text) {
    var element = document.getElementById(elementId);
    if (element) {
        element.textContent = 'Mahender';
    } else {
        console.error("Element with ID '" + elementId + "' not found.");
    }
}

// Function to create an unordered list and append it to a specified element
function createList(elementId) {
    var element = document.getElementById(elementId);
    if (element) {
        var ul = document.createElement("ul");
        ul.innerHTML = "<li>List Item 1</li><li>List Item 2</li><li>List Item 3</li>";
        element.appendChild(ul);
    } else {
        console.error("Element with ID '" + elementId + "' not found.");
    }
}

// Change the background color of the target element
changeColor("targetElement", "darkblue");

// Add text to the text element
addText("textElement", "This is some text.");

// Create an unordered list and append it to the list element
createList("listElement");