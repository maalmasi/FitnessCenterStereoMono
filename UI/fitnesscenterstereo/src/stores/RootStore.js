import { RouterState, RouterStore } from 'mobx-state-router';
import { routes } from './Routes';

const notFound = new RouterState('notFound');

export class RootStore {
    routerStore = new RouterStore(this, routes, notFound);
}