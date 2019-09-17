import BodyPartTypeDataStore from './BodyPartTypeDataStore';


export default class BodyPartTypeModule {
    constructor(rootStore) {
        this.rootStore=rootStore;
        this.bodyPartTypeDataStore=new BodyPartTypeDataStore();
 }
  



}