import React from 'react';
import HttpClient from '../../../common/HttpClient'

export default class BodyPartTypeDataStore extends React.Component{

    constructor(){
        super();
        this.httpClient = new HttpClient("bodyPartType");
    }


}