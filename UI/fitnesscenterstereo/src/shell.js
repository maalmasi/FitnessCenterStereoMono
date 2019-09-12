import React from 'react';
import { inject } from 'mobx-react';
import { RouterView } from 'mobx-state-router';
import Home from './components/Home';
import NotFoundPage from './components/NotFoundPage';
import BodyPartType from './pages/crud/bodyPartType/BodyPartType';
import ComplexityLevelType from './pages/crud/complexityleveltype/ComplexityLevelType';
import ComplexityLevelTypeEdit from './pages/crud/complexityleveltype/ComplexityLevelTypeEdit';
import DietTypeEdit from './pages/crud/dietType/DietTypeEdit'
import DietType from './pages/crud/dietType/DietType'
import Trainer from './pages/crud/trainer/Trainer'


const viewMap = {
    home: <Home />,
    notFound: <NotFoundPage />,
    body:<BodyPartType/>,
    complexityleveltype: <ComplexityLevelType />,
    complexityleveltypeedit: <ComplexityLevelTypeEdit />,
    diettype: <DietType />,
    diettypeedit: <DietTypeEdit />,
    trainer: <Trainer />
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
