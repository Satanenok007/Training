var arr = [2, 4, 6, 8, 10];
function binary_search(arr, number) {
    let foundValue;
    let firstCell = 0;
    let lastCell = arr.length - 1;
    while (firstCell <= lastCell) {
        let midCell = Math.floor((firstCell + lastCell) / 2);
        let guessValue = arr[midCell];
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

let rez1 = binary_search(arr, 2); // 2
let rezult = binary_search(arr, 6); // 6
console.log(rez1);
console.log(rezult);
console.log(binary_search([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11], 9)); // 9

// ----- Find phone number by name -----

// let obj1 = {
//     name: 'Nastya',
//     phoneNumber: 99999
// };

// let obj2 = {
//     name: 'Price',
//     phoneNumber: 23456
// };

// let obj3 = {
//     name: 'Tima',
//     phoneNumber: 67896
// };

// let obj4 = {
//     name: 'Miki',
//     phoneNumber: 34561
// };
// or:

class User {
    constructor(name, phoneNumber) {
        this.name = name;
        this.phoneNumber = phoneNumber;
    }
}

let obj1 = new User('Nastya', 11111);
let obj2 = new User('Price', 22222);
let obj3 = new User('Tima', 33333);
let obj4 = new User('Miki', 44444);

let phoneBook = [obj1, obj2, obj3, obj4];

function getPhoneNumber(telephoneBook, name) {
    let userName;
    let rezult = null;
    for (let x = 0; x < telephoneBook.length; x++) {
        userName = telephoneBook[x].name;
        if (userName === name) {
            rezult = telephoneBook[x].phoneNumber;
            break;
        }
    }
    return rezult;
};

let phoneNumber = getPhoneNumber(phoneBook, 'Miki'); // 34561
console.log(phoneNumber);
phoneNumber = getPhoneNumber(phoneBook, 'Tima'); // 67896
console.log(phoneNumber);
phoneNumber = getPhoneNumber(phoneBook, 'Inessa');
console.log(phoneNumber); // null