import { observable, action } from 'mobx';
import toaster from 'toasted-notes';

class TrainerViewStore {
    constructor(rootStore) {
        this.dataStore = rootStore.trainerModuleStore.trainerDataStore;
        this.routerStore = rootStore.routerStore;
        this.onFind();
    }

    resultItems;
    @observable isLoading = true;
    @observable isDeleting = false
    columns = [
        { title: "First Name", field: "firstname" },
        { title: "Last Name", field: "lastName" },
        { title: "Date hired", field: "hiredAt" }
    ];
    displayItems;
    @observable itemToDeleteName;
    @observable itemToDeleteId;
    @observable filter;
    @observable page;
    @observable recordsPerPage = 10;
    @observable sortBy = "lastName";
    @observable sortAsc = true;
    @observable searchQuery = "";

    @action.bound onCreate() {
        this.routerStore.goTo("trainercreate");
    };

    @action.bound onUpdate(id) {
        this.routerStore.goTo("traineredit", { id: id });
    }

    @action.bound onDelete(id, name) {
        this.itemToDeleteName = name;
        this.itemToDeleteId = id;
        this.isDeleting = true;
    }

    @action.bound async onConfirmDelete() {
        this.deleteResult = await (this.dataStore.delete(this.itemToDeleteId));
        if (this.deleteResult) {
            this.isDeleting = false;
            toaster.notify('Deletion successful!', {
                duration: 2000
            })
            this.onFind();
        } else {
            toaster.notify('Deletion failed!', {
                duration: 2000
            })
        }
    }

    @action.bound onCancelDelete() {
        this.isDeleting = false;
        this.itemToDeleteName = null;
        this.itemToDeleteId = null;
    }

    @action.bound async onFind() {
        this.isLoading = true;
        this.filter = ("sortBy=" + this.sortBy) + ("&sortAsc=" + this.sortAsc) + (this.page === undefined ? "&page=1" : "page=" + this.page) + (this.recordsPerPage === undefined ? "&rpp=10" : "&rpp=" + this.recordsPerPage) + "&searchQuery=" + this.searchQuery;
        this.resultItems = await (this.dataStore.find(this.filter));
        this.resultsToArray();
        this.isLoading = false;
    };

    resultsToArray = () => {
        this.displayItems = [];
        for (let i = 0; i < this.resultItems.items.length; i++) {
            this.displayItems.push({
                id: this.resultItems.items[i].id,
                firstname: this.resultItems.items[i].firstname,
                lastName: this.resultItems.items[i].lastName,
                hiredAt: this.resultItems.items[i].hiredAt
            });
        }
    }

    @action.bound onPageChange(page) {
        this.page = page;
        this.onFind();
    }

    @action.bound onRecordsPerPageChange(recordsPerPage) {
        this.recordsPerPage = recordsPerPage;
        this.onFind();
    }

    @action.bound onSearchQueryChange(searchQuery) {
        this.searchQuery = searchQuery;
    }

    @action.bound onSortChange(sortBy, sortAsc) {
        this.sortAsc = sortAsc === "asc";
        this.sortBy = this.columns[sortBy].field;
        this.onFind();
    }
}

export default TrainerViewStore;