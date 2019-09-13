import React from 'react';
import { observer } from 'mobx-react';
import Layout from '../../../common/layouts/Layout';
import ScheduleForm from '../components/ScheduleForm'
import { Button, FormControl } from 'react-bootstrap';


@observer
class ScheduleEdit extends React.Component {
    render() {
        return (
            <React.Fragment>
                <Layout>
                    <div className="row justify-content-between">
                        <div className="col-6">
                            <Button size='md' onClick={() => window.history.back()} variant="outline-success">Back</Button>                        </div>
                    <div classname="col-6">
                        <FormControl type="text" placeholder="Search" className="mr-sm-2" />
                    </div>
                    </div>
                <ScheduleForm />
                </Layout>
            </React.Fragment >
        );
    }
}

export default ScheduleEdit;