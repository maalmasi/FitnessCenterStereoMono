import React from 'react';
import { observer, inject } from 'mobx-react';
import Layout from '../../../common/layouts/Layout';
import ComplexityLevelTypeEditViewStore from '../stores/ComplexityLevelTypeEditViewStore';
import SimpleInput from '../../../common/SimpleInput';
import ComplexityLevelTypeForm from '../components/ComplexityLevelTypeForm';

@inject(stores => ({
    complexityLevelTypeEditViewStore: new ComplexityLevelTypeEditViewStore(stores.rootStore)
}))
@observer
class ComplexityLevelTypeEdit extends React.Component {
    render() {
        const { form, errorMessage, isLoading } = this.props.complexityLevelTypeEditViewStore;
        return (
            <React.Fragment>
                <Layout>
                    {isLoading ?
                        <div>
                            Loading
                        </div>
                        :
                        <form >
                            <SimpleInput field={form.$('name')} />
                            <SimpleInput field={form.$('abbreviation')} />
                            <button type="button" disabled={!form.isValid} onClick={form.onSubmit} className={'btn-primary'}>Submit</button>
                            <button type="button" className={'btn-secondary'} onClick={form.onClear}>Clear</button>
                            <button type="button" className={'btn-secondary'} onClick={form.onReset}>Reset</button>
                        </form>
                    }
                </Layout>
            </React.Fragment>
        );
    }
}

export default ComplexityLevelTypeEdit;


