import React from 'react';
import logo from './logo.svg';
import './App.css';
import Header from './components/Header';
import Home from './components/Home';
import Footer from './components/Footer';


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
