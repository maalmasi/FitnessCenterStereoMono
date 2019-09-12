import React from 'react';
import { inject, observer } from 'mobx-react';
import Layout from '../../../components/Layout'
import StepForm from './StepForm';


@observer
class StepEdit extends React.Component {
    render() {
        return (
            <React.Fragment>
                <Layout>
                    <StepForm />
                </Layout>
            </React.Fragment>
        );
    }
}

export default StepEdit;


