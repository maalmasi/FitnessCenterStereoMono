import MobxReactForm from "mobx-react-form";
import dvr from "mobx-react-form/lib/validators/DVR";
import validatorjs from "validatorjs";
import toaster from 'toasted-notes';


const plugins = {
  dvr: dvr(validatorjs),
};
const fields = [{
  name: 'abrv',
  label: 'Abbreviation',
  placeholder: 'Enter abbreviation',
  rules: 'required|string|between:3, 25',
}, { 
  name: 'name',
  label: 'Name',
  placeholder: 'Enter diet name',
  rules: 'required|string|between:3, 25',
}, {
  name: 'ingridients',
  label: 'Ingridients',
  placeholder: 'Enter ingredients',
  rules: 'required|string|between:5,100',
}];

const hooks = {
  onSuccess(form) {
    //console.log('Form Values!', form.values());
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
