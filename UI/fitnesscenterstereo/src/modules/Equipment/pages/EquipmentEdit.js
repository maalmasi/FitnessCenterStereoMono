import React from 'react';
import { observer } from 'mobx-react';
import Layout from '../../../common/layouts/Layout';
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


