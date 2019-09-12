import { observable, action } from 'mobx';

class DietTypeEditViewStore {
    @observable name;
    @observable abbreviation;
    @observable ingredients;

    @action onNameChange(name){
        this.name=name;

    }

    @action onAbbreviationChange(abbreviation){
        this.abbreviation=abbreviation;

    }
    @action onIngredientsChange(ingredients){
        this.ingredients=ingredients;
    }

}

export default DietTypeEditViewStore;