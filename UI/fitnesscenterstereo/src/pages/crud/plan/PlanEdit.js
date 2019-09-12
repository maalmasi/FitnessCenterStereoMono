import React from 'react';
import { observer } from 'mobx-react';
import Layout from '../../../components/Layout'
import PlanForm from './PlanForm';


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


