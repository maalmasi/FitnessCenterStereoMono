import React from 'react';
import dvr from "mobx-react-form/lib/validators/DVR";
import validatorjs from "validatorjs";
import MobxReactForm from "mobx-react-form";
import SimpleInput from '../SimpleInput';

export default class BaseForm extends MobxReactForm {
    constructor(props) {
        const options = {
            validateOnChange: true
        };
        const plugins = {
            dvr: dvr(validatorjs),
        };
        super({props, options, plugins});
    }
    render() {
        return (
            <form onSubmit={this.form.onSubmit}>
                {this.props.children}
                {this.props.fields.forEach(element => {
                    return <SimpleInput field={element}/>
                })}
                <br />
                <button type="submit" disabled={!this.form.isValid} className={'btn-primary'}>Submit</button>
                <button type="button" className={'btn-secondary'} onClick={this.form.onClear}>Clear</button>
                <button type="button" className={'btn-secondary'} onClick={this.form.onReset}>Reset</button>
                <p>{this.form.error}</p>
            </form>
        )
    }
}