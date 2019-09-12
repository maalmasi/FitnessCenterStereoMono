import React from 'react';
import SimpleInput from './inputs/SimpleInput';
import form from './inputs/formFields'

export default class DietTypeForm extends React.Component {
    render() {
        return (
            <form onSubmit={form.onSubmit}>
                <SimpleInput field={form.$('name')} />
                <SimpleInput field={form.$('ingridients')} />
                <br />
                <button type="submit" className={'btn-primary'} onClick={form.onSubmit}>Submit</button>
                <button type="button" className={'btn-secondary'} onClick={form.onClear}>Clear</button>
                <button type="button" className={'btn-secondary'} onClick={form.onReset}>Reset</button>
                <p>{form.error}</p>
            </form>
        );
    }
}