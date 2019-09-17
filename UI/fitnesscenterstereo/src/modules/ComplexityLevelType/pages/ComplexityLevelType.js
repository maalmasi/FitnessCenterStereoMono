import React from 'react';
import Layout from '../../../common/layouts/Layout';
import { Button, FormControl } from 'react-bootstrap';
import { inject, observer } from 'mobx-react';
import ComplexityLevelTypeViewStore from '../stores/ComplexityLevelTypeViewStore'
import MaterialTable from 'material-table';
import EditIcon from '@material-ui/icons/Edit';
import DeleteIcon from '@material-ui/icons/Delete';

@inject(stores => ({
    complexityLevelTypeViewStore: new ComplexityLevelTypeViewStore(stores.rootStore)
}))
@observer
class ComplexityLevelType extends React.Component {
    constructor(props) {
        super(props);
    }
    render() {
        const { searchQuery, isLoading, page, recordsPerPage, displayItems, onUpdate, onCreate, onFind, onDelete, onSearchQueryChange, onRecordsPerPageChange, onSortChange, onPageChange } = this.props.complexityLevelTypeViewStore;
        return (
            <React.Fragment>
                <Layout>
                    <div className="row justify-content-between">
                        <div className="col-6">
                            <Button onClick={() => onCreate()}>Create</Button>
                        </div>
                        <div className="col-3">
                            <FormControl type="text" value={searchQuery} onChange={e => onSearchQueryChange(e.target.value)} placeholder="Search" className="mr-sm-2" />
                        </div>
                        <div className="col-3">
                            <Button onClick={() => onFind()}>Search</Button>
                        </div>
                    </div>
                    <div>
                        {isLoading ? "Loading items..." : ""}
                    </div>
                    <div>
                        <MaterialTable
                            onChangeRowsPerPage={(pageSize) => onRecordsPerPageChange(pageSize)}
                            onChangePage={(page) => onPageChange(page)}
                            onOrderChange={(orderBy, orderDirection) => onSortChange(orderBy, orderDirection)}
                            columns={[
                                { title: "Name", field: "name" },
                                { title: "Abbreviation", field: "abbreviation" }
                            ]}
                            data={
                                isLoading ? [{ name: "", abrv: "" }] : displayItems
                            }
                            actions={[
                                rowData => ({
                                    icon: () => <EditIcon />,
                                    tooltip: 'Edit entry',
                                    onClick: (event, rowData) => onUpdate(rowData.id)
                                }),
                                rowData => ({
                                    icon: () => <DeleteIcon />,
                                    tooltip: 'Delete entry',
                                    onClick: (event, rowData) => onDelete(rowData.id)
                                })
                            ]}
                            options={{
                                search: false,
                                page: page,
                                pageSizeOptions: [10, 25, 50, 100],
                                pageSize: recordsPerPage,
                                actionsColumnIndex: -1
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