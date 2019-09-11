import MobxReactForm from "mobx-react-form";
import dvr from "mobx-react-form/lib/validators/DVR";
import validatorjs from "validatorjs";

const plugins = {
  dvr: dvr(validatorjs),
};

const fields = [{
  name: 'FirstName',
  label: 'FirstName',
  placeholder: 'Enter first name',
  rules: 'required|string|between:3, 25',
}, {
  name: 'LastName',
  label: 'LastName',
  placeholder: 'Enter LastName',
  rules: 'required|string|between:5,100',
},
{
  name: 'DateHired',
  label: 'Datehired',
  placeholder: 'Enter hire date',
  rules: 'required|date',
}

];

const hooks = {
  onSuccess(form) {
    alert('Form is valid! Send the request here.');
    console.log('Form Values!', form.values());
  },
  onError(form) {
    alert('Form has errors!');
    console.log('All form errors', form.errors());
  }
}

export default new MobxReactForm({ fields }, { plugins, hooks });