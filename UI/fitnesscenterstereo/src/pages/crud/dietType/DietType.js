import React from 'react';
import { Button, FormControl } from 'react-bootstrap';
import { inject, observer } from 'mobx-react';
import MaterialTable from 'material-table';


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
                    <MaterialTable
                        columns={[
                            { title: "Name", field: "name" },
                            { title: "Ingredients", field: "ingredients" },
                            { title: "Abbreviation", field: "abbreviation" }
                        ]}
                        data={[
                            { name: "Krumpir", ingredients: "krumpir, krumpir, krumpir", abbreviation: "krm" },
                            { name: "Paradajz", ingredients: "paradajz, rajcica, paradajz", abbreviation: "prd" }
                        ]}
                        options={[{
                            search: false
                        },{
                            recordsPerPageOptions: [10, 25, 50, 100]
                        }]}
                        title="Diets"
                    />
                </div>
            </React.Fragment>
        )
    }
}

export default DietType;