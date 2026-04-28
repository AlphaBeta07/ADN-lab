import React, { useEffect, useState } from "react";
import axios from "axios";

const API = "http://localhost:5011";

function Admin() {
  const [orders, setOrders] = useState([]);
  const [name, setName] = useState("");
  const [price, setPrice] = useState("");

  const loadOrders = () => {
    axios.get(`${API}/api/order`)
      .then(res => setOrders(res.data))
      .catch(err => console.error(err));
  };

  useEffect(() => {
    loadOrders();
  }, []);

  const addItem = () => {
    axios.post(`${API}/api/food`, {
      name,
      price: parseInt(price)
    })
    .then(() => alert("Item added"))
    .catch(err => console.error(err));
  };

  return (
    <div>
      <h2>Admin Panel</h2>

      <h3>Add Food</h3>
      <input placeholder="Name" onChange={e => setName(e.target.value)} />
      <input placeholder="Price" onChange={e => setPrice(e.target.value)} />
      <button onClick={addItem}>Add</button>

      <h3>Orders</h3>
      <button onClick={loadOrders}>Refresh</button>
      {orders.map(o => (
        <div key={o.id}>
          {o.customerName} ordered {o.item}
        </div>
      ))}
    </div>
  );
}

export default Admin;