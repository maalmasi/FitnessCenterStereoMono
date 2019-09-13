import React from 'react';


export default class HttpClient extends React.Component{

    constructor(name){
        super();
        this.webApiUrl= "http://localhost:44300/api/"+{name};
    }


}