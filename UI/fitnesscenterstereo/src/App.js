import React from 'react';
import logo from './logo.svg';
import './App.css';
import Header from './components/Header';
import Home from './components/Home';
import Footer from './components/Footer';
import DietTypeEditForm from './pages/crud/dietType/DietTypeEditForm.js';


function App() {
  return (
    <div >
      <React.Fragment>
        <Header />
        <Home />
        <Footer />
    </React.Fragment>
    </div>
  );
}

export default App;
