import { observable, action } from 'mobx';
import form from '../components/formFields'
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
    @observable displayItems;

    @action.bound onRouteChange(e) {
        this.rootStore.routerStore.goTo(e);
    }

    @action.bound onSearchQueryChange(value) {
        this.searchQuery = value;
    }

    @action.bound async onFind() {
        const filter = "searchQuery=" + this.searchQuery + "&page=" + this.page + "&rpp=" + this.rpp + "&sortBy=" + this.sortBy + "&sortAsc=" + this.sortAsc;
        this.resultItems = await this.rootStore.dietTypeModuleStore.dietTypeDataStore.find(filter);
        this.resultsToArray();
    }

    @action.bound onPageChange(page) {
        this.page = page;
        this.onFind();
    }

    @action.bound onRecordsPerPageChange(recordsPerPage) {
        this.recordsPerPage = recordsPerPage;
        this.onFind();
    }

    @action.bound onSortChange(sortBy, sortAsc) {
        this.sortAsc = sortAsc;
        this.sortBy = sortBy;
        this.onFind();
    }
    resultsToArray() {
        this.displayItems = [];
        for (let i = 0; i < this.resultItems.length; i++) {
            this.displayItems.push({
                id: this.resultItems.items[i].id,
                name: this.resultItems.items[i].name,
                ingr: this.resultItems.items[i].ingridients,
                abbr: this.resultItems.items[i].abbreviation
            });
        }
    }

    @action.bound onEdit(id) {
        if (this.resultItems !== undefined || this.resultItems === {}) {
            this.rootStore.routerStore.goTo("diettypeedit", { id: id });
        }
        return;

    }

    @action.bound onDelete(id) {
        return;
    }

    @action.bound onUpdate(id, name, abrv) {
        try {
            form.onSubmit();
            this.rootStore.dietTypeModuleStore.dietTypeDataStore.update();
        }
        catch(error){
            console.log(error);
        }        
    }

}
export default DietTypeViewStore;