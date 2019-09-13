import React from 'react';
import HttpClient from '../../../common/HttpClient'

export default class StepDataStore extends React.Component{

    constructor(){
        this.httpClient = new HttpClient("step");
    }


}