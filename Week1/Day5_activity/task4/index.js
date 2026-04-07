let student={
    name : "Yaseen",
    rollno :35,
    marks:95
}
let stu=document.getElementById("stu");

function UpdatestudentProfile(st){
    stu.innerHTML=`<p>Name : ${st.name}</p>
    <p> Rollno : ${st.rollno}</p>
    <p id="p">Marks : ${st.marks}</p>
    <button onclick="updateMarks(85)" class="btn">Update marks to 85</button>`
    
}

var p=document.getElementById("p")
function updateMarks(mar){
    student.marks=mar;
    UpdatestudentProfile(student)


}
UpdatestudentProfile(student)

