import React from 'react';
import Header from './Header';
import Footer from './Footer';
import SideBar from './SideBar';

export default (props) => {
    return (
        <React.Fragment>
            <Header />
            <SideBar />
            {props.children}
            <Footer />
        </React.Fragment>
    )
}
