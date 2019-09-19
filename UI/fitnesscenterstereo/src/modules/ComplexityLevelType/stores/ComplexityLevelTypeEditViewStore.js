import { observable, action } from 'mobx';
import toaster from 'toasted-notes';
import dvr from "mobx-react-form/lib/validators/DVR";
import validatorjs from "validatorjs";
import MobxReactForm from "mobx-react-form";
import {ComplexityLevelTypeForm} from "../components/ComplexityLevelTypeForm"

class ComplexityLevelTypeEditViewStore {
    constructor(rootStore) {
        this.dataStore = rootStore.complexityLevelTypeModuleStore.complexityLevelTypeDataStore;
        if (window.location.pathname.lastIndexOf('/') !== 0) {
            this.edit = true;
            this.lastSlashInUrl = window.location.pathname.lastIndexOf('/');
            this.itemToUpdateId = window.location.pathname.substr(this.lastSlashInUrl + 1);
            this.get();
        } else {
            this.edit = false;
            this.isLoading = false;
        }
    }

    @observable isLoading = true;
    @observable errorMessage = "";

    initializeForm() {
        const fields = ["name", "abbreviation"];
        const placeholder = {
            "name": "Enter name",
            "abbreviation": "Enter abbreviation"
        };
        const labels = {
            "name": "Name",
            "abbreviation": "Abbreviation"
        };
        const values = {
            "name": this.item.name,
            "abbreviation": this.item.abbreviation
        };
        const plugins = {
            dvr: dvr(validatorjs),
        };
        const rules = {
            "name":'required|string|between:3, 25',
            "abbreviation":'required|string|between:3, 3'
        }
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
        this.form = new MobxReactForm ({fields, placeholder, labels, rules, values}, {plugins, hooks}) ;
        this.isLoading = false;
    }


    @action.bound async get() {
        this.isLoading = true;
        this.item = await (this.dataStore.get(this.itemToUpdateId));
        this.item ? this.initializeForm() : this.item = undefined;
    }

    @action.bound async onUpdate() {
        try {
            this.response = await (this.dataStore.update(this.item, this.itemToUpdateId));
            this.response ?
                toaster.notify('Update successful!', { duration: 2000 })
                :
                toaster.notify('Update failed!', { duration: 2000 })
        } catch (error) {
            console.log(error);
        }
    }

    @action.bound async onCreate() {
        try {
            this.item.name = this.itemName;
            this.item.abbreviation = this.itemAbrv;
            this.response = await (this.dataStore.create(this.item));
            console.log(this.response);
        } catch (error) {
            console.log(error);
        }
    }

    @action.bound onClear() {
        this.itemName = "";
        this.itemAbrv = "";
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