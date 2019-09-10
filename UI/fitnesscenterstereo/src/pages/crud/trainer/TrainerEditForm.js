import React from 'react';
import form from './inputs/formFields';
import { inject, observer } from 'mobx-react';
import Header from '../../../components/Header';
import Footer from '../../../components/Footer';
import SimpleInput from './inputs/SimpleInput';

class TrainerEditForm extends React.Component {
    render() {
        return (
            <React.Fragment>
                <Header />
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
                <Footer />
            </React.Fragment>
        );
    }
}

export default inject('rootStore')(observer(TrainerEditForm));