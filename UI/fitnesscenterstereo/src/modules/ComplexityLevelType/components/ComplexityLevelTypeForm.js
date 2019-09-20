import React from 'react';

import BaseForm from '../../../common/components/BaseForm';

export default class ComplexityLevelTypeForm extends BaseForm {
    constructor(props) {
        const fields = ["name", "abbreviation"];
        const placeholder = {
            "name": "Enter name",
            "abbreviation": "Enter abbreviation"
        };
        const labels = {
            "name": "Name",
            "abbreviation": "Abbreviation"
        };
        const rules = {
            "name": 'required|string|between:3, 25',
            "abbreviation": 'required|string|between:3, 3'
        };
        super({props, fields, placeholder, labels, rules});
    }
    render() {
        return (
            <BaseForm>
                {/* <SimpleInput field={form.$('name')} />
                <SimpleInput field={form.$('abbreviation')} /> */}
            </BaseForm>
        );
    }
}