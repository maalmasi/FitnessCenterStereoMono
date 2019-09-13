import React from 'react';
import {  observer } from 'mobx-react';
import Layout from '../../../common/layouts/Layout';
import BodyPartTypeForm from '../components/BodyPartTypeForm';


@observer
class BodyPartTypeEdit extends React.Component {
    render() {
        return (
            <React.Fragment>
                <Layout>
                    <BodyPartTypeForm />
                </Layout>
            </React.Fragment>
        );
    }
}

export default BodyPartTypeEdit;


