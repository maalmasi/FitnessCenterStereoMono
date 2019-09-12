import React from 'react';
import { observer } from 'mobx-react';
import Layout from '../../../components/Layout'
import ComplexityLevelTypeForm from './ComplexityLevelTypeForm';


@observer
class ComplexityLevelTypeEdit extends React.Component {
    render() {
        return (
            <React.Fragment>
                <Layout>
                    <ComplexityLevelTypeForm />
                </Layout>
            </React.Fragment>
        );
    }
}

export default ComplexityLevelTypeEdit;


