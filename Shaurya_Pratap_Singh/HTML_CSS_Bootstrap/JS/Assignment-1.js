function changeColor(elemntId,color)
{
    const ToBchanged = document.getElementById(elemntId);
    ToBchanged.style.backgroundColor=color;
}

changeColor("BgChange","DodgerBlue");

function addText(elemntId,string2add)
{
    const where2add = document.getElementById(elemntId);
    where2add.textContent+=string2add;
}

addText("TextAdd","This text here is newly added les go!");

function createMethod(elemnt,string2add)
{
    const listItem = document.createElement("li");
    listItem.textContent = string2add;
    elemnt.appendChild(listItem);
}

function createList(elemntId)
{
    const where2append = document.getElementById(elemntId);
    const List=document.createElement("ul");
    createMethod(List,"Element 1");
    createMethod(List,"Element 2");
    createMethod(List,"Element 3");
    createMethod(List,"Element 4");
    where2append.append(List);
}

createList("AddList");