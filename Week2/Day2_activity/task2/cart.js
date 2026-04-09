
export const calculateCartTotal = (products) =>
    products.reduce(
        (total, product) => total + (product.price * product.quantity),
        0
    );

export const generateInvoice = (products) => {

    const itemLines = products.map(product =>
        `${product.name} - ₹${product.price} x ${product.quantity} = ₹${product.price * product.quantity}`
    );

    const totalAmount = calculateCartTotal(products);

    return `
----- INVOICE -----

${itemLines.join("\n")}

-------------------
Total: ₹${totalAmount}
`;
};