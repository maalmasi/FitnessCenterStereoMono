import React from 'react';
import HttpClient from '../../../common/HttpClient'

export default class BodyPartTypeDataStore extends React.Component{

    constructor(){
        this.httpClient = new HttpClient("bodyPartType");
    }


}