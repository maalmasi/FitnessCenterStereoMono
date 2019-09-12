import React from 'react';
import { observer } from 'mobx-react';
import Layout from '../../../components/Layout'
import DietTypeForm from './DietTypeForm';


@observer
class DietTypeEdit extends React.Component {
    render() {
        return (
            <React.Fragment>
                <Layout>
                    <DietTypeForm />
                </Layout>
            </React.Fragment>
        );
    }
}

export default DietTypeEdit;


