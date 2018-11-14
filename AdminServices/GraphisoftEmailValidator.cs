using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using RestSharp;


namespace AdminServices
{
    public static class GraphisoftEmailValidator
    {
        private static readonly string baseUri = "https://graphisoftid-api-test.graphisoft.com";
        private static readonly string applicationUri = "api/Account/PostIsUserWithEmailExists";
        private static RestClient client = new RestClient(baseUri) { Timeout = 2000 };

        public static bool IsValid(string email)
        {
            var request = new RestRequest(applicationUri, Method.POST, DataFormat.Json);
            request.AddJsonBody(new EmailAPIRequest()
            {
                GraphisoftUserDto = new UserData() { EmailAddress = email }
            });
            try
            {
                var r = client.Execute(request);
                var data = new JavaScriptSerializer().DeserializeObject(r.Content);
                var keyValuePair = (data as Dictionary<string, Object>);
                return (bool)keyValuePair["UserWithEmailExists"];
            }
            catch (Exception)
            {
                //  service down? parse error?
                return false;
            }

        }
    }
    class EmailAPIRequest
    {
        public UserData GraphisoftUserDto { get; set; }
    }
    class UserData
    {
        public string EmailAddress { get; set; }
    }
}
