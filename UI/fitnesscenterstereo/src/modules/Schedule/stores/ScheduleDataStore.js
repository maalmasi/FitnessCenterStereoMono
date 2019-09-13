import React from 'react';
import HttpClient from '../../../common/HttpClient'

export default class ScheduleDataStore extends React.Component{

    constructor(){
        this.httpClient = new HttpClient("schedule");
    }


}