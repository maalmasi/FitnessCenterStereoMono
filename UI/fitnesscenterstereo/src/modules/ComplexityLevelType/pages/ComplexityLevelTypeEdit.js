import React from 'react';
import { observer } from 'mobx-react';
import Layout from '../../../common/layouts/Layout';
import ComplexityLevelTypeForm from '../components/ComplexityLevelTypeForm';


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


