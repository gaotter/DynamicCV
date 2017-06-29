// Get the api url based on the current page input example '/api/CustomersApi' 
export function getApiUrl(apiUri: string) {
    const hostname = window.location.hostname;
    const port = window.location.port ? ':' + window.location.port : '';
    const protocol = window.location.protocol;
    const baseUrl = protocol + hostname + port;
    

    const apiUriStr = apiUri.indexOf('/') === 0 ? apiUri : '/' + apiUri;

    return apiUriStr;
}