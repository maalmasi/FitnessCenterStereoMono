import React from 'react';
import MaterialTable from 'material-table';

export default class TrainerTable extends React.Component{
  render(){
    return (
        <MaterialTable
        title="Trainers"
          columns={[
            { title:'ID'},
            { title:'First name', field: "fn" },
            { title: "Last name", field: "ln" },
            { title: "Date hired", field: "dh", type: "date" },
          ]}
          
        />
    );
  }
};