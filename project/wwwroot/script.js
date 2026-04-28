let items = [
    "Pizza - 200", 
    "Burger - 100", 
    "Pasta - 150",
    "French Fries - 80",
    "Garlic Bread - 120",
    "Sandwich - 90",
    "Momos - 110",
    "Coke - 50",
    "Cold Coffee - 70",
    "Ice Cream - 60",
    "Mineral Water - 20",
    "Tap Water - 0",
    "Sparking Water - 30"
];

let cart = [];
let total = 0;

function showMenu() {
    let menu = document.getElementById("menu");

    for (let i = 0; i < items.length; i++) {
        let btn = document.createElement("button");

        btn.innerText = items[i];

        btn.onclick = function () {
            addItem(items[i]);
        };

        menu.appendChild(btn);
    }
}

function addItem(itemString) {
    let parts = itemString.split(" - ");
    let name = parts[0];
    let price = Number(parts[1]);

    let existingItem = cart.find(item => item.name === name);

    if (existingItem) {
        existingItem.quantity += 1;
    } else {
        cart.push({ name, price, quantity: 1 });
    }

    calculateTotal();
    showCart();
}

function calculateTotal() {
    total = cart.reduce((sum, item) => sum + (item.price * item.quantity), 0);
}

function updateQuantity(index, delta) {
    cart[index].quantity += delta;
    if (cart[index].quantity <= 0) {
        cart.splice(index, 1);
    }
    calculateTotal();
    showCart();
}

function removeItem(index) {
    cart.splice(index, 1);
    calculateTotal();
    showCart();
}

function showCart() {
    let list = document.getElementById("cart");
    list.innerHTML = "";

    cart.forEach((item, index) => {
        let li = document.createElement("li");

        let infoDiv = document.createElement("div");
        infoDiv.innerHTML = `<strong>${item.name}</strong> - ₹ ${item.price}`;

        let actionDiv = document.createElement("div");
        actionDiv.className = "qty-controls";

        let minusBtn = document.createElement("button");
        minusBtn.innerText = "-";
        minusBtn.className = "qty-btn";
        minusBtn.onclick = () => updateQuantity(index, -1);

        let qtySpan = document.createElement("span");
        qtySpan.innerText = item.quantity;
        qtySpan.className = "qty-number";

        let plusBtn = document.createElement("button");
        plusBtn.innerText = "+";
        plusBtn.className = "qty-btn";
        plusBtn.onclick = () => updateQuantity(index, 1);

        let removeBtn = document.createElement("button");
        removeBtn.innerText = "Remove";
        removeBtn.onclick = () => removeItem(index);
        removeBtn.style.marginLeft = "10px";

        actionDiv.appendChild(minusBtn);
        actionDiv.appendChild(qtySpan);
        actionDiv.appendChild(plusBtn);
        actionDiv.appendChild(removeBtn);

        li.appendChild(infoDiv);
        li.appendChild(actionDiv);
        list.appendChild(li);
    });

    document.getElementById("total").innerText = total;
}

function sendOrder() {
    if (cart.length === 0) {
        alert("Your cart is empty!");
    } else {
        let formattedItems = cart.map(item => `${item.name} - ₹ ${item.price} x ${item.quantity}`);

        fetch("/saveCart", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify({ cart: formattedItems, total: total })
        })
        .then(response => response.json())
        .then(data => {
            alert("Order Sent to Owner!");
            cart = [];
            total = 0;
            showCart();
        })
        .catch(error => {
            console.error("Error:", error);
            alert("Something went wrong!");
        });
    }
}

showMenu();