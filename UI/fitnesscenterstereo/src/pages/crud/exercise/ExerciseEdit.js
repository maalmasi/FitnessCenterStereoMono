import React from 'react';
import { observer } from 'mobx-react';
import Layout from '../../../components/Layout'
import ExerciseForm from './ExerciseForm';


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


