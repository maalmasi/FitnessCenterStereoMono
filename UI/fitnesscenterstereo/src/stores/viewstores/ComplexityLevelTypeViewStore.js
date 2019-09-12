import { observable, action } from 'mobx';

class ComplexityLevelTypeViewStore {
    @observable page;
    @observable recordsperpage;
    @observable sortby;
    @observable sortascending;
    @observable searchquerry;


    
    @action onPageChange(page){
        this.page=page;

    }

    @action onRecordsPerPageChange(recordsperpage){
        this.recordsperpage=recordsperpage;
    }

    @action onsearchquerryChange(searchquerry){
        this.searchquerry=searchquerry;

    }

    @action onTableHeaderClick(sortascending,sortby){
        this.sortascending=sortascending;
        this.sortby=sortby;

    }
}

export default ComplexityLevelTypeViewStore;