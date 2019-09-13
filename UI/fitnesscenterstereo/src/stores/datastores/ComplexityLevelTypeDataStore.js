import { observable, action } from 'mobx';

const webApiUrl = 'https://localhost:44300/api/complexityLevelType';

export default class ComplexityLevelTypeDataStore {
    @observable isLoading = true;
    @observable complexityLevelTypes = [];

    @action.bound get = async (urlParams) => {
        const options = {
            method: "GET",
        }
     const request = new Request(webApiUrl + "?" + urlParams, options);
     const response = await fetch(request);
     return response.json();
    }
}