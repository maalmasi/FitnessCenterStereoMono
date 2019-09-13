import React from 'react';
import HttpClient from '../../../common/HttpClient'

export default class DietTypeDataStore extends React.Component{

    constructor(){
        this.httpClient = new HttpClient("dietType");
    }


}