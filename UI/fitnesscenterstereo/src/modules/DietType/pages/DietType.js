import React from 'react';
import Layout from '../../../common/layouts/Layout';
import { Button, FormControl } from 'react-bootstrap';
import { inject, observer } from 'mobx-react';
import MaterialTable from 'material-table';
import DietTypeViewStore from '../stores/DietTypeViewStore'

@inject(
    i => ({
        viewStore: new DietTypeViewStore(i.rootStore)
    })
)
@observer
class DietType extends React.Component {
    render() {
        const { viewStore } = this.props;
        const { resultItems, onRowsSizeChange, onChangePage} = viewStore;
        return (
            <React.Fragment>
                <Layout>
                    <div>
                        {JSON.stringify(resultItems)}
                    </div>
                    <div className="row justify-content-between">
                        <div className="col-6">
                            <Button onClick={() => viewStore.handleClick("diettypeedit")}>Create</Button>
                        </div>
                        <div className="col-6">
                            <FormControl type="text" onChange={e => viewStore.onSearchQueryChange(e.target.value)} placeholder="Search" className="mr-sm-2" />
                            <Button onClick={() => viewStore.find()}>Search</Button>
                        </div>
                    </div>
                    <div>
                        <MaterialTable
                            columns={[
                                { title: "Name", field: "name" },
                                { title: "Ingredients", field: "ingr" },
                                { title: "Abbreviation", field: "abbr" }
                            ]}
                            data={[
                                //resultItems === undefined ? { name: "", ingr: "", abbr: "" } : { name: resultItems.items[0].name, ingr: resultItems.items[0].ingredients, abbr: resultItems.items[0].abbreviation }

                            ]}
                            options={{
                                search: false,
                                pageSizeOptions: [10, 25, 50, 100],
                                pageSize: 10
                            }
                            }
                            title="Diets"
                            onChangeRowsPerPage={(pageSize) => {onRowsSizeChange(pageSize)}}
                            onChangePage={(page) => {onChangePage(page)}}

                        />
                    </div>
                </Layout>
            </React.Fragment>
        )
    }
}

export default DietType;