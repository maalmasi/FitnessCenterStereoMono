import React from 'react';
import {  observer,inject } from 'mobx-react';
import Layout from '../../../common/layouts/Layout';
import BodyPartTypeForm from '../components/BodyPartTypeForm';
import BodyPartTypeEditViewStore from '../stores/BodyPartTypeEditViewStore'

@inject(
    i=>({
        viewStore:new BodyPartTypeEditViewStore(i.rootStore)
    })
)
@observer
class BodyPartTypeEdit extends React.Component {
    render() {
        return (
            <React.Fragment>
                <Layout>
                    <BodyPartTypeForm />
                </Layout>
            </React.Fragment>
        );
    }
}

export default BodyPartTypeEdit;


