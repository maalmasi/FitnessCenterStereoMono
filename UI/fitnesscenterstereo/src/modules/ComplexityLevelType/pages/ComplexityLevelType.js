import React from 'react';
import Layout from '../../../common/layouts/Layout';
import { Button, FormControl } from 'react-bootstrap';
import { inject, observer } from 'mobx-react';
import MaterialTable from 'material-table';


@inject(stores => ({
    complexityLevelTypeViewStore: stores.rootStore.complexityLevelTypeViewStore
}))
@observer
class ComplexityLevelType extends React.Component {
    constructor(props) {
        super(props);
    }
    render() {
        const { searchQuery, isLoading, recordsPerPage, resultItems, handleClickRoute, handleClickGet, onSearchQueryChange } = this.props.complexityLevelTypeViewStore;
        return (
            <React.Fragment>
                <Layout>
                    <div>
                    {resultItems===undefined ? (<span>Loading</span>) : (JSON.stringify(resultItems))}
                        {/* map(item => <div>{item.name}</div>))} */}
                    </div>
                    <div className="row justify-content-between">
                        <div className="col-6">
                            <Button onClick={() => handleClickRoute("complexityleveltypeedit")}>Create</Button>
                        </div>
                        <div classname="col-6">
                            <FormControl type="text" value={searchQuery} onChange={e => onSearchQueryChange(e.target.value)} placeholder="Search" className="mr-sm-2"/>
                            <Button onClick={() => handleClickGet()}>Search</Button>
                        </div>
                    </div>
                    <div>
                        <MaterialTable
                            columns={[
                                { title: "Name", field: "name" },
                                { title: "Abbreviation", field: "abrv" }
                            ]}
                            data={[
                                
                            ]}
                            options={{
                                search: false,
                                pageSizeOptions: [10, 25, 50, 100],
                                pageSize: recordsPerPage
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