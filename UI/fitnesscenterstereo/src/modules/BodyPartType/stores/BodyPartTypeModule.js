import BodyParTypeDataStore from './BodyPartTypeDataStore';


export default class BodyPartTypeModule {
    constructor(rootStore) {
        this.rootStore=rootStore;
        this.bodyParTypeDataStore=new BodyParTypeDataStore();
 }
  



}