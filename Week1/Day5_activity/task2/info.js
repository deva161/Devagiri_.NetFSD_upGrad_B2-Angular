let person={name : "Mounika",
    age : 24,
    city : "Guntur"
}

let info=document.getElementById("info");
let p1=document.createElement("p");
let p2=document.createElement("p");
let p3=document.createElement("p");
info.append(p1,p2,p3);
p1.innerText=`Name : ${person.name}`;
p2.innerText=`Age : ${person.age}`;
p3.innerText=`City : ${person.city}`;
info.setAttribute("class","information")


