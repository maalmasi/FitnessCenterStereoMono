import { observable, action } from 'mobx';

class EquipmentEditViewStore {
    @observable name;

    @action onNameChange(name) {
        this.name = name;
    }



}

export default EquipmentEditViewStore;