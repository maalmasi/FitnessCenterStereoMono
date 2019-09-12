import React from 'react';
import MaterialTable from 'material-table';
import Layout from '../../../components/Layout'
import { Navbar, Nav, Form, Button, FormControl } from 'react-bootstrap';

export default  class BodyPartType extends React.Component {

    render() {
        
        return (
          <React.Fragment>
          <Layout>
              <Form inline>
                  <FormControl type="text" placeholder="Search" className="mr-sm-2" />
                  <Button variant="outline-success">Search</Button>
              </Form>
              <MaterialTable
                  title="Trainers"
                  columns={[
                      { title: "ID", field: "id" },
                      { title: "First name", field: "fn" },
                      { title: "Last name", field: "ln" },
                      { title: "Date hired", field: "dh", type: "numeric" }]}
              />
          </Layout>
      </React.Fragment>  
);

    }
}
