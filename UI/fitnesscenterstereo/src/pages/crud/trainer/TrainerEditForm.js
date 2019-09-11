import React from 'react';
import { inject, observer } from 'mobx-react';
import Layout from '../../../components/Layout';
import TrainerComponent from './TrainerComponent'

class TrainerEditForm extends React.Component {
    render() {
        return (
            <React.Fragment>
                <Layout>
                    <TrainerComponent/>
                </Layout>
            </React.Fragment>
        );
    }
}

export default inject('rootStore')(observer(TrainerEditForm));