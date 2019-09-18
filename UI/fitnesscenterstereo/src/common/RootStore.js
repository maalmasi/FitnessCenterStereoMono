import { RouterState, RouterStore } from 'mobx-state-router';
import { routes } from './Routes';
import BodyPartTypeModuleStore from '../modules/BodyPartType/stores/BodyPartTypeModuleStore';
import ComplexityLevelTypeModuleStore from '../modules/ComplexityLevelType/stores/ComplexityLevelTypeModuleStore';
import DietTypeModuleStore from '../modules/DietType/stores/DietTypeModuleStore';

const notFound = new RouterState('notFound');

export class RootStore {
    constructor(){
        this.bodyPartTypeModuleStore = new BodyPartTypeModuleStore(this);
        this.complexityLevelTypeModuleStore = new ComplexityLevelTypeModuleStore(this);
        this.dietTypeModuleStore = new DietTypeModuleStore(this);

    }
    routerStore=new RouterStore(this,routes,notFound);
    
}
