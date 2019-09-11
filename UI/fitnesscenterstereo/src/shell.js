import React from 'react';
import { inject } from 'mobx-react';
import { RouterView } from 'mobx-state-router';
import Home from './components/Home';
import NotFoundPage from './components/NotFoundPage';
import DietType from './pages/crud/dietType/DietType'
import Trainer from './pages/crud/trainer/TrainerEditForm'


const viewMap = {
    home: <Home />,
    notFound: <NotFoundPage />,
    dietType: <DietType />,
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