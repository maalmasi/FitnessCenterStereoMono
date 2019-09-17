import { RouterState, RouterStore } from 'mobx-state-router';
import { routes } from './Routes';
import BodyPartTypeModule from '../modules/BodyPartType/stores/BodyPartTypeModule';
import ComplexityLevelTypeModuleStore from '../modules/ComplexityLevelType/stores/ComplexityLevelTypeModuleStore';
// import TrainerEditViewStore from '../stores/viewstores/TrainerEditViewStore';
// import TrainerViewStore from '../stores/viewstores/TrainerViewStore';
// import DietTypeEditViewStore from '../stores/viewstores/DietTypeEditViewStore';
// import DietTypeViewStore from '../stores/viewstores/DietTypeViewStore';
// import ComplexityLevelTypeViewStore from '../modules/ComplexityLevelType/stores/ComplexityLevelTypeViewStore';
// import ComplexityLevelTypeEditViewStore from '../modules/ComplexityLevelType/stores/ComplexityLevelTypeEditViewStore';
// import EquipmentEditViewStore from '../stores/viewstores/EquipmentEditViewStore';
// import EquipmentViewStore from '../stores/viewstores/EquipmentViewStore';
// import ExercisesEditViewStore from '../stores/viewstores/ExercisesEditViewStore';
// import ExercisesViewStore from '../stores/viewstores/ExercisesViewStore';
// import MembershipEditViewStore from '../stores/viewstores/MembershipEditViewStore';
// import MembershipViewStore from '../stores/viewstores/MembershipViewStore';
// import BodyPartTypeEditViewStore from '../modules/BodyPartType/stores/BodyPartTypeEditViewStore';
// import BodyPartTypeViewStore from '../modules/BodyPartType/stores/BodyPartTypeViewStore';
// import PlanEditViewStore from '../stores/viewstores/PlanEditViewStore';
// import PlanViewStore from '../stores/viewstores/PlanViewStore';
// import ScheduleEditViewStore from '../stores/viewstores/ScheduleEditViewStore';
// import ScheduleViewStore from '../stores/viewstores/ScheduleViewStore';
// import StepEditViewStore from '../stores/viewstores/StepEditViewStore';
// import StepViewStore from '../stores/viewstores/StepViewStore';

const notFound = new RouterState('notFound');

export class RootStore {
    constructor(){
        this.bodyPartTypeModule = new BodyPartTypeModule(this);
        this.complexityLevelTypeModuleStore = new ComplexityLevelTypeModuleStore(this);
        // this.trainerEditViewStore=new TrainerEditViewStore(this);
        // this.trainerViewStore=new TrainerViewStore(this);
        // this.bodyPartTypeEditViewStore=new BodyPartTypeEditViewStore(this);
        // this.bodyPartTypeViewStore=new BodyPartTypeViewStore(this);
        // this.exercisesEditViewStore=new ExercisesEditViewStore(this);
        // this.exercisesViewStore=new ExercisesViewStore(this);
        // this.dietTypeEditViewStore=new DietTypeEditViewStore(this);
        // this.dietTypeViewStore=new DietTypeViewStore(this);
        // this.complexityLevelTypeEditViewStore=new ComplexityLevelTypeEditViewStore(this);
        // this.complexityLevelTypeViewStore=new ComplexityLevelTypeViewStore(this);
        // this.equipmentEditViewStore=new EquipmentEditViewStore(this);
        // this.equipmentViewStore=new EquipmentViewStore(this);
        // this.membershipEditViewStore=new MembershipEditViewStore(this);
        // this.membershipViewStore=new MembershipViewStore(this);
        // this.planEditViewStore=new PlanEditViewStore(this);
        // this.planViewStore=new PlanViewStore(this);
        // this.scheduleEditViewStore=new ScheduleEditViewStore(this);
        // this.scheduleViewStore=new ScheduleViewStore(this);
        // this.stepEditViewStore=new StepEditViewStore(this);
        // this.stepViewStore=new StepViewStore(this);
        

    }
    routerStore = new RouterStore(this, routes, notFound);
}
