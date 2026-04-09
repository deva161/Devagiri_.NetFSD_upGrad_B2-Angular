// Validate Name
function validateName() {
    let name = document.getElementById("name").value;
    let nameMsg = document.getElementById("nameMsg");

    nameMsg.className = "msg";   // reset classes

    if (name.trim() === "") {
        nameMsg.innerHTML = "Name cannot be empty";
        nameMsg.classList.add("error");
        return false;
    } else {
        nameMsg.innerHTML = "Valid Name";
        nameMsg.classList.add("success");
        return true;
    }
}


// Validate Email
function validateEmail() {
    let email = document.getElementById("email").value;
    let emailMsg = document.getElementById("emailMsg");

    emailMsg.className = "msg";   // reset classes

    if (email.includes("@")) {
        emailMsg.innerHTML = "Valid Email";
        emailMsg.classList.add("success");
        return true;
    } else {
        emailMsg.innerHTML = "Email must contain '@'";
        emailMsg.classList.add("error");
        return false;
    }
}


// Validate Age
function validateAge() {
    let age = document.getElementById("age").value;
    let ageMsg = document.getElementById("ageMsg");

    ageMsg.className = "msg";   // reset classes

    if (age > 18) {
        ageMsg.innerHTML = "Valid Age";
        ageMsg.classList.add("success");
        return true;
    } else {
        ageMsg.innerHTML = "Age must be greater than 18";
        ageMsg.classList.add("error");
        return false;
    }
}


// Save Data
function saveData() {

    let isNameValid = validateName();
    let isEmailValid = validateEmail();
    let isAgeValid = validateAge();

    let finalMsg = document.getElementById("finalMsg");

    finalMsg.className = "";   // reset

    if (isNameValid && isEmailValid && isAgeValid) {

        let user = {
            name: document.getElementById("name").value,
            email: document.getElementById("email").value,
            age: document.getElementById("age").value
        };

        // Store in sessionStorage
        sessionStorage.setItem("userData", JSON.stringify(user));

        finalMsg.innerHTML = "Registration Successful! Data stored in sessionStorage.";
        finalMsg.classList.add("success");

    } else {
        finalMsg.innerHTML = "Please fix the errors before submitting.";
        finalMsg.classList.add("error");
    }
}