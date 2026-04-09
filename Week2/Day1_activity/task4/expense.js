// let db;

// const req=indexedDB.open("ExpenseDB",2);

// req.onupgradeneeded=function(event){
    
//     db=event.target.result;
//     if(!db.objectStoreNames.contains("expenses")){
//         db.createObjectStore("expenses",{keyPath: "id",autoIncrement:true});
//     }

// }

// req.onsuccess=function(event){
//     db=event.target.result;
//     console.log("Database open sucessfully");
// }

// req.onerror=function(event){
//     console.log("Database Error : ",event.target.errorCode)
// }

// //insert



// function addExpense(){
// let title=document.getElementById("title").value;
// let amount=Number(document.getElementById("amount").value);
// let date=document.getElementById("date").valule;


// let transaction=db.transaction(["expenses"],"readwrite");
// let store=transaction.objectStore("expenses");
// let request=store.add({title:title,amount:amount,date:date});


// request.onsuccess=function(){
//     console.log("inserted data")
//     alert("inserted");

//  }
// }

let db;

    const request = indexedDB.open("ExpenseDB", 2);

    request.onupgradeneeded = function (e) {
      db = e.target.result;
      const store = db.createObjectStore("expenses", {
        keyPath: "id",
        autoIncrement: true
      });
      store.createIndex("title", "title", { unique: false });
    };

    request.onsuccess = function (e) {
      db = e.target.result;
      console.log("Database opened successfully");
    };

    request.onerror = function (e) {
      console.error("Database error:", e.target.error);
    };

    function addExpense() {
      try {
        const title = document.getElementById("title").value;
        const amount = document.getElementById("amount").value;
        const date = document.getElementById("date").value;

        const tx = db.transaction("expenses", "readwrite");
        const store = tx.objectStore("expenses");

        const expense = { title, amount, date };
        const request = store.add(expense);

        request.onsuccess = () => {
          alert("Expense added!");
          getExpenses();
        };

        request.onerror = (e) => {
          console.error("Insert error:", e.target.error);
        };

        tx.onerror = (e) => {
          console.error("Transaction error:", e.target.error);
        };
      } catch (err) {
        console.error("Add Expense failed:", err);
      }
    }

    function getExpenses() {
      const list = document.getElementById("expenseList");
      list.innerHTML = "";

      try {
        const tx = db.transaction("expenses", "readonly");
        const store = tx.objectStore("expenses");

        const request = store.openCursor();

        request.onsuccess = function (e) {
          const cursor = e.target.result;
          if (cursor) {
            const li = document.createElement("li");
            li.innerHTML = `
              <span>
                ${cursor.value.title} — ₹${cursor.value.amount} — ${cursor.value.date}
              </span>
              <button onclick="deleteExpense(${cursor.value.id})">❌</button>
            `;
            list.appendChild(li);
            cursor.continue();
          }
        };

        request.onerror = (e) => {
          console.error("Select error:", e.target.error);
        };

        tx.onerror = (e) => {
          console.error("Transaction error:", e.target.error);
        };
      } catch (err) {
        console.error("Fetch failed:", err);
      }
    }

    function deleteExpense(id) {
      try {
        const tx = db.transaction("expenses", "readwrite");
        const store = tx.objectStore("expenses");

        const request = store.delete(id);

        request.onsuccess = () => {
          alert("Deleted!");
          getExpenses();
        };

        request.onerror = (e) => {
          console.error("Delete error:", e.target.error);
        };

        tx.onerror = (e) => {
          console.error("Transaction error:", e.target.error);
        };
      } catch (err) {
        console.error("Delete failed:", err);
      }
    }




