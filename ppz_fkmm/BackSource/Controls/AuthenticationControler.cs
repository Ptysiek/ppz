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

        public async Task<string> Login(HttpControler httpControler, string username, string password, bool user)
        {
            string url, body;
            if (user) {
                url = "https://bhtjsvntyg.execute-api.eu-central-1.amazonaws.com/dev/user/login/" + username;
                body = "{\"password\": \"" + password + "\"}";
            }
            else {
                url = "https://bhtjsvntyg.execute-api.eu-central-1.amazonaws.com/dev/seller/login/" + username;
                body = "{\"password\": \"" + password + "\"}";
            }
            var result = await SendLogin(httpControler, url, body);
            return result;
        }

        private async Task<string> SendLogin(HttpControler httpControler, string url, string body)
        {
            HttpContent content = new StringContent(body);

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

        public async Task<bool> Register(HttpControler httpControler,  string username, string password, bool user)
        { 
            string url, body;
            if (user) {
                url = "https://bhtjsvntyg.execute-api.eu-central-1.amazonaws.com/dev/user";
                body = "{\"login\": \"" + username + "\", \"password\": \"" + password + "\", \"city\": \"testCity\", \"street\": \"testStreet\"}";
            }
            else {
                url = "https://bhtjsvntyg.execute-api.eu-central-1.amazonaws.com/dev/seller";
                body = "{\"login\": \"" + username + "\", \"password\": \"" + password + "\", \"city\": \"testCity\", \"street\": \"testStreet\"}";
            }
            await SendRegister(httpControler, url, body);
            return true;
        }

        private async Task<bool> SendRegister(HttpControler httpControler, string url, string body)
        {
            HttpContent content = new StringContent(body);

            using (HttpResponseMessage response = await httpControler.ApiClient.PostAsync(url, content))
            {
                error = response.Content.ReadAsStringAsync().Result;
                errorCode = response.ReasonPhrase;
            }
            return true;
        }
    }
}
