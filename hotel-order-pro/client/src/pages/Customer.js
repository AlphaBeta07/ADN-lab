import React, { useEffect, useState } from "react";
import axios from "axios";

const API = "http://localhost:5011";

function Customer() {
  const [menu, setMenu] = useState([]);
  const [name, setName] = useState("");

  useEffect(() => {
    axios.get(`${API}/api/food`)
      .then(res => setMenu(res.data))
      .catch(err => console.error(err));
  }, []);

  const order = (item) => {
    axios.post(`${API}/api/order`, {
      customerName: name,
      item: item.name
    })
    .then(() => alert("Order placed"))
    .catch(err => console.error(err));
  };

  return (
    <div>
      <h2>Customer Panel</h2>
      <input placeholder="Your Name" onChange={e => setName(e.target.value)} />
      {menu.map(item => (
        <div key={item.id}>
          {item.name} - ₹{item.price}
          <button onClick={() => order(item)}>Order</button>
        </div>
      ))}
    </div>
  );
}

export default Customer;