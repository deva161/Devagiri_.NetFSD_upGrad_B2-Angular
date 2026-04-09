import {
    addTaskCallback,
    deleteTaskCallback,
    listTasksCallback,
    addTaskPromise,
    deleteTaskPromise,
    listTasksPromise,
    addTaskAsync,
    deleteTaskAsync,
    listTasksAsync
} from './taskManager.js';

/* ======================================================
   1️⃣ CALLBACK DEMO
====================================================== */

console.log("---- CALLBACK VERSION ----");

addTaskCallback("Learn JS", (msg) => {
    console.log(msg);

    listTasksCallback((tasks) => {
        console.log(`Tasks: ${tasks.join(", ")}`);
    });
});


/* ======================================================
   2️⃣ PROMISE DEMO
====================================================== */

setTimeout(() => {
    console.log("---- PROMISE VERSION ----");

    addTaskPromise("Learn Promises")
        .then(msg => {
            console.log(msg);
            return listTasksPromise();
        })
        .then(tasks => {
            console.log(`Tasks: ${tasks.join(", ")}`);
        });

}, 3000);


/* ======================================================
   3️⃣ ASYNC/AWAIT DEMO
====================================================== */

setTimeout(async () => {
    console.log("---- ASYNC/AWAIT VERSION ----");

    try {
        const msg = await addTaskAsync("Learn Async/Await");
        console.log(msg);

        const tasks = await listTasksAsync();
        console.log(`Tasks: ${tasks.join(", ")}`);

        const delMsg = await deleteTaskAsync("Learn JS");
        console.log(delMsg);

        const updated = await listTasksAsync();
        console.log(`Updated Tasks: ${updated.join(", ")}`);

    } catch (error) {
        console.log("Error:", error);
    }

}, 6000);