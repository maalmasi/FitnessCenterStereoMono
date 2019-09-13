import React from 'react';
import SimpleInput from '../../../common/SimpleInput';
import form from './formFields'


export default class ExerciseForm extends React.Component {
    render() {
        return (
            <form onSubmit={form.onSubmit}>
                <SimpleInput field={form.$('name')} />
                <SimpleInput field={form.$('bodypartid')} />
                <SimpleInput field={form.$('complexityleveltypeid')} />
                <br />
                <button type="submit" className={'btn-primary'} onClick={form.onSubmit}>Submit</button>
                <button type="button" className={'btn-secondary'} onClick={form.onClear}>Clear</button>
                <button type="button" className={'btn-secondary'} onClick={form.onReset}>Reset</button>
                <p>{form.error}</p>
            </form>
        );
    }
}