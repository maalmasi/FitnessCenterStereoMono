import React from 'react';

class Header extends React.Component
{
    render() {
        return (
            <nav id="nav_bar">
                <ul>
                    <li><a className="active" href="Home"><span className="glyphicon glyphicon-home"></span></a></li>
                    <li><a href="News">Newds</a></li>
                    <li><a href="Contact">Contact</a></li>
                    <li><a href="About">About us</a></li>
                </ul>
            </nav>
        );
    }
}

export default Header;
