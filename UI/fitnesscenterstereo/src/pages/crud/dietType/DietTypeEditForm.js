import React from 'react';
import form from './inputs/formFields';
import {inject, observer} from 'mobx-react';
import Header from '../../../components/Header';
import Footer from '../../../components/Footer';
import SimpleInput from './inputs/SimpleInput';

class DietTypeEditForm extends React.Component {
    render() {
        return(
            <div>
            <Header/>
            <form onSubmit={form.onSubmit}>
                <SimpleInput field={form.$('name')} />
                <SimpleInput field={form.$('ingridients')} />
                <br />
                <button type="submit" className={'btn-primary'} onClick={form.onSubmit}>Submit</button>
                <button type="button" className={'btn-secondary'} onClick={form.onClear}>Clear</button>
                <button type="button" className={'btn-secondary'} onClick={form.onReset}>Reset</button>

                <p>{form.error}</p>
            </form>
           <Footer/>
            </div>
        );
    }
}

export default inject('rootStore')(observer(DietTypeEditForm));
