import { observable, action } from 'mobx';

class PlanEditViewStore {
    @observable name;
    @observable diettypeid;

    @action onnameChange(name){
        this.name=name;

    }

   

}

export default PlanEditViewStore;