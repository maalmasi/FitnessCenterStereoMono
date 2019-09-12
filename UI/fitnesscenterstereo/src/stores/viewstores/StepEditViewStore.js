import { observable, action } from 'mobx';

class StepEditViewStore {
    @observable name;
    @observable abrv;
    @observable desc;
    @observable exercisesid;

    @action onNameChange(name){
        this.name=name;

    }

    @action onAbrvChange(abrv){
        this.abrv=abrv;

    }
    @action onDescChange(desc){
        this.desc=desc;

    }

}

export default StepEditViewStore;