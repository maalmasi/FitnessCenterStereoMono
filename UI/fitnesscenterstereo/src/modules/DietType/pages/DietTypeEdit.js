import React from 'react';
import { observer, inject } from 'mobx-react';
import Layout from '../../../common/layouts/Layout';
import SimpleInput from '../../../common/SimpleInput';
import DietTypeEditViewStore from '../stores/DietTypeEditViewStore'
import {Button} from 'react-bootstrap'

@inject(
    i => ({
        dietTypeEditViewStore: new DietTypeEditViewStore(i.rootStore)
    })
)
@observer
class DietTypeEdit extends React.Component {
    render() {
        const { form, errorMessage, isLoading } = this.props.dietTypeEditViewStore;
        return (
            <React.Fragment>
                <Layout>
                    {isLoading ?
                        <div>
                            Loading
                        </div>
                        :
                        <form>
                            <Button size='md' onClick={() => window.history.back()} variant="outline-success">Back</Button>
                            <SimpleInput field={form.$('name')} />
                            <SimpleInput field={form.$('abbreviation')} />
                            <button type="button" disabled={!form.isValid} onClick={form.onSubmit} className={'btn-primary'}>Submit</button>
                            <button type="button" className={'btn-secondary'} onClick={form.onClear}>Clear</button>
                            <button type="button" className={'btn-secondary'} onClick={form.onReset}>Reset</button>
                        </form>
                    }
                </Layout>
            </React.Fragment>
        );
    }
}

export default DietTypeEdit;


