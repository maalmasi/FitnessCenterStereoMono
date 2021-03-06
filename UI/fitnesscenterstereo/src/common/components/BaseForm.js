import React from 'react';
import dvr from "mobx-react-form/lib/validators/DVR";
import validatorjs from "validatorjs";
import MobxReactForm from "mobx-react-form";
import SimpleInput from '../SimpleInput';

export default class BaseForm extends MobxReactForm {
    constructor({ hooks, ...otherProps }) {
        const options = {
            validateOnChange: true
        };
        const plugins = {
            dvr: dvr(validatorjs),
        };
        super(otherProps, { hooks, options, plugins });
    }
}