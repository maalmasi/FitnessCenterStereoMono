import { observable, action } from 'mobx';

class ScheduleEditViewStore {
    @observable frequency;
    @observable planid;

    @action onFrequencyChange(frequency){
        this.frequency=frequency;

    }

    

}

export default ScheduleEditViewStore;