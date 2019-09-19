import { observable, action } from 'mobx';
import toaster from 'toasted-notes';
import dvr from "mobx-react-form/lib/validators/DVR";
import validatorjs from "validatorjs";
import MobxReactForm from "mobx-react-form";

class ComplexityLevelTypeEditViewStore {
    constructor(rootStore) {
        this.dataStore = rootStore.complexityLevelTypeModuleStore.complexityLevelTypeDataStore;
        if (window.location.pathname.lastIndexOf('/') !== 0) {
            this.edit = true;
            this.lastSlashInUrl = window.location.pathname.lastIndexOf('/');
            this.itemToUpdateId = window.location.pathname.substr(this.lastSlashInUrl + 1);
            this.get();
            this.item ? this.initializeForm() : this.item = undefined;
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
                this.onUpdate();
            },
            onError(form) {
                console.log('All form errors', form.errors());
                toaster.notify('Form is invalid!', {
                    duration: 2000
                })
            }
        }
        this.form = new MobxReactForm ({fields, placeholder, labels, rules, values}, {plugins, hooks}) ;
    }


    @action.bound async get() {
        this.isLoading = true;
        this.item = await (this.dataStore.get(this.itemToUpdateId));
        this.item ? this.isLoading = false : this.isLoading = true;
        // if (this.item !== undefined) {
        //     this.errorMessage = "";
        //     this.formItem.name = this.item.name;
        //     this.formItem.abbreviation = this.item.abbreviation;
        //     this.form.update(this.formItem);
        //     this.isLoading = false;
        // } else {
        //     this.errorMessage = "Failed to get item, please refresh this page."
        // }
    }

    @action.bound async onUpdate() {
        try {
            this.formItem = this.form.values();
            //this.form.onSubmit();
            this.item.name = this.formItem.name;
            this.item.abbreviation = this.formItem.abbreviation;
            this.response = await (this.dataStore.update(this.item));
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