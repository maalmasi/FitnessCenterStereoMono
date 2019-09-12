import React from 'react';
import { inject, observer } from 'mobx-react';
import Layout from '../../../components/Layout'
import EquipmentForm from './EquipmentForm';


@observer
class EquipmentEdit extends React.Component {
    render() {
        return (
            <React.Fragment>
                <Layout>
                    <EquipmentForm />
                </Layout>
            </React.Fragment>
        );
    }
}

export default EquipmentEdit;


