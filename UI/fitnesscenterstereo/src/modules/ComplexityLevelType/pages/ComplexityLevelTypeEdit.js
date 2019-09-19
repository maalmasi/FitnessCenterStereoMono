import React from 'react';
import { observer, inject } from 'mobx-react';
import Layout from '../../../common/layouts/Layout';
import ComplexityLevelTypeEditViewStore from '../stores/ComplexityLevelTypeEditViewStore';
import SimpleInput from '../../../common/SimpleInput';
import BaseForm from '../../../common/components/BaseForm';

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
                            {errorMessage}
                        </div>
                        :
                        <BaseForm form={form}>
                            <SimpleInput field={form.select('name')} />
                            <SimpleInput field={form.select('abbreviation')} />
                        </BaseForm>
                    }
                </Layout>
            </React.Fragment>
        );
    }
}

export default ComplexityLevelTypeEdit;


