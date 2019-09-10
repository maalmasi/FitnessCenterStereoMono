import React from 'react';
import DietTypeForm from './DietTypeForm';
import form from './formFields';
import {inject, observer} from 'mobx-react';
 class DietTypeEditForm extends React.Component {
    render() {
        return(
            <DietTypeForm form={form} />
        );
    }
}

export default inject('rootStore')(observer(DietTypeEditForm));
