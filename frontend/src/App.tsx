import React from "react";
import "./App.css";
import Header from "./Header";
import BowlerData from "./BowlerData";

function App() {
  return (
    // Added header and main table
    <div className="App">
      <Header />
      <BowlerData />
    </div>
  );
}

export default App;
