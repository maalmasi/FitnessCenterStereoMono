import React from 'react';
import { observer } from 'mobx-react';
import Layout from '../../../common/layouts/Layout';
import ExerciseForm from '../components/ExerciseForm';


@observer
class ExerciseEdit extends React.Component {
    render() {
        return (
            <React.Fragment>
                <Layout>
                    <ExerciseForm />
                </Layout>
            </React.Fragment>
        );
    }
}

export default ExerciseEdit;


