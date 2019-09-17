import React from 'react';
import Layout from '../../../common/layouts/Layout';
import { Button, FormControl } from 'react-bootstrap';
import { inject, observer } from 'mobx-react';
import MaterialTable from 'material-table';
import DietTypeViewStore from '../stores/DietTypeViewStore'
import EditIcon from '@material-ui/icons/Edit';
import DeleteIcon from '@material-ui/icons/Delete';

@inject(
    i => ({
        viewStore: new DietTypeViewStore(i.rootStore)
    })
)
@observer
class DietType extends React.Component {
    render() {
        const { viewStore } = this.props;
        return (
            <React.Fragment>
                <Layout>
                    <div className="row justify-content-between">
                        <div className="col-6">
                            <Button onClick={() => viewStore.onRouteChange("diettypecreate")}>Create</Button>
                        </div>
                        <div className="col-6">
                            <FormControl type="text" onChange={e => viewStore.onSearchQueryChange(e.target.value)} placeholder="Search" className="mr-sm-2" />
                            <Button onClick={() => viewStore.onFind()}>Search</Button>
                        </div>
                    </div>
                    <div>
                        <MaterialTable
                            onChangeRowsPerPage={(pageSize) => viewStore.onRecordsPerPageChange(pageSize)}
                            onChangePage={(page) => viewStore.onPageChange(page)}
                            onOrderChange={(orderBy, orderDirection) => viewStore.onSortChange(orderBy, orderDirection)}
                            columns={[
                                { title: "Name", field: "name" },
                                { title: "Ingredients", field: "ingr" },
                                { title: "Abbreviation", field: "abbr" }
                            ]}

                            data={
                                viewStore.resultItems === undefined ? [{ name: "", ingr: "", abbr: "" }] : viewStore.displayItems
                            }

                            options={{
                                search: false,
                                pageSizeOptions: [10, 25, 50, 100],
                                pageSize: 10
                            }
                            }
                            title="Diets"
                            actions={[
                                rowData => ({
                                    icon: () => <EditIcon />,
                                    tooltip: 'Edit entry',
                                    onClick: (event, rowData) => viewStore.onEdit(rowData.id)
                                }),
                                rowData => ({
                                    icon: () => <DeleteIcon />,
                                    tooltip: 'Delete entry',
                                    onClick: (event, rowData) => viewStore.onDelete(rowData.id)
                                })
                            ]}

                        />
                    </div>
                </Layout>
            </React.Fragment>
        )
    }
}

export default DietType;