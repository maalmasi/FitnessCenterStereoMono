import React from 'react';
import Layout from '../../../components/Layout'
import { Button, FormControl } from 'react-bootstrap';
import { inject, observer } from 'mobx-react';
import MaterialTable from 'material-table';


@inject('rootStore')
@observer
class ComplexityLevelType extends React.Component {
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
                            <Button onClick={() => this.handleClick("complexityleveltypeedit")}>Create</Button>
                        </div>
                        <div classname="col-6">
                            <FormControl type="text" placeholder="Search" className="mr-sm-2" />
                        </div>
                    </div>
                    <div>
                        <MaterialTable
                            columns={[
                                { title: "Name", field: "name" },
                                { title: "Abbreviation", field: "abbreviation" }
                            ]}
                            data={[
                                { name: "Krumpir", abbreviation: "krm" },
                                { name: "Paradajz", abbreviation: "prd" }
                            ]}
                            options={{
                                search: false,
                                pageSizeOptions: [10, 25, 50, 100],
                                pageSize: 10
                            }}
                            title="Complexity Level"
                        />
                    </div>
                </Layout>
            </React.Fragment>
        )
    }
}

export default ComplexityLevelType;