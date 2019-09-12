import { observable, action } from 'mobx';

class PlanViewStore {
    @observable page;
    @observable recordsperpage;
    @observable sortby;
    @observable sortascending;
    @observable searchquerry;


    @action onpageChange(page){
        this.page=page;

    }

    @action onrecordsperpageChange(recordsperpage){
        this.recordsperpage=recordsperpage;

    }

    @action onsearchquerryChange(searchquerry){
        this.searchquerry=searchquerry;

    }

    @action onThreadClickChange(sortascending,sortby){
        this.sortascending=sortascending;
        this.sortby=sortby;

    }
}

export default PlanViewStore;