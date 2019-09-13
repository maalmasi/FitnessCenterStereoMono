import React from 'react';
import { observer } from 'mobx-react';
import Layout from '../../../common/layouts/Layout';
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


