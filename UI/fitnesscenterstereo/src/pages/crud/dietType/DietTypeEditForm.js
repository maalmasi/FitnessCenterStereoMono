import React from 'react';
import Form from './newForm';
import form from './DietTypeForm';

export default class DietTypeEditForm extends React.Component {
    render() {
        return(
            <Form form={form} />
        );
    }
}