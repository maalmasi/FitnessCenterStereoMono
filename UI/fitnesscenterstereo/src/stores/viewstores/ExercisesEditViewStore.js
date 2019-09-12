import { observable, action } from 'mobx';

class ExercisesEditViewStore {
    @observable name;
    @observable bodypartid;
    @observable complexityleveltypeid;

    @action onnameChange(name){
        this.name=name;

    }
}

export default ExercisesEditViewStore;