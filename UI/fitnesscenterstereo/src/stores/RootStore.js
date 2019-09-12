import { RouterState, RouterStore } from 'mobx-state-router';
import { routes } from './Routes';
import TrainerEditViewStore from './viewstores/TrainerEditViewStore';
import TrainerViewStore from './viewstores/TrainerViewStore';

const notFound = new RouterState('notFound');

export class RootStore {
    constructor(){

        this.trainerEditViewStore=new TrainerEditViewStore(this);
        this.trainerViewStore=new TrainerViewStore(this);
    }
    routerStore = new RouterStore(this, routes, notFound);
}