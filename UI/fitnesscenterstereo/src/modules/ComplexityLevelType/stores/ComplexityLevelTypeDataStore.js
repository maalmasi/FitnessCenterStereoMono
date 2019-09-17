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
}