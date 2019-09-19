import { observable, action } from 'mobx';



class BodyPartTypeEditViewStore {
    constructor(rootStore){
        this.rootStore=rootStore;

    }

    newItem={};
    @observable name;
    @observable abbreviation;
    @observable result;
    

    @action.bound onNameChange(name) {
        this.name = name;

    }

    @action.bound onAbbreviationChange(abbreviation) {
        this.abbreviation = abbreviation;

    }
    @action.bound  onCreate = async()=>{

        this.newItem.name=this.name;
        this.newItem.abbreviation=this.abbreviation;

      this.result=await this.rootStore.bodyPartTypeModuleStore.bodyPartTypeDataStore.post(this.newItem)
    }

    @action.bound onUpdate= async ()=>{

        this.result=await this.rootStore.bodyPartTypeModuleStore.bodyPartTypeDataStore.put(this.newItem)

    }

    @action.bound onDelete=async()=>{

        
    }
    
}

export default BodyPartTypeEditViewStore;