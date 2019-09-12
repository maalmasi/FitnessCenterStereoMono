import { observable, action } from 'mobx';

class TrainerEditViewStore {
    @observable firstname;
    @observable lastname;
    @observable hiredat;

    @action onfirstnameChange(firstname){
        this.firstname=firstname;

    }

    @action onlastnameChange(lastname){
        this.lastname=lastname;

    }

    @action onhiredatChange(hiredat){
        this.hiredat=hiredat;

    }
}

export default TrainerEditViewStore;