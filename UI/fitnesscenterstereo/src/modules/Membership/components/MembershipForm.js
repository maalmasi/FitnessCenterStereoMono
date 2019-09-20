
import BaseForm from '../../../common/components/BaseForm';


export default class BodyPartTypeForm extends BaseForm {
    constructor({values, hooks}) {
        const fields = ["price"];
        const placeholder = {
            "price": "Enter price"
          
        };
        const labels = {
            "price": "Price"
            
        };
        const rules = {
            "price": 'required|string|between:3, 25'
        };
        super({values, hooks, fields, placeholder, labels, rules});
    }
}
