import { observable, action } from 'mobx';

class ComplexityLevelTypeEditViewStore {
    @observable name;
    @observable abbreviation;

    @action onNameChange(name){
        this.name=name;

    }

    @action onAbbreviationChange(abbreviation){
        this.abbreviation=abbreviation;

    }

}

export default ComplexityLevelTypeEditViewStore;