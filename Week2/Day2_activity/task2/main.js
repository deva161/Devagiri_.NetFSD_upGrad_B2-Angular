

import { calculateCartTotal, generateInvoice } from './cart.js';

const cartItems = [
    { name: "Laptop", price: 50000, quantity: 1 },
    { name: "Mouse", price: 500, quantity: 2 },
    { name: "Keyboard", price: 1500, quantity: 1 }
];

const total = calculateCartTotal(cartItems);
const invoice = generateInvoice(cartItems);

console.log(invoice);