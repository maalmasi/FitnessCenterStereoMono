import React from 'react';
import SimpleInput from '../../../common/SimpleInput';
import form from './formFields'
import BodyPartTypeEditViewStore from '../stores/BodyPartTypeEditViewStore'
import { tsConstructorType } from '@babel/types';
import {inject,observer} from 'mobx-react'


@inject(
    i=>({
        viewStore:new BodyPartTypeEditViewStore(i.rootStore)
    })
)

 class BodyPartTypeForm extends React.Component {
     constructor(props){
         super(props)    
         }


 
  
    render() {
         const{viewStore}=this.props;
        return (
            <form onSubmit={form.onSubmit}>
                <SimpleInput field={form.$('name')} />
                <SimpleInput field={form.$('abbreviation')}/>
                <br />
                <button type="submit" className={'btn-primary'} onClick={()=>viewStore.onCreate()}>Submit</button>
                <button type="button" className={'btn-secondary'} onClick={form.onClear}>Clear</button>
                <button type="button" className={'btn-secondary'} onClick={form.onReset}>Reset</button>
                <p>{form.error}</p>
            </form>
        );
    }
}

export default BodyPartTypeForm;