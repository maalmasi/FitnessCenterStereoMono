import HttpClient from '../../../common/HttpClient'

export default class ComplextiyLevelTypeDataStore {
    constructor() {
        this.httpClient = new HttpClient("complexityLevelType");
    }

    find = async (filter) => {
        const options = {
            method: "GET",
        }
        const request = new Request(this.httpClient.webApiUrl + "?" + filter, options);
        this.response = await (fetch(request));
        this.resultItems = await this.response.json();
        return this.resultItems;
    }

    delete = async (id) => {
        const options = {
            method: "DELETE"
        }
        const request = new Request(this.httpClient.webApiUrl + "/" + id, options);
        this.response = await (fetch(request));
        this.result = await this.response.json();
        return this.result;
    }

    get = async (id) => {
        const options = {
            method: "GET"
        }
        const request = new Request(this.httpClient.webApiUrl + "/" + id, options);
        this.response = await (fetch(request));
        this.result = await this.response.json();
        return this.result;
    }

    update = async (item) => {
        const headers = new Headers();
        headers.append("Content-Type", "application/json");
        var options = {
            method: "PUT",
            headers,
            body: JSON.stringify(item)
        }
        const request = new Request(this.httpClient.webApiUrl, options);
        let response = await fetch(request);
        let result = await response.json();
        return result;
    }
}