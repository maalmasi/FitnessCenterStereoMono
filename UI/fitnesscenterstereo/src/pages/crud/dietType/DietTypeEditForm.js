import React from 'react';
import Form from './DietTypeForm';
import form from './formFields';

export default class DietTypeEditForm extends React.Component {
    render() {
        return(
            <Form form={form} />
        );
    }
}