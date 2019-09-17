import { observable, action } from 'mobx';

class BodyPartTypeViewStore {
    constructor(rootStore) {
        this.rootStore = rootStore;
    }

    @observable isLoading = true;
    @observable  resultItems;
    @observable response;
    @observable result;
    @observable filter;
    @observable bodyPartTypes;
    @observable page = 1;
    @observable recordsPerPage = 10;
    @observable searchQuery = "";
    @observable page;
    @observable recordsperpage;
    @observable sortby;
    @observable sortascending;
   

    @action.bound handleClickGet = async (filter) => {
       
        this.filter = "searchQuery= " + this.searchQuery;
        this.resultItems =await this.rootStore.bodyPartTypeModuleStore.bodyPartTypeDataStore.get(filter);
     
    }
    @action.bound handleClick(e) {
        this.rootStore.routerStore.goTo(e);
    }

    @action.bound onPageChange(page) {
        this.page = page;

    }

    @action.bound onRecordsPerPageChange(recordsperpage) {
        this.recordsperpage = recordsperpage;
    }

    @action.bound onSearchQueryChange(searchquery) {
        this.searchQuery = searchquery;

    }

    @action.bound onTableHeaderClick(sortascending, sortby) {
        this.sortascending = sortascending;
        this.sortby = sortby;

    }
}

export default BodyPartTypeViewStore;