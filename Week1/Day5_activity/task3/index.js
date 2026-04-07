var count=0;
let h2=document.getElementById("h3");


function IncreamentCount(step){
    count=count+step;
    h2.innerHTML=`Increament the number : ${count}`;
    
}
function reset(){
    h2.innerHTML="Increament the number : 0";
}

