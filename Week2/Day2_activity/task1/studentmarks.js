const marks = [78, 85, 62, 90, 55];
const calculateTotal = (arr) =>
    arr.reduce((total, mark) => total + mark, 0);
const calculateAverage = (arr) => {
    const total = calculateTotal(arr);
    return total / arr.length;
};

const getResult = (average) =>
    average >= 50 ? "Pass" : "Fail";

const totalMarks = calculateTotal(marks);
const averageMarks = calculateAverage(marks);
const result = getResult(averageMarks);

marks.map((mark, index) =>
    console.log(`Student ${index + 1} Marks: ${mark}`)
);


console.log(`
Total Marks: ${totalMarks}
Average Marks: ${averageMarks.toFixed(2)}
Result: ${result}
`);