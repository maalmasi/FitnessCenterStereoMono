import React from 'react';
import HttpClient from '../../../common/HttpClient'
import {observable,action} from 'mobx';
const webApiUrl = 'https://localhost:44300/api/bodyPartType';

export default class BodyPartTypeDataStore extends React.Component{

    constructor(){
        super();
        this.httpClient = new HttpClient("bodyPartType");
   
    }

    @observable isLoading = true;
    @observable resultItems;
    @observable response;
    @observable result;
    @observable filter;
    @observable bodyPartTypes;
    @observable page = 1;
    @observable recordsPerPage = 10;
    @observable searchQuery = "";


    
        
        @action.bound get = async (filter) => {
            const options = {
                method: "GET",
                }
            const request = new Request(webApiUrl + "?" + filter, options);
            this.response = (await fetch(request));
            this.isLoading = false;
            this.result = await this.response.json();
                
            return this.result;
        }
        
    }