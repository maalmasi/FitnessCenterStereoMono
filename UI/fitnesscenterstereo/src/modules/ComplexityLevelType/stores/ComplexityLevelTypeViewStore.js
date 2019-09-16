import { observable, action } from 'mobx';

const webApiUrl = 'http://localhost:57865/api/ComplexityLevelType/';

class ComplexityLevelTypeViewStore {
    constructor(rootStore) {
        this.rootStore = rootStore;
        this.routerStore = rootStore.routerStore;
        this.handleClickGet();
    }

    @observable isLoading = true;
    @observable resultItems;
    @observable response;
    @observable result;
    @observable filter;
    @observable complexityLevelTypes;
    @observable page = 1;
    @observable recordsPerPage = 10;
    @observable sortBy;
    @observable sortAsc;
    @observable searchQuery = "";

    @action.bound handleClickRoute(e) {
        this.routerStore.goTo(e);
    };

    @action.bound handleClickGet() {
        this.isLoading = true;
        this.filter = "page=" + this.page + "&rpp=" + this.recordsPerPage + "&searchQuery=" + this.searchQuery;
        //this.complexityLevelTypes = this.dataStore.get(this.filter);
        let get = async (filter) => {
            const options = {
                method: "GET",
                }
            const request = new Request(webApiUrl + "?" + filter, options);
            this.response = (await fetch(request));
            //Object.assign(this.resultItems, response);
            this.isLoading = false;
            this.result = this.response.json();
            this.result.then((value) => {
                console.log(value);
                this.resultItems = value;
                console.log(this.resultItems);
            })
        }
        get(this.filter);
    };

    @action.bound onPageChange(page) {
        this.page = page;
    }

    @action.bound onRecordsPerPageChange(recordsPerPage) {
        this.recordsPerPage = recordsPerPage;
        console.log(recordsPerPage);
    }

    @action.bound onSearchQueryChange(searchQuery) {
        this.searchQuery = searchQuery;
    }

    @action.bound onTableHeaderClick(sortAsc, sortBy) {
        this.sortAsc = sortAsc;
        this.sortBy = sortBy;
    }
}

export default ComplexityLevelTypeViewStore;