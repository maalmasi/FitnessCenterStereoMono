import MobxReactForm from "mobx-react-form";
import React from 'react';
import dvr from "mobx-react-form/lib/validators/DVR";
import validatorjs from "validatorjs";
import FormToast from '../../../components/FormToast';

const plugins = {
  dvr: dvr(validatorjs),
};

const fields = [{
    name: 'name',
    label: 'Name',
    placeholder: 'Enter diet name',
    rules: 'required|string|between:3, 25',
  },{
    name: 'ingridients',
    label: 'Ingridients',
    placeholder: 'Enter ingredients',
    rules: 'required|string|between:5,100',
  }];

  const hooks = {
    onSuccess(form) {
      console.log('Form Values!', form.values());
      return(
        <FormToast text="Form is valid!"/>
      );
    },
    onError(form) {
      console.log('All form errors', form.errors());
      return(
        <FormToast text="Form is invalid!"/>
      );
    }
  }

  export default new MobxReactForm({ fields }, { plugins, hooks });