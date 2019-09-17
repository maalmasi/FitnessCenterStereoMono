import { RouterState, RouterStore } from 'mobx-state-router';
import { routes } from './Routes';
import BodyPartTypeModule from '../modules/BodyPartType/stores/BodyPartTypeModule';
import ComplexityLevelTypeModuleStore from '../modules/ComplexityLevelType/stores/ComplexityLevelTypeModuleStore';
import DietTypeModuleStore from '../modules/DietType/stores/DietTypeModuleStore';

const notFound = new RouterState('notFound');

export class RootStore {
    constructor(){
        this.bodyPartTypeModule = new BodyPartTypeModule(this);
        this.complexityLevelTypeModuleStore = new ComplexityLevelTypeModuleStore(this);
        this.dietTypeModuleStore = new DietTypeModuleStore(this);

    }
    
    
}
