import React from 'react';
import HttpClient from '../../../common/HttpClient'

export default class PlanDataStore extends React.Component{

    constructor(){
        this.httpClient = new HttpClient("plan");
    }


}