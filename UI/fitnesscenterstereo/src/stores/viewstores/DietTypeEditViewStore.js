import { observable, action } from 'mobx';

class DietTypeEditViewStore {
    @observable name;
    @observable abbreviation;
    @observable ingredients;

    @action onnameChange(name){
        this.name=name;

    }

    @action onabbreviationChange(abbreviation){
        this.abbreviation=abbreviation;

    }
    @action oningredientsChange(ingredients){
        this.ingredients=ingredients;
    }

}

export default DietTypeEditViewStore;