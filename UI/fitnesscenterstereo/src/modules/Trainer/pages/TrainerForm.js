import React from 'react';
import SimpleInput from '../../../common/SimpleInput';
import form from '../components/formFields'

export default class TrainerForm extends React.Component {
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