import React from 'react';
import HttpClient from '../../../common/HttpClient'
import { observable, action } from 'mobx';
import BodyPartTypeForm from '../components/BodyPartTypeForm'

export default class BodyPartTypeDataStore extends React.Component {

    constructor() {
        super();
        this.httpClient = new HttpClient("bodyPartType");

    }

    @observable response;
    @observable result;



    @action.bound async find (filter){
        const options = {
            method: "GET",
        }
        const request = new Request(this.httpClient.webApiUrl + "?" + filter, options);
        this.response = await fetch(request);
        this.result = await this.response.json();

        return this.result;
    }

    @action.bound async post (model){
        const headers = new Headers();
        headers.append("Content-Type", "application/json");
        var options = {
            method: "POST",
            headers,
            body: JSON.stringify(model)
        }
        const request = new Request(this.httpClient.webApiUrl, options);
        this.response = await fetch(request);
        this.result = await this.response.json();

        return this.result;

    }

    @action.bound async put(model) {
        const headers = new Headers();
        headers.append("Content-Type", "application/json");
        var options = {
            method: "PUT",
            headers,
            body: JSON.stringify(model)
        }
        const request = new Request(this.httpClient.webApiUrl, options);
        this.response = await fetch(request);
        this.result = await this.response.json();

        return this.result;
    }

    @action.bound async delete(id){

        const headers=new Headers();
        headers.append("Content-Type","application/json");
        var options = {
            method: "DELETE",
            headers
        }
         const request=new Request(this.httpClient.webApiUrl + "/" + id, options);
         this.response=await fetch(request);
         this.result=await this.response.json();

         return this.result;

    }

}