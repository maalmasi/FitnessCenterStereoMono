import React from 'react';
import { inject } from 'mobx-react';
import { RouterView } from 'mobx-state-router';
import Home from './components/Home';
import NotFoundPage from './components/NotFoundPage';
import BodyPartType from './pages/crud/bodyPartType/BodyPartType';
import BodyPartTypeEdit from './pages/crud/bodyPartType/BodyPartTypeEdit';
import ComplexityLevelType from './pages/crud/complexityLevelType/ComplexityLevelType';
import ComplexityLevelTypeEdit from './pages/crud/complexityLevelType/ComplexityLevelTypeEdit';
import DietType from './pages/crud/dietType/DietType';
import DietTypeEdit from './pages/crud/dietType/DietTypeEdit';
import Equipment from './pages/crud/equipment/Equipment';
import EquipmentEdit from './pages/crud/equipment/EquipmentEdit';
import Exercise from './pages/crud/exercise/Exercise';
import ExerciseEdit from './pages/crud/exercise/ExerciseEdit';
import Plan from './pages/crud/plan/Plan';
import PlanEdit from './pages/crud/plan/PlanEdit';
import Step from './pages/crud/step/Step';
import StepEdit from './pages/crud/step/StepEdit';
import Schedule from './pages/crud/schedule/Schedule';
import ScheduleEdit from './pages/crud/schedule/ScheduleEdit';
import Trainer from './pages/crud/trainer/Trainer';
import TrainerEdit from './pages/crud/trainer/TrainerEdit';
import Membership from'./pages/crud/membership/Membership'
import MembershipEdit from'./pages/crud/membership/MembershipEdit'


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
