import React from "react";
import { BrowserRouter, Routes, Route, Link } from "react-router-dom";
import Customer from "./pages/Customer";
import Admin from "./pages/Admin";

function App() {
  return (
    <BrowserRouter>
      <div style={{ padding: 20 }}>
        <h1>Hotel System</h1>
        <Link to="/customer">Customer</Link> | 
        <Link to="/admin"> Admin</Link>

        <Routes>
          <Route path="/customer" element={<Customer />} />
          <Route path="/admin" element={<Admin />} />
        </Routes>
      </div>
    </BrowserRouter>
  );
}

export default App;
