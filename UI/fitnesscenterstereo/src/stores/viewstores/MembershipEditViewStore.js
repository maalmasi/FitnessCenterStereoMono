import { observable, action } from 'mobx';

class MembershipEditViewStore {
    @observable price;
    

    @action onPriceChange(price){
        this.price=price;

    }

   

}

export default MembershipEditViewStore;