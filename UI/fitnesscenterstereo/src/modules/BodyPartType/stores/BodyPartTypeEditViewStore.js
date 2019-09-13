import { observable, action,inject } from 'mobx';



class BodyPartTypeEditViewStore {
    constructor(RootStore) {
    
    }


    

    @observable name;
    @observable abbreviation;

    @action onNameChange(name) {
        this.name = name;

    }

    @action onAbbreviationChange(abbreviation) {
        this.abbreviation = abbreviation;

    }

}

export default BodyPartTypeEditViewStore;