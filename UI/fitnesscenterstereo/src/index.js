import React from 'react';
import ReactDOM from 'react-dom';
import 'bootstrap/dist/css/bootstrap.min.css';
import './styles/index.css';
import App from './App';
import * as serviceWorker from './serviceWorker';
import Header from './components/header';
import Home from './components/home'
import Footer from './components/footer'

//ReactDOM.render(<App />, document.getElementById('root'));

function Index()
{
  return (
    <React.Fragment>
        <Header />
        <Home />
        <Footer />
    </React.Fragment>
  )
}
  

ReactDOM.render(
  //<h1>Fitness Studio Stereo</h1>,
  <Index/>,
  document.getElementById('root')
);
  
// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: https://bit.ly/CRA-PWA
serviceWorker.unregister();
