import React from 'react';
import HttpClient from '../../../common/HttpClient'

export default class ExercisesDataStore extends React.Component{

    constructor(){
        this.httpClient = new HttpClient("exercises");
    }


}