import React from 'react';
import Layout from '../../../common/layouts/Layout';
import { Button, FormControl } from 'react-bootstrap';
import { inject, observer } from 'mobx-react';
import MaterialTable from 'material-table';
import BodyPartTypeViewStore from '../stores/BodyPartTypeViewStore';
import EditIcon from '@material-ui/icons/Edit';
import DeleteIcon from '@material-ui/icons/Delete';



@inject('rootStore')
@observer
class Step extends React.Component {
    handleClick(e) {
        const { rootStore } = this.props;
        rootStore.routerStore.goTo(e);
    };

    render() {
        const {viewStore}=this.props;
        const {page,rpp,resultItems, onFindChange, onSearchQueryChange,isLoading,onPageChange,onRppChange,onSortChange,onCreate,onDelete,onUpdate,displayItems } = viewStore;
        return (
            <React.Fragment>
                <Layout>
                    <div className="row justify-content-between">
                        <div className="col-6">
                            <Button onClick={()=>viewStore.onCreate()}>Create</Button>
                        </div>
                        <div className="col-3">
                        <FormControl type="text" onChange={e => onSearchQueryChange(e.target.value)} placeholder="Search" className="mr-sm-2" />
                        <Button onClick={()=>onFindChange()}>Search</Button>
                        </div>
                        {isLoading ? "Loading ..." : ""}
                    </div>
                    <div>
                        <MaterialTable
                        onChangeRowsPerPage={(pageSize) => onRppChange(pageSize)}
                        onChangePage={(page) => onPageChange(page)}
                        onOrderChange={(orderBy, orderDirection) => onSortChange(orderBy, orderDirection)}
                            columns={[
                                { title: "Name", field: "name" },
                                { title: "Abbreviation", field: "abrv" },
                                { title: "Description", field: "desc" },
                                { title: "Exercise ID", field: "exercisesid" },
                            ]}
                            data={
                                isLoading ? [{ name: "", abrv: "" }] : displayItems
                            }
                            actions={[
                                rowData => ({
                                    icon: () => <EditIcon />,
                                    tooltip: 'Edit entry',
                                    onClick: (event, rowData) => viewStore.onUpdate(rowData.id)
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
                                pageSize: rpp,
                                actionsColumnIndex: -1
                            }}
                            title="Step"
                        />
                    </div>
                </Layout>
            </React.Fragment>
        )
    }
}

export default Step;
