import React from 'react';
import {  observer } from 'mobx-react';
import Layout from '../../../components/Layout'
import BodyPartTypeForm from './BodyPartTypeForm';


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


