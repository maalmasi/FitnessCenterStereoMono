import { observable, action } from 'mobx';

class MembershipEditViewStore {
    @observable price;
    

    @action onnameChange(price){
        this.price=price;

    }

   

}

export default MembershipEditViewStore;