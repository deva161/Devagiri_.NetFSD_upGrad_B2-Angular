
const enter = document.getElementById("enter");
const buttons = document.querySelectorAll(".btn");

buttons.forEach(btn => {
  btn.addEventListener("click", () => {
    const val = btn.innerText;

    if (val === "C") {
      enter.innerText = "";
      return;
    }

    if (val === "=") {
      try {
        enter.innerText = eval(enter.innerText);
      } catch {
        enter.innerText = "Error";
      }
      return;
    }

    if (val === "DEL") {
      enter.innerText = enter.innerText.slice(0, -1);
      return;
    }

    enter.innerText += val;
  });
});