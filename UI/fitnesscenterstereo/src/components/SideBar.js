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
                <button onClick={() => this.setState({ showNav: true })}>Btn</button>
                <SideNav
                    showNav={this.state.showNav}
                    onHideNav={() => this.setState({ showNav: false })}
                    title={<div> </div>}
                    titleStyle={{ backgroundColor: '#FFFFFF' }}
                    items={[
                        <div>
                            <a className="small py-1" onClick={() => this.handleClick("home")}>Home</a>
                            <a className="small py-1" onClick={() => this.handleClick("bodyPartType")}>BodyPartType</a>
                            <a className="small py-1" onClick={() => this.handleClick("complexityLevelType")}>ComplexityLevelType</a>
                            <a className="small py-1" onClick={() => this.handleClick("dietType")}>DietType</a>
                            <a className="small py-1" onClick={() => this.handleClick("equipment")}>Equipment</a>
                            <a className="small py-1" onClick={() => this.handleClick("exercises")}>Exercises</a>
                            <a className="small py-1" onClick={() => this.handleClick("membership")}>Membership</a>
                            <a className="small py-1" onClick={() => this.handleClick("plan")}>Plan</a>
                            <a className="small py-1" onClick={() => this.handleClick("schedule")}>Schedule</a>
                            <a className="small py-1" onClick={() => this.handleClick("step")}>Step</a>
                            <a className="small py-1" onClick={() => this.handleClick("trainer")}>Trainer</a>
                        </div>
                    ]} />
            </div>
        );
    }
}

export default inject('rootStore')(observer(SideBar));
