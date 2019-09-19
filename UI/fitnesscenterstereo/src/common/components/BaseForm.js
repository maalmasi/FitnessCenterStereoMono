import React from 'react';

export default class BaseForm extends React.Component{
    render() {
        const form = this.props.form;
        return (
            <form onSubmit={form.onSubmit}>
                {this.props.children}
                <br />
                <button type="submit" disabled={!form.isValid} className={'btn-primary'}>Submit</button>
                <button type="button" className={'btn-secondary'} onClick={form.onClear}>Clear</button>
                <button type="button" className={'btn-secondary'} onClick={form.onReset}>Reset</button>
                <p>{form.error}</p>
            </form>
        )
    }
}