import React from 'react';
import './home.css'
import { Card, Button } from 'react-bootstrap';
import picture from '../images/gym_background.jpg'
import {inject, observer} from 'mobx-react';
import Header from './Header';
import Footer from './Footer';


class Home extends React.Component
{
    render() {
  
        return (
          <div>
          <Header/>
          <div class="row" >
    <div class="col">
    <Card className="card" class="card card-inline">
            <Card.Img variant="bottom" alt="Trainers image"  src={picture} />
            <Card.Body>
              <button type="button " class="btn btn-outline-success btn-lg btn-block">Trainers</button>
            </Card.Body>
          </Card>
    </div>
    <div class="col">
    <Card className="card" class="card card-inline">
            <Card.Img variant="bottom" alt="Plans image"  src={picture} />
            <Card.Body>
              <button type="button " class="btn btn-outline-success btn-lg btn-block">Plans</button>
            </Card.Body>
          </Card>
    </div>
    <div class="col">
    <Card className="card" class="card card-inline">
            <Card.Img variant="bottom" alt="Cards image"  src={picture} />
            <Card.Body>
              <button type="button " class="btn btn-outline-success btn-lg btn-block">Cards</button>
            </Card.Body>
          </Card>
    </div>
    <div class="col">
    <Card className="card" class="card card-inline">
            <Card.Img variant="bottom" alt="Exercises image"  src={picture} />
            <Card.Body>
              <button type="button " class="btn btn-outline-success btn-lg btn-block">Exercises</button>
            </Card.Body>
          </Card>
    </div>
  </div>
  <Footer/>
  </div>
        );
    }
}

export default inject('rootStore')(observer(Home));
