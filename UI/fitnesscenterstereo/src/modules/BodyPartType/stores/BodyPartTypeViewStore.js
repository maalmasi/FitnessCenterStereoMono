import { observable, action } from 'mobx';
import _ from 'lodash';
class BodyPartTypeViewStore {
    constructor(rootStore) {
        this.rootStore = rootStore;
    }

    @observable page = 1;
    @observable rpp = 10;
    @observable sortBy = "name";
    @observable sortAsc = true;
    @observable searchQuery = "";
    @observable resultItems;
    displayItems;
    @observable isLoading=true;
    @observable newItem;

    
    
  
   
    @action.bound  onCreate= async(model)=>{
        this.rootStore.routerStore.goTo("bodyparttypecreate");
    }
    
    @action.bound onUpdate(id) {
        if(this.resultItems!== undefined){
        this.rootStore.routerStore.goTo("bodyparttypeedit", { id: id });}
    }

    @action.bound onDelete(id) {
        return;
    }
    @action.bound async onFindChange(){
        this.isLoading=true;
        const filter = "searchQuery=" + this.searchQuery;
        this.resultItems = await this.rootStore.bodyPartTypeModuleStore.bodyPartTypeDataStore.find(filter);
        this.resultsToArray();
        this.isLoading=false;
       }
  
   
     resultsToArray =  () => {
        this.displayItems = [];
        for (let i = 0; i < this.resultItems.items.length; i++) {
          
             this.displayItems.push({
                abbreviation: this.resultItems.items[i].abbreviation,
                id: this.resultItems.items[i].id,
                name: this.resultItems.items[i].name
                
            });
            
        }
    }
  

    @action.bound onPageChange(page) {
        this.page = page;

    }

    @action.bound onRppChange(rpp) {
        this.rpp = rpp;
    }

    @action.bound onSearchQueryChange(searchQuery) {
        this.searchQuery = searchQuery;

    }

    @action.bound onSortChange(sortAsc, sortBy) {
        this.sortAsc = sortAsc;
        this.sortBy = sortBy;

    }
}

export default BodyPartTypeViewStore;