import MobxReactForm from "mobx-react-form";
import dvr from "mobx-react-form/lib/validators/DVR";
import validatorjs from "validatorjs";
import toaster from 'toasted-notes';


const plugins = {
  dvr: dvr(validatorjs),
};

const fields = [{
  name: 'Frequency',
  label: 'Frequency',
  placeholder: 'Enter frequency',
  rules: 'required|int|between:1, 12',
}, {
  name: 'PlanID',
  label: 'PlanID',
  placeholder: 'Enter PlanID',
  rules: 'required|string',
}

];

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
