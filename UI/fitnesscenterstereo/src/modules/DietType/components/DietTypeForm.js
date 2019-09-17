import React from 'react';
import SimpleInput from '../../../common/SimpleInput';
import form from './formFields'
import DietTypeViewStore from '../stores/DietTypeViewStore';
import { inject } from 'mobx-react';


@inject(
    i => ({
        viewStore: new DietTypeViewStore(i.rootStore)
    })
)
class DietTypeForm extends React.Component {
    constructor(){
        super();
        this.onSubmit = this.onSubmit.bind(this);
    }
    onSubmit(event){
        event.preventDefault();
        this.props.viewStore.onUpdate(window.location.pathname.replace("/diettypeedit/",""));

    }

    render() {
        return (
            <form >
                <SimpleInput field={form.$('abrv')} />
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
export default DietTypeForm;