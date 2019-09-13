import React from 'react';
import { observer } from 'mobx-react';
import Layout from '../../../common/layouts/Layout';
import PlanForm from '../components/PlanForm';


@observer
class PlanEdit extends React.Component {
    render() {
        return (
            <React.Fragment>
                <Layout>
                    <PlanForm />
                </Layout>
            </React.Fragment>
        );
    }
}

export default PlanEdit;


