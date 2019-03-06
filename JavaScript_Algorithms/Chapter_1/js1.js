var arr = [2, 4, 6, 8, 10];
function binary_search(arr, number) {
    var foundValue;
    var firstCell = 0;
    var lastCell = arr.length - 1;
    while (firstCell <= lastCell) {
        var midCell = Math.floor((firstCell + lastCell) / 2);
        var guessValue = arr[midCell];
        if (guessValue === number) {
            foundValue = guessValue;
        }
        if (guessValue > number) {
            lastCell = midCell - 1;
        } else {
            firstCell = midCell + 1;
        }
    }
    return foundValue;
}

var rez1 = binary_search(arr, 2); // 2
var rezult = binary_search(arr, 6); // 6
console.log(rez1);
console.log(rezult);
console.log(binary_search([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11], 9)); // 9