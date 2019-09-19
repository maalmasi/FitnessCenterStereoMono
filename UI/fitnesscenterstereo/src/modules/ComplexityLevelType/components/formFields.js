import MobxReactForm from "mobx-react-form";
import dvr from "mobx-react-form/lib/validators/DVR";
import validatorjs from "validatorjs";
import toaster from 'toasted-notes';
const plugins = {
  dvr: dvr(validatorjs),
};
const fields = [{
  name: 'abbreviation',
  label: 'Abbreviation',
  placeholder: 'Enter abbreviation',
  rules: 'required|string|between:3, 25',
  observers: [{
    key: 'value', // can be any prop
    call: () => console.log('changed'),
  }],
}, {
  name: 'name',
  label: 'Name',
  placeholder: 'Enter complexity level',
  rules: 'required|string|between:3, 25',
  observers: [{
    key: 'value', // can be any prop
    call: () => console.log('changed'),
  }],
}];
const hooks = {
  onSuccess(form) {
    console.log('Form Values!', form.values());
    toaster.notify('Form is valid!', {
      duration: 2000
    })
  },
  onError(form) {
    console.log('All form errors', form.errors());
    toaster.notify('Form is invalid!', {
      duration: 2000
    })
  }
}
export default new MobxReactForm({ fields }, { plugins, hooks });
