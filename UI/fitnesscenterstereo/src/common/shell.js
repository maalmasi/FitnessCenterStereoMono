import React from 'react';
import { inject } from 'mobx-react';
import { RouterView } from 'mobx-state-router';
import Home from './components/Home';
import NotFoundPage from './components/NotFoundPage';
import BodyPartType from '../modules/BodyPartType/pages/BodyPartType';
import BodyPartTypeEdit from '../modules/BodyPartType/pages/BodyPartTypeEdit';
import ComplexityLevelType from '../modules/ComplexityLevelType/pages/ComplexityLevelType';
import ComplexityLevelTypeEdit from '../modules/ComplexityLevelType/pages/ComplexityLevelTypeEdit';
import DietType from '../modules/DietType/pages/DietType';
import DietTypeEdit from '../modules/DietType/pages/DietTypeEdit';
import Equipment from '../modules/Equipment/pages/Equipment';
import EquipmentEdit from '../modules/Equipment/pages/EquipmentEdit';
import Exercise from '../modules/Exercises/pages/Exercise';
import ExerciseEdit from '../modules/Exercises/pages/ExerciseEdit';
import Plan from '../modules/Plan/pages/Plan';
import PlanEdit from '../modules/Plan/pages/PlanEdit';
import Step from '../modules/Step/pages/Step';
import StepEdit from '../modules/Step/pages/StepEdit';
import Schedule from '../modules/Schedule/pages/Schedule';
import ScheduleEdit from '../modules/Schedule/pages/ScheduleEdit';
import Trainer from '../modules/Trainer/pages/Trainer';
import TrainerEdit from '../modules/Trainer/pages/TrainerEdit';
import Membership from'../modules/Membership/pages/Membership';
import MembershipEdit from'../modules/Membership/pages/MembershipEdit'


const viewMap = {
    home: <Home />,
    notFound: <NotFoundPage />,
    bodyparttype:<BodyPartType/>,
    bodyparttypeedit:<BodyPartTypeEdit/>,
    complexityleveltype: <ComplexityLevelType />,
    complexityleveltypeedit: <ComplexityLevelTypeEdit />,
    diettype: <DietType />,
    diettypeedit: <DietTypeEdit />,
    equipment: <Equipment />,
    equipmentedit: <EquipmentEdit />,
    exercise: <Exercise />,
    exerciseedit: <ExerciseEdit />,
    plan: <Plan />,
    planedit: <PlanEdit />,
    step: <Step />,
    stepedit: <StepEdit />,
    schedule: <Schedule />,
    scheduleedit: <ScheduleEdit />,
    trainer: <Trainer />,
    traineredit: <TrainerEdit />,
    membership:<Membership/>,
    membershipedit:<MembershipEdit/>
};

export const Shell = inject('rootStore')(
    class extends React.Component {
        render() {
            const { rootStore } = this.props;
            const { routerStore } = rootStore;

            return <RouterView routerStore={routerStore} viewMap={viewMap} />;
        }
    }
);
