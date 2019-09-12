import { observable, action } from 'mobx';

class TrainerEditViewStore {
    @observable firstname;
    @observable lastname;
    @observable hiredat;

    @action onFirstnameChange(firstname){
        this.firstname=firstname;

    }

    @action onLastNameChange(lastname){
        this.lastname=lastname;

    }

    @action onHiredatChange(hiredat){
        this.hiredat=hiredat;

    }
}

export default TrainerEditViewStore;