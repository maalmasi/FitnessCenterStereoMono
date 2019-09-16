import { observable, action } from 'mobx';

class BodyPartTypeViewStore {
    constructor(rootStore){
            this.rootStore=rootStore;
    }

    @observable page;
    @observable recordsperpage;
    @observable sortby;
    @observable sortascending;
    @observable searchquerry;

    @action.bound onPageChange(page){
        this.page=page;

    }

    @action.bound onRecordsPerPageChange(recordsperpage){
        this.recordsperpage=recordsperpage;
    }

    @action.bound onsearchquerryChange(searchquerry){
        this.searchquerry=searchquerry;

    }

    @action.bound onTableHeaderClick(sortascending,sortby){
        this.sortascending=sortascending;
        this.sortby=sortby;

    }
}

export default BodyPartTypeViewStore;