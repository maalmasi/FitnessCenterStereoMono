import { RouterState, RouterStore } from 'mobx-state-router';
import { routes } from './Routes';
import TrainerEditViewStore from './viewstores/TrainerEditViewStore';
import TrainerViewStore from './viewstores/TrainerViewStore';
import DietTypeEditViewStore from './viewstores/DietTypeEditViewStore';
import DietTypeViewStore from './viewstores/DietTypeViewStore';
import ComplexityLevelTypeViewStore from './viewstores/ComplexityLevelTypeViewStore';
import ComplexityLevelTypeEditViewStore from './viewstores/ComplexityLevelTypeEditViewStore';
import EquipmentEditViewStore from './viewstores/EquipmentEditViewStore';
import EquipmentViewStore from './viewstores/EquipmentViewStore';
import ExercisesEditViewStore from './viewstores/ExercisesEditViewStore';
import ExercisesViewStore from './viewstores/ExercisesViewStore';
import MembershipEditViewStore from './viewstores/MembershipEditViewStore';
import MembershipViewStore from './viewstores/MembershipViewStore';
import BodyPartTypeEditViewStore from './viewstores/BodyPartTypeEditViewStore';
import BodyPartTypeViewStore from './viewstores/BodyPartTypeViewStore';
import PlanEditViewStore from './viewstores/PlanEditViewStore';
import PlanViewStore from './viewstores/PlanViewStore';
import ScheduleEditViewStore from './viewstores/ScheduleEditViewStore';
import ScheduleViewStore from './viewstores/ScheduleViewStore';
import StepEditViewStore from './viewstores/StepEditViewStore';
import StepViewStore from './viewstores/StepViewStore';

const notFound = new RouterState('notFound');

export class RootStore {
    constructor(){

        this.trainerEditViewStore=new TrainerEditViewStore(this);
        this.trainerViewStore=new TrainerViewStore(this);
        this.bodyPartTypeEditViewStore=new BodyPartTypeEditViewStore(this);
        this.bodyPartTypeViewStore=new BodyPartTypeViewStore(this);
        this.exercisesEditViewStore=new ExercisesEditViewStore(this);
        this.exercisesViewStore=new ExercisesViewStore(this);
        this.dietTypeEditViewStore=new DietTypeEditViewStore(this);
        this.dietTypeViewStore=new DietTypeViewStore(this);
        this.complexityLevelTypeEditViewStore=new ComplexityLevelTypeEditViewStore(this);
        this.complexityLevelTypeViewStore=new ComplexityLevelTypeViewStore(this);
        this.equipmentEditViewStore=new EquipmentEditViewStore(this);
        this.equipmentViewStore=new EquipmentViewStore(this);
        this.membershipEditViewStore=new MembershipEditViewStore(this);
        this.membershipViewStore=new MembershipViewStore(this);
        this.planEditViewStore=new PlanEditViewStore(this);
        this.planViewStore=new PlanViewStore(this);
        this.scheduleEditViewStore=new ScheduleEditViewStore(this);
        this.scheduleViewStore=new ScheduleViewStore(this);
        this.stepEditViewStore=new StepEditViewStore(this);
        this.stepViewStore=new StepViewStore(this);
        

    }
    routerStore = new RouterStore(this, routes, notFound);
}
