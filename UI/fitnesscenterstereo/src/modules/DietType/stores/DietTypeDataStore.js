import React from 'react';
import HttpClient from '../../../common/HttpClient'
import { observable, action } from 'mobx'

export default class DietTypeDataStore extends React.Component {

    constructor() {
        super();
        this.httpClient = new HttpClient("dietType");
    }

    @observable response;
    @observable result;

    @action.bound find = async (filter) => {
        const options = {
            method: "GET",
        }
        const request = new Request(this.httpClient.webApiUrl + "?" + filter, options);
        this.response = await fetch(request);
        this.result = await this.response.json();

        return this.result;
    };


}