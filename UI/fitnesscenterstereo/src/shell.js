import React from 'react';
import { inject } from 'mobx-react';
import { RouterView } from 'mobx-state-router';
import Home from './components/Home';
import NotFoundPage from './components/NotFoundPage';
import BodyPartType from './pages/crud/bodyPartType/BodyPartType';
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
import Trainer from './pages/crud/trainer/Trainer';
import TrainerEdit from './pages/crud/trainer/TrainerEdit';
import Membership from'./pages/crud/membership/Membership'
import MembershipEdit from'./pages/crud/membership/MembershipEdit'
import BodyPartTypeForm from './pages/crud/bodyPartType/BodyPartTypeForm';
import BodyPartTypeEdit from './pages/crud/bodyPartType/BodyPartTypeEdit';


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
    trainer: <Trainer />,
    trainerEdit: <TrainerEdit />,
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
