let getWeather=async()=>{
    try{
    let d=await fetch("https://api.open-meteo.com/v1/forecast?latitude=17.3850&longitude=78.4867&current_weather=true");
    let data=await d.json();
    let report=`
    ......Weather Report......
    TimeZone : ${data.timezone}
    Time : ${data.current_weather.time}
    Tempearure : ${data.current_weather.temperature}`
    console.log(report);
    }

    catch(error){
        console.log("Error :",error.message);
    }

}
getWeather();