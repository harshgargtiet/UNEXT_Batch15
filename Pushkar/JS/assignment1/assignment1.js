console.log("hello assignment my old friend")

// function getask(){
//     changecolor(getElementById("getidfield").value,getElementById("getcolor").id)
// }
function changecolor(elementid="id1",color="yellow")
{
    document.getElementById(elementid).style.backgroundColor=color
}

function changetext(elementid="id2",text="yellow")
{
    document.getElementById(elementid).textContent=text
}

function createList(elementid="id3")
{
    const ulist = document.createElement("ul");
    const llist = document.createElement("li");
    llist.textContent="list item";
    ulist.appendChild(llist);
    document.getElementById(elementid).appendChild(ulist);
    

}