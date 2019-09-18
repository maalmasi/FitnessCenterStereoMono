import { observable, action } from 'mobx';

class ComplexityLevelTypeEditViewStore {
    constructor(rootStore) {
        this.dataStore = rootStore.complexityLevelTypeModuleStore.complexityLevelTypeDataStore;
        this.lastSlashInUrl = window.location.pathname.lastIndexOf('/');
        this.itemToUpdateId = window.location.pathname.substr(this.lastSlashInUrl + 1);
        this.onGet();
    }

    @observable itemName = "";
    @observable itemAbrv = "";

    @action.bound async onGet() {
        this.item = await (this.dataStore.get(this.itemToUpdateId));
        this.itemName = this.item.name;
        this.itemAbrv = this.item.abbreviation;
    }

    @action.bound async onUpdate() {
        this.item.name = this.itemName;
        this.item.abbreviation = this.itemAbrv;
        console.log(this.item);
        this.response = await (this.dataStore.update(this.item));
    }

    @action.bound onReset() {
        this.itemName = this.item.name;
        this.itemAbrv = this.item.abbreviation;
    }

    @action.bound onNameChange(name) {
        this.itemName = name;
    }

    @action.bound onAbrvChange(abrv) {
        this.itemAbrv = abrv;
    }
}

export default ComplexityLevelTypeEditViewStore;