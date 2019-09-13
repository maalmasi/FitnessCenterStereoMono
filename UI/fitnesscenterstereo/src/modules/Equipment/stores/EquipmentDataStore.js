import React from 'react';
import HttpClient from '../../../common/HttpClient'

export default class EquipmentDataStore extends React.Component{

    constructor(){
        this.httpClient = new HttpClient("equipment");
    }


}