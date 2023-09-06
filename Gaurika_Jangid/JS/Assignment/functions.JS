function changeColor(elementId, color) {
    const element = document.getElementById(elementId);
    element.style.backgroundColor = color; 
};
  
function addText(elementId, text) {
    const element = document.getElementById(elementId);
    element.textContent = text;
};
  
function createList(elementId) {
    const ul = document.createElement("ul");
    const element = document.getElementById(elementId);
    element.appendChild(ul);
};
  
changeColor("heading", "green");
addText("heading", "Good day");
createList("heading");
  
