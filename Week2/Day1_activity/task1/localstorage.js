let note=document.getElementById("note");
function saveNote(){
    let noteVal=note.value;
    localStorage.setItem("mynote",noteVal);
    alert("Note is Saved1");

}

function clearNote(){
    localStorage.removeItem("mynote");
    note.value="";
    alert("local storage is Cleared!")
}


window.onload = function () {
  var savedNote = localStorage.getItem("mynote");
  if (savedNote) {
    note.value = savedNote;
  }
};