// Load location history when page loads
window.onload = () => {
    displayHistory();
};

// Function triggered by inline onclick
function getLocation() {

    if (!navigator.geolocation) {
        alert("Geolocation is not supported by this browser.");
        return;
    }

    navigator.geolocation.getCurrentPosition(
        showPosition,   // Success callback
        showError,      // Error callback
        {
            enableHighAccuracy: true,
            timeout: 10000,
            maximumAge: 0
        }
    );
}

//Success Callback
function showPosition(position) {

    const latitude = position.coords.latitude;
    const longitude = position.coords.longitude;

    const locationData = {
        latitude,
        longitude,
        time: new Date().toLocaleString()
    };

    document.getElementById("currentLocation").innerHTML =
        `
        Latitude: ${latitude} <br> 
        Longitude: ${longitude} <br><br>
        <iframe 
            width="300" 
            height="200" 
            src="https://maps.google.com/maps?q=${latitude},${longitude}&z=15&output=embed">
        </iframe>
        `;

    saveLocation(locationData);
}


function showError(error) {

    let message = "";

    switch (error.code) {
        case error.PERMISSION_DENIED:
            message = "User denied the request for Geolocation.";
            break;

        case error.POSITION_UNAVAILABLE:
            message = "Location information is unavailable.";
            break;

        case error.TIMEOUT:
            message = "The request to get user location timed out.";
            break;

        default:
            message = "An unknown error occurred.";
    }

    alert(message);
}

// Save only last 5 locations
function saveLocation(locationData) {

    let locations = JSON.parse(localStorage.getItem("locations")) || [];

    locations.unshift(locationData);

    if (locations.length > 5) {
        locations = locations.slice(0, 5);
    }

    localStorage.setItem("locations", JSON.stringify(locations));

    displayHistory();
}

// Display history on page load
function displayHistory() {

    const locations = JSON.parse(localStorage.getItem("locations")) || [];
    const historyDiv = document.getElementById("locationHistory");

    historyDiv.innerHTML = "";

    locations.forEach((loc, index) => {
        historyDiv.innerHTML += `
            <div>
                ${index + 1}. 
                Lat: ${loc.latitude}, 
                Lng: ${loc.longitude}
                <br>
                <small>${loc.time}</small>
            </div>
        `;
    });
}