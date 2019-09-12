import { observable, action } from 'mobx';

class StepEditViewStore {
    @observable name;
    @observable abrv;
    @observable desc;
    @observable exercisesid;

    @action onnameChange(name){
        this.name=name;

    }

    @action onabrvChange(abrv){
        this.abrv=abrv;

    }
    @action ondescChange(desc){
        this.desc=desc;

    }

}

export default StepEditViewStore;