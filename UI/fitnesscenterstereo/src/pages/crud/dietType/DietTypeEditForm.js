import React from 'react';
import DietTypeForm from './DietTypeForm';
import form from './formFields';

export default class DietTypeEditForm extends React.Component {
    render() {
        return(
            <DietTypeForm form={form} />
        );
    }
}