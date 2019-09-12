import { observable, action } from 'mobx';

class EquipmentEditViewStore {
    @observable name;

    @action onnameChange(name) {
        this.name = name;
    }



}

export default EquipmentEditViewStore;