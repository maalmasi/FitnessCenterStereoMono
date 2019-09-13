import React from 'react';
import HttpClient from '../../../common/HttpClient'

export default class MembershipDataStore extends React.Component{

    constructor(){
        this.httpClient = new HttpClient("membership");
    }


}