import SideNav, { MenuIcon } from 'react-simple-sidenav';
import React from 'react';
import { inject, observer } from 'mobx-react';



class SideBar extends React.Component {

    constructor(props) {
        super(props);
        this.state = { showNav: false };
        this.handleClick = this.handleClick.bind(this);
    }

    handleClick(e) {
        const { rootStore } = this.props;
        rootStore.routerStore.goTo(e);
    };

    render() {
        return (
            <div>
                <button onClick={() => this.setState({ showNav: true })}>Pages</button>
                <SideNav
                    showNav={this.state.showNav}
                    onHideNav={() => this.setState({ showNav: false })}
                    title={<div> </div>}
                    titleStyle={{ backgroundColor: '#FFFFFF' }}
                    backgroundColor='#FFFFFF'
                    items={[
                        <div>
                            <a onClick={() => this.handleClick("home")}>Home</a>
                            <a onClick={() => this.handleClick("dietType")}>DietType</a>
                            <a onClick={() => this.handleClick("trainer")}>Trainer</a>
                        </div>
                    ]} />
            </div>
        );
    }
}

export default inject('rootStore')(observer(SideBar));
