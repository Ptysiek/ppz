using ppz_fkmm.BackSource.DataModels;
using ppz_fkmm.BackSource.EndPoints;
using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace ppz_fkmm.BackSource.Controls
{
    public class AuthenticationControler
    {
        public string error = "error not initialized";
        public string errorCode = "error not initialized";

        public async Task<string> Login(HttpControler httpControler, string username, string password)
        {
            var url = "https://bhtjsvntyg.execute-api.eu-central-1.amazonaws.com/dev/user/login/" + username;
            HttpContent content = new StringContent("{\"password\": \"" + password + "\"}");

            using (HttpResponseMessage response = await httpControler.ApiClient.PostAsync(url, content))
            {
                error = response.Content.ReadAsStringAsync().Result;
                errorCode = response.ReasonPhrase;

                if (!response.IsSuccessStatusCode)
                {
                    return error;
                }
                if (error.Contains("false"))
                {
                    return error;
                }
            }
            return "";
        }

        public async Task<bool> Register(HttpControler httpControler,  string username, string password)
        {
            var url = "https://bhtjsvntyg.execute-api.eu-central-1.amazonaws.com/dev/user";
            var data = "{\"login\": \"" + username + "\", \"password\": \"" + password + "\", \"city\": \"testCity\", \"street\": \"testStreet\"}";
            HttpContent content = new StringContent(data);

            using (HttpResponseMessage response = await httpControler.ApiClient.PostAsync(url, content))
            {
                error = response.Content.ReadAsStringAsync().Result;
                errorCode = response.ReasonPhrase;
            }
            return true;
        }
    }
}
