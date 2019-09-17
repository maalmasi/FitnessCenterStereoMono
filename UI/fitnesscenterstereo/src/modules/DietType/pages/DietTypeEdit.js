import React from 'react';
import { observer, inject } from 'mobx-react';
import Layout from '../../../common/layouts/Layout';
import SimpleInput from '../../../common/SimpleInput';
import form from '../components/formFields'
import DietTypeViewStore from '../stores/DietTypeViewStore';


@inject(
    i => ({
        viewStore: new DietTypeViewStore(i.rootStore)
    })
)
@observer
class DietTypeEdit extends React.Component {
    render() {
        return (
            <React.Fragment>
                <Layout>
                    <form onSubmit={form.onSubmit}>
                        <SimpleInput field={form.$('abrv')} />
                        <SimpleInput field={form.$('name')} />
                        <SimpleInput field={form.$('ingridients')} />
                        <br />
                        <button type="submit" className={'btn-primary'} onClick={form.onSubmit}>Submit</button>
                        <button type="button" className={'btn-secondary'} onClick={form.onClear}>Clear</button>
                        <button type="button" className={'btn-secondary'} onClick={form.onReset}>Reset</button>
                        <p>{form.error}</p>
                    </form>
                </Layout>
            </React.Fragment>
        );
    }
}

export default DietTypeEdit;


