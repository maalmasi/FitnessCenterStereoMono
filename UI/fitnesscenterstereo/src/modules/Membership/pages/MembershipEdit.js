import React from 'react';
import {  observer } from 'mobx-react';
import Layout from '../../../common/layouts/Layout';
import MembershipForm from './MembershipForm';



@observer
class MembershipEdit extends React.Component {
    render() {
        return (
            <React.Fragment>
                <Layout>
                   <MembershipForm/>
                </Layout>
            </React.Fragment>
        );
    }
}

export default MembershipEdit;


