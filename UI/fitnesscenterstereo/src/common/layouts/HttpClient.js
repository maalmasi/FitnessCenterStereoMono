import React from 'react';


export default class HttpClient extends React.Component{

    constructor(name){
        super();
        this.webApiUrl= "http://localhost:44300/api/"+{name};
    }

    get = async (urlParams) => {
        const options = {
            method: "GET",
        }
     const request = new Request(this.webApiUrl + "?" + urlParams, options);
     const response = await fetch(request);
     return await response.json();
    }

}