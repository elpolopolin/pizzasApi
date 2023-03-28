public static class HTTPHelper {
    public static async Task<string> ObtenerPorId(string imdbId){

        string returnValue;
        HttpClient httpClient;

        returnValue = null;
        httpClient = new HttpClient();
        try{
            using (HttpResponseMessage response = await httpClient.GetAsync("https://www.omdbapi.com/?apikey=8005dd4&i=" + imdbId)) {
                returnValue = await response.Content.ReadAsStringAsync();
            }
        } catch (Exception ex) {
            returnValue = null;
        }
        return returnValue;
    }

  
}

