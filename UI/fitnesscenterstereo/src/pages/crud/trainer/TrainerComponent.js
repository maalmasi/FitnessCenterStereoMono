import React from 'react';
import SimpleInput from './inputs/SimpleInput';
import form from './inputs/formFields'

export default class TrainerComponent extends React.Component {
    render() {
        return (
            <form onSubmit={form.onSubmit}>
                <SimpleInput field={form.$('FirstName')} />
                <SimpleInput field={form.$('LastName')} />
                <SimpleInput field={form.$('DateHired')} />

                <br />
                <button type="submit" className={'btn-primary'} onClick={form.onSubmit}>Submit</button>
                <button type="button" className={'btn-secondary'} onClick={form.onClear}>Clear</button>
                <button type="button" className={'btn-secondary'} onClick={form.onReset}>Reset</button>

                <p>{form.error}</p>
            </form>
        );
    }
}