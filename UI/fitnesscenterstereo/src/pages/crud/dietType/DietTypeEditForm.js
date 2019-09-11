import React from 'react';
import { inject, observer } from 'mobx-react';
import Layout from '../../../components/Layout'
import DietTypeComponent from './DietTypeComponent';

class DietTypeEditForm extends React.Component {
    render() {
        return (
            <React.Fragment>
            <Layout>
                <DietTypeComponent/>
            </Layout>
        </React.Fragment>
        );
    }
}

export default inject('rootStore')(observer(DietTypeEditForm));


