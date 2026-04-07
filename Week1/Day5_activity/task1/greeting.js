let nam=document.getElementById("name");
let msg=document.getElementById("msg");

function greetingMsg(name){
    let p=document.createElement("p");
    p.innerHTML=`"Hello,${name}! Welcome to our website."`
    p.className="card";
    msg.append(p)



}
function greeting(){
    var n=nam.value;
    greetingMsg(n);
}

