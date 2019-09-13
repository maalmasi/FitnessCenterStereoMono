import React from 'react';
import MaterialTable from 'material-table';
import Layout from '../../../common/layouts/Layout';
import { Form, Button, FormControl } from 'react-bootstrap';
import { inject, observer } from 'mobx-react';


@inject('rootStore')
@observer
class Trainer extends React.Component {
    handleClick(e) {
        const { rootStore } = this.props;
        rootStore.routerStore.goTo(e);
    };
    render() {
        return (
            <React.Fragment>
                <Layout>
                    <Form inline>
                        <FormControl type="text" placeholder="Search" className="mr-sm-2" />
                        <Button variant="outline-success">Search</Button>
                        <Button onClick={() => this.handleClick("traineredit")} variant="outline-success">Create/Edit</Button>

                    </Form>
                    <MaterialTable
                        title="Trainers"
                        columns={[
                            { title: "First name", field: "firstname" },
                            { title: "Last name", field: "lastname" },
                            { title: "Date hired", field: "datehired", type: "numeric" }]}
                        options={{
                            search: false,
                            pageSizeOptions: [10, 20, 50, 100],
                            pageSize: 10

                        }}
                    />
                </Layout>
            </React.Fragment>
        );
    };
}
export default Trainer;