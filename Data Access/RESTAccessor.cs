using System.Globalization;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Configuration;
using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Linq;

namespace Data_Access
{
    public class RESTAccessor
    {
        private string _aadInstance;
        private string _tenant;
        private string _clientId;
        private Uri _redirectUri;
        private string _authority;
        private HttpClient _httpClient;
        private string _resourceId;

        public List<string> EmailCollection { get; set; }
        public string Token { get; set; }
        public string JSON { get; set; }

        public RESTAccessor()
        {
            _aadInstance = ConfigurationManager.AppSettings["ida:AADInstance"];
            _redirectUri = new Uri(ConfigurationManager.AppSettings["ida:RedirectUri"]);
            _tenant = ConfigurationManager.AppSettings["ida:Tenant"];
            _clientId = ConfigurationManager.AppSettings["ida:ClientId"];
            _resourceId = ConfigurationManager.AppSettings["todo:ResourceId"];
            _authority = String.Format(CultureInfo.InvariantCulture, _aadInstance, _tenant);
            _httpClient = new HttpClient();

            EmailCollection = new List<string>();

            Task t = Authenticate();
            t.Wait();
        }

        private async Task Authenticate()
        {
            var authContext = new AuthenticationContext(_authority);
            try
            {
                var result = await authContext.AcquireTokenAsync(_resourceId, _clientId, _redirectUri, new PlatformParameters(PromptBehavior.Always));
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", result.AccessToken);
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                
            }
            catch (AdalException ex)
            {
                // An unexpected error occurred.
                string message = ex.Message;
                if (ex.InnerException != null)
                {
                    message += "Error Code: " + ex.ErrorCode + "Inner Exception : " + ex.InnerException.Message;
                    Token = message;
                } 
            }
            return;
        }

        public async Task<List<string>> RetrieveInbox()
        {
            var response = await _httpClient.GetAsync($"{_resourceId}/api/v2.0/me/messages");
            var responseString = await response.Content.ReadAsStringAsync();

            var jObject = JObject.Parse(responseString);
            var jObjectEmailTokens = jObject.SelectTokens("value");
            var emails = new List<string>();

            foreach (var email in jObjectEmailTokens.Children())
            {
                var id = email.SelectToken("Id").Value<string>();

                var subjectData = email.SelectToken("Subject").Value<string>();
                var subject = string.IsNullOrEmpty(subjectData) ? string.Empty : $"Subject: {subjectData}";

                var from = string.Empty;
                try
                {
                    from = email.SelectToken("Sender.EmailAddress.Address").Value<string>();
                }

                catch
                {
                    from = "SYSTEM-GENERATED";
                }

                finally
                {
                    emails.Add($"From: {from};\t{subject}\nEmail Id: {id}\n");
                }
            }

            return emails;
        }
    }
}
