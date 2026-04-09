let tasks = [];

/* ======================================================
   CALLBACK VERSION
====================================================== */

export const addTaskCallback = (task, callback) => {
    setTimeout(() => {
        tasks.push(task);
        callback(`Task "${task}" added.`);
    }, 1000);
};

export const deleteTaskCallback = (task, callback) => {
    setTimeout(() => {
        tasks = tasks.filter(t => t !== task);
        callback(`Task "${task}" deleted.`);
    }, 1000);
};

export const listTasksCallback = (callback) => {
    setTimeout(() => {
        callback(tasks);
    }, 1000);
};


/* ======================================================
   PROMISE VERSION
====================================================== */

export const addTaskPromise = (task) => {
    return new Promise((resolve) => {
        setTimeout(() => {
            tasks.push(task);
            resolve(`Task "${task}" added.`);
        }, 1000);
    });
};

export const deleteTaskPromise = (task) => {
    return new Promise((resolve) => {
        setTimeout(() => {
            tasks = tasks.filter(t => t !== task);
            resolve(`Task "${task}" deleted.`);
        }, 1000);
    });
};

export const listTasksPromise = () => {
    return new Promise((resolve) => {
        setTimeout(() => {
            resolve(tasks);
        }, 1000);
    });
};


/* ======================================================
   ASYNC/AWAIT VERSION
   (Reuses Promise functions internally)
====================================================== */

export const addTaskAsync = async (task) => {
    const result = await addTaskPromise(task);
    return result;
};

export const deleteTaskAsync = async (task) => {
    const result = await deleteTaskPromise(task);
    return result;
};

export const listTasksAsync = async () => {
    const result = await listTasksPromise();
    return result;
};