import React from 'react';
import { Navbar,Nav,Form,Button,FormControl } from 'react-bootstrap';

class Header extends React.Component
{
    render() {
        return (
<Navbar bg="light" expand="lg">
  <Navbar.Toggle aria-controls="basic-navbar-nav" />
  <Navbar.Collapse id="basic-navbar-nav">
    <Nav className="mr-auto">
      <Nav.Link href="#home">Home</Nav.Link>
      <Nav.Link href="#link1">About us</Nav.Link>
      <Nav.Link href="#link2">Login/Register</Nav.Link>

    </Nav>
    <Form inline>
      <FormControl type="text" placeholder="Search" className="mr-sm-2" />
      <Button variant="outline-success">Search</Button>
    </Form>
  </Navbar.Collapse>
</Navbar>
        );
    }
}

export default Header;
