import React from 'react';
import { inject, observer } from 'mobx-react';
import Layout from '../../../components/Layout';
import { Form, Button, FormControl, ButtonGroup } from 'react-bootstrap';
import TrainerTable from './TrainerTable'


class Trainer extends React.Component {
    render() {
        return (
            <React.Fragment>
                <Layout>
                    <Form inline>
                        <FormControl className="btn pull-right" type="text" placeholder="Search" className="mr-sm-2" />
                        <Button variant="outline-success">Search</Button>
                        <ButtonGroup aria-label="Basic example">
                        <Button variant="outline-secondary">Create</Button>
                        <Button variant="outline-secondary">Find</Button>
                        </ButtonGroup>
                    </Form>
                    <TrainerTable />

                </Layout>
            </React.Fragment>

        );
    }
}

export default inject('rootStore')(observer(Trainer));