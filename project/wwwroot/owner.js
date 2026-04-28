let currentOrders = [];

async function loadOrders() {
    try {
        const response = await fetch("/getOrders");
        currentOrders = await response.json();
        
        const grid = document.getElementById("orders-grid");
        const countEl = document.getElementById("total-orders-count");
        const revenueEl = document.getElementById("total-revenue");
        
        grid.innerHTML = "";
        
        if (currentOrders.length === 0) {
            grid.innerHTML = '<div class="no-orders">No orders received yet.</div>';
            countEl.innerText = "0";
            revenueEl.innerText = "₹ 0";
            return;
        }

        let totalRevenue = 0;
        countEl.innerText = currentOrders.length;

        currentOrders.slice().reverse().forEach(order => {
            totalRevenue += order.total;
            
            const card = document.createElement("div");
            card.className = "order-card";
            
            let itemsHtml = order.items.map(item => `<li>${item}</li>`).join("");
            
            card.innerHTML = `
                <div class="order-header">
                    <span class="order-id">#${order.id.toString().slice(-6)}</span>
                    <span class="order-time">${order.time}</span>
                </div>
                <ul class="order-items">
                    ${itemsHtml}
                </ul>
                <div class="order-total">₹ ${order.total}</div>
                <button class="bill-btn" onclick="generateBill(${order.id})">Generate Bill</button>
            `;
            
            grid.appendChild(card);
        });

        revenueEl.innerText = "₹ " + totalRevenue;

    } catch (error) {
        console.error("Error loading orders:", error);
        document.getElementById("orders-grid").innerHTML = '<div class="no-orders" style="color: red;">Error loading orders. Please check console.</div>';
    }
}

function generateBill(orderId) {
    const order = currentOrders.find(o => o.id === orderId);
    if (!order) return;

    let billText = `--- BILL ---\nOrder ID: #${order.id.toString().slice(-6)}\nTime: ${order.time}\n\n`;
    order.items.forEach(item => {
        billText += `- ${item}\n`;
    });
    billText += `\nTOTAL: ₹ ${order.total}\n--- THANK YOU ---`;

    alert(billText);
}

setInterval(loadOrders, 30000);

loadOrders();
