import { observable, action } from 'mobx';

class ComplexityLevelTypeViewStore {
    constructor(rootStore) {
        this.dataStore = rootStore.complexityLevelTypeModuleStore.complexityLevelTypeDataStore;
        this.routerStore = rootStore.routerStore;
        this.onFind();
    }

    resultItems;
    @observable isLoading = true;
    displayItems;
    @observable filter;
    @observable page;
    @observable recordsPerPage = 10;
    @observable sortBy;
    @observable sortAsc;
    @observable searchQuery = "";

    @action.bound onCreate() {
        this.routerStore.goTo("complexityleveltypecreate");
    };

    @action.bound onUpdate(id) {
        this.routerStore.goTo("complexityleveltypeedit", { id: id });
    }

    @action.bound onDelete(id) {
        return;
    }

    @action.bound async onFind() {
        this.isLoading = true;
        this.filter = this.page === undefined ? "page=1" : "page=" + this.page + this.recordsPerPage === undefined ? "&rpp=10" : "&rpp=" + this.recordsPerPage + "&searchQuery=" + this.searchQuery;        
        this.resultItems = await (this.dataStore.find(this.filter));
        this.resultsToArray();
        this.isLoading = false;
    };

    resultsToArray = () => {
        this.displayItems = [];
        for (let i = 0; i < this.resultItems.totalItems; i++) {
            this.displayItems.push({
                id: this.resultItems.items[i].id,
                name: this.resultItems.items[i].name,
                abbreviation: this.resultItems.items[i].abbreviation
            });
        }
    }

    @action.bound onPageChange(page) {
        this.page = page;
        console.log(page);
        this.onFind();
    }

    @action.bound onRecordsPerPageChange(recordsPerPage) {
        this.recordsPerPage = recordsPerPage;
        console.log(recordsPerPage);
        this.onFind();
    }

    @action.bound onSearchQueryChange(searchQuery) {
        this.searchQuery = searchQuery;
        this.onFind();
    }

    @action.bound onSortChange(sortBy, sortAsc) {
        this.sortAsc = sortAsc;
        this.sortBy = sortBy;
        this.onFind();
    }
}

export default ComplexityLevelTypeViewStore;