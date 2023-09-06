// Function to change the background color of a specified element to a random color
function changeColor(elementId) {
    try {
        const element = document.getElementById(elementId);
        if (element) {
            const randomColor = getRandomColor();
            element.style.backgroundColor = randomColor;
        } else {
            throw new Error(`Element with ID '${elementId}' not found.`);
        }
    } catch (error) {
        console.error(error);
    }
}

// Function to generate a random color
function getRandomColor() {
    const letters = '0123456789ABCDEF';
    let color = '#';
    for (let i = 0; i < 6; i++) {
        color += letters[Math.floor(Math.random() * 16)];
    }
    return color;
}

// Function to add text content to a specified element
function addText(elementId, text) {
    try {
        const element = document.getElementById(elementId);
        if (element) {
            element.textContent = text;
        } else {
            throw new Error(`Element with ID '${elementId}' not found.`);
        }
    } catch (error) {
        console.error(error);
    }
}

// Function to add an unordered list to a specified element
function createList(elementId) {
    try {
        const ul = document.createElement('ul');
        ul.innerHTML = '<li>List Item 1</li><li>List Item 2</li><li>List Item 3</li>';

        const element = document.getElementById(elementId);
        if (element) {
            element.appendChild(ul);
        } else {
            throw new Error(`Element with ID '${elementId}' not found.`);
        }
    } catch (error) {
        console.error(error);
    }
}

// Function to remove text content from a specified element
function removeText(elementId) {
    try {
        const element = document.getElementById(elementId);
        if (element) {
            element.textContent = '';
        } else {
            throw new Error(`Element with ID '${elementId}' not found.`);
        }
    } catch (error) {
        console.error(error);
    }
}

// Function to remove an unordered list from a specified element
function removeList(elementId) {
    try {
        const element = document.getElementById(elementId);
        if (element) {
            const ul = element.querySelector('ul');
            if (ul) {
                element.removeChild(ul);
            } else {
                console.error(`No list found inside element with ID '${elementId}'.`);
            }
        } else {
            throw new Error(`Element with ID '${elementId}' not found.`);
        }
    } catch (error) {
        console.error(error);
    }
}
