import { observable, action, runInAction } from 'mobx';
import toaster from 'toasted-notes';
import ComplexityLevelTypeForm from '../components/ComplexityLevelTypeForm';

class ComplexityLevelTypeEditViewStore {
    constructor(rootStore) {
        this.dataStore = rootStore.complexityLevelTypeModuleStore.complexityLevelTypeDataStore;
        const id = rootStore.routerStore.routerState.params.id;
        if (id != null) {
            this.dataStore.get(id).then(({ name, abbreviation, id }) => {
                runInAction(() => {
                    this.form = new ComplexityLevelTypeForm({
                        values: { name, abbreviation },
                        hooks: {
                            onSuccess: (form) => {
                                console.log("onSuccess: ", form.values());
                                this.onUpdate(id);
                            },
                            onError: (form) => {
                                console.log("onError: ", form.values());
                            }
                        }
                    });
                    this.isLoading = false;
                });
            }
            );
        } else {
            this.form = new ComplexityLevelTypeForm({
                hooks: {
                    onSuccess: (form) => {
                        console.log("onSuccess: ", form.values());
                        this.onCreate();
                    },
                    onError: (form) => {
                        console.log("onError: ", form.values());
                    }
                }
            });
            this.isLoading = false;
        }

    }

    @observable form;
    @observable isLoading = true;
    @observable errorMessage = "";

    async onUpdate(id) {
        try {
            this.response = await (this.dataStore.update(this.form.values(), id));
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
            this.response = await (this.dataStore.create(this.form.values()));
            this.response ?
                toaster.notify('Create successful!', { duration: 2000 })
                :
                toaster.notify('Create failed!', { duration: 2000 })
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