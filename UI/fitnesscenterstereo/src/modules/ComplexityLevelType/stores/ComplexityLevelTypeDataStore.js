import React from 'react';
import HttpClient from '../../../common/HttpClient'

export default class ComplextiyLevelTypeDataStore extends React.Component{

    constructor(){
        this.httpClient = new HttpClient("complextiyLevelType");
    }


}