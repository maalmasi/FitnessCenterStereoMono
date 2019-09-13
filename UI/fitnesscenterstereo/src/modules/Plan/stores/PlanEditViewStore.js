import { observable, action } from 'mobx';

class PlanEditViewStore {
    @observable name;
    @observable diettypeid;

    @action onNameChange(name){
        this.name=name;

    }

   

}

export default PlanEditViewStore;