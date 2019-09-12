import React from 'react';
import Layout from '../../../components/Layout'
import { Button, FormControl } from 'react-bootstrap';
import { inject, observer } from 'mobx-react';
import MaterialTable from 'material-table';


@inject('rootStore')
@observer
class Membership extends React.Component {
    handleClick(e) {
        const { rootStore } = this.props;
        rootStore.routerStore.goTo(e);
    };

    render() {
        return (
            <React.Fragment>
                <Layout>
                    <div className="row justify-content-between">
                        <div className="col-6">
                            <Button onClick={() => this.handleClick("membershipedit")}>Create</Button>
                        </div>
                        <div classname="col-6">
                            <FormControl type="text" placeholder="Search" className="mr-sm-2" />
                        </div>
                    </div>
                    <div>
                        <MaterialTable
                            columns={[
                                { title: "Price", field: "price" },
                                
                            ]}
                            data={[
                                { name: "Price" },
                            ]}
                            options={{
                                search: false,
                                pageSizeOptions: [10, 25, 50, 100],
                                pageSize: 10
                            }}
                            title="Membership"
                        />
                    </div>
                </Layout>
            </React.Fragment>
        )
    }
}

export default Membership;