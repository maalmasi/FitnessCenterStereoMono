import React from 'react';
import { Button, FormControl, Dropdown } from 'react-bootstrap';
import { inject, observer } from 'mobx-react';

@inject('rootStore')
@observer
class DietType extends React.Component {
    handleClick(e) {
        const { rootStore } = this.props;
        rootStore.routerStore.goTo(e);
    };

    render() {
        return (
            <React.Fragment>
                <div className="row justify-content-between">
                    <div className="col-6">
                        <Button onClick={() => this.handleClick("diettype/edit")}>Create</Button>
                    </div>
                    <div classname="col-6">
                        <FormControl type="text" placeholder="Search" className="mr-sm-2" />
                    </div>
                </div>
                <div>
                    <table>
                        <th>Name</th><th>Ingredients</th><th>Actions</th>
                        <tr></tr><tr></tr><tr><Button onClick={() => this.handleClick("diettype/edit/")}>Edit</Button><Button onClick={() => this.handleClick("diettype/delete/")}>Delete</Button></tr>
                    </table>
                </div>
                <div className="row">
                    <div className="col-2">
                        Pg/Tp
                    </div>
                    <div className="col-3">
                        <Dropdown>
                            <Dropdown.Toggle variant="success" id="dropdown-basic">
                                Items per page
                            </Dropdown.Toggle>
                            <Dropdown.Menu>
                                <Dropdown.Item href="#/action-1">10</Dropdown.Item>
                                <Dropdown.Item href="#/action-2">25</Dropdown.Item>
                                <Dropdown.Item href="#/action-3">50</Dropdown.Item>
                                <Dropdown.Item href="#/action-3">100</Dropdown.Item>
                            </Dropdown.Menu>
                        </Dropdown>
                    </div>
                    <div className="col-7">
                        Pages
                    </div>
                </div>
            </React.Fragment>
        )
    }
}

export default DietType;