
const toggleBtn = document.getElementById("themeToggle");
const body = document.body;

function applyTheme(theme) {
    body.classList.remove("light-mode", "dark-mode");
    body.classList.add(theme);
    localStorage.setItem("theme", theme);
}


function toggleTheme() {
    const currentTheme = body.classList.contains("dark-mode")
        ? "dark-mode"
        : "light-mode";

    const newTheme = currentTheme === "dark-mode"
        ? "light-mode"
        : "dark-mode";

    applyTheme(newTheme);
}


function loadTheme() {
    const savedTheme = localStorage.getItem("theme");
    if (savedTheme) {
        applyTheme(savedTheme);
    } else {
        applyTheme("light-mode");
    }
}

// Event Listener
toggleBtn.addEventListener("click", toggleTheme);

// Initialize theme on page load
loadTheme();
    </script >
