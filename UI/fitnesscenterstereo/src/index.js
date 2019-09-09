import React from 'react';
import ReactDOM from 'react-dom';
import 'bootstrap/dist/css/bootstrap.min.css';
import './styles/index.css';
import App from './App';
import * as serviceWorker from './serviceWorker';
import Header from './components/Header';
import Home from './components/Home'
import Footer from './components/Footer'

//ReactDOM.render(<App />, document.getElementById('root'));


  

ReactDOM.render(
  //<h1>Fitness Studio Stereo</h1>,
  <App/>,
  document.getElementById('root')
);
  
// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: https://bit.ly/CRA-PWA
serviceWorker.unregister();
