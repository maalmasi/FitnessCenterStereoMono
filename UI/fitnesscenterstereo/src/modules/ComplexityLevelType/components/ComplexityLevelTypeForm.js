import React from 'react';
import SimpleInput from '../../../common/SimpleInput';
import BaseForm from '../../../common/components/BaseForm';

class ComplexityLevelTypeForm extends BaseForm {
    render() {
        const form = this.props.form;
        return (
            <BaseForm form={form}>
                <SimpleInput field={form.$('name')}/>
                <SimpleInput field={form.$('abbreviation')}/>
            </BaseForm>
        );
    }
}

const complexityLevelTypeForm = new ComplexityLevelTypeForm();
export  default complexityLevelTypeForm;