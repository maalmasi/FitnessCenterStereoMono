import { observable, action } from 'mobx';

class ComplexityLevelTypeEditViewStore {
    @observable name;
    @observable abbreviation;

    @action onnameChange(name){
        this.name=name;

    }

    @action onabbreviationChange(abbreviation){
        this.abbreviation=abbreviation;

    }

}

export default ComplexityLevelTypeEditViewStore;