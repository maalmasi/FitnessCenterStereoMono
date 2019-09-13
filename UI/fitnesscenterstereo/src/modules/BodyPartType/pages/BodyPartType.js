import React from 'react';
import Layout from '../../../common/layouts/Layout';
import { Button, FormControl } from 'react-bootstrap';
import { inject, observer } from 'mobx-react';
import MaterialTable from 'material-table';
import BodyPartTypeViewStore from '../stores/BodyPartTypeViewStore';


@inject(
    i=>({
        viewStore:new BodyPartTypeViewStore(i.rootStore)
    })
)
@observer
class BodyPartType extends React.Component {
    handleClick (e) {
        const {viewStore}=this.props;
        viewStore.rootStore.routerStore.goTo(e);
    }

    render() {
        return (
            <React.Fragment>
                <Layout>
                    <div className="row justify-content-between">
                        <div className="col-6">
                            <Button onClick={() => this.handleClick("bodyparttypeedit")}>Create</Button>
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
                                { name: "Biceps", abbreviation: "bcp" },
                                { name: "Triceps", abbreviation: "trc" }
                            ]}
                            options={{
                                search: false,
                                pageSizeOptions: [10, 25, 50, 100],
                                pageSize: 10
                            }}
                            title="Body Part Type"
                        />
                    </div>
                </Layout>
            </React.Fragment>
        )
    }
}

export default BodyPartType;