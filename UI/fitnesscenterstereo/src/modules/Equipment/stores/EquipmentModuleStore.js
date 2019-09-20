import EquipmentDataStore from './EquipmentDataStore';

export default class EquipmentModuleStore {
    constructor(rootStore) {
        this.rootStore = rootStore;
        this.EquipmentDataStore = new EquipmentDataStore();
    }
}