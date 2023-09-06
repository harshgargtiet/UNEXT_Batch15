

function changeColor(elementId, color) {
    const element = document.getElementById(elementId);
    element.style.backgroundColor = color;
}

function addText(elementId, color) {
    const element = document.getElementById(elementId);
    element.innerText = color;
}

function createList(elementId) {
    const parentElement = document.getElementById(elementId);
    const unorderedList = document.createElement("ul");
    const listItem = document.createElement("li");
    listItem.innerText = "First Item";
    unorderedList.appendChild(listItem);
    parentElement.appendChild(unorderedList);
}
changeColor("root", "#efefef");
addText("root", "Nice work!");
createList("root");