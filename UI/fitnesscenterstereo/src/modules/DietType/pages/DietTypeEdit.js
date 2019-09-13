import React from 'react';
import { observer } from 'mobx-react';
import Layout from '../../../common/layouts/Layout';
import DietTypeForm from '../components/DietTypeForm';


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


