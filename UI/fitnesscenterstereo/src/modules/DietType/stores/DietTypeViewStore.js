import { observable, action } from 'mobx';

class DietTypeViewStore {
    constructor(rootStore) {
        this.rootStore = rootStore;
    }

    @observable page = 1;
    @observable rpp = 10;
    @observable sortBy = "name";
    @observable sortAsc = true;
    @observable searchQuery = "";
    @observable resultItems;

    @action.bound handleClick(e) {
        this.rootStore.routerStore.goTo(e);
    }
    @action.bound onSearchQueryChange(value) {
        this.searchQuery = value;
        console.log(this.searchQuery)
    }

    @action.bound async find() {
        console.log(this.searchQuery);
        const filter = "searchQuery=" + this.searchQuery;
        this.resultItems = await this.rootStore.dietTypeModuleStore.dietTypeDataStore.find(filter);
    }
    @action.bound onRowsSizeChange(value){
        this.rpp=value;
    }
    @action.bound onChangePage(value){
        this.page=value;
    }
    
}

export default DietTypeViewStore;