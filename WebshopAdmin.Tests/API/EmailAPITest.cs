using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace WebshopAdmin.Tests.API
{
    [TestClass]
    public class EmailiAPITest
    {
        private static string json;
        private static string baseUri = "https://graphisoftid-api-test.graphisoft.com";
        private string applicationUri = "api/Account/PostIsUserWithEmailExists";
        protected RestClient client=new RestClient(baseUri) { Timeout = 2000 };

        [TestMethod]
        public void ConnectionTest()
        {
            var r = RequestEmailValidation("sducsai1@graphisoft.com");
            try {
                Console.WriteLine(r.Content);
                var data = new JavaScriptSerializer().DeserializeObject(r.Content);
                var keyValuePair = (Dictionary<string, Object>)data;
                Assert.IsNotNull(data);
            }
            catch (Exception)
            {
                Assert.Fail("deserializing");
            }
        }

        [TestMethod]
        public void ValidEmailTest() {
            Assert.IsTrue(IsValid(RequestEmailValidation("sducsai1@graphisoft.com")));
            Assert.IsTrue(IsValid(RequestEmailValidation("sducsai2@graphisoft.com")));
            Assert.IsTrue(IsValid(RequestEmailValidation("sducsai3@graphisoft.com")));
        }

        [TestMethod]
        public void InvalidEmailTest() {
            Assert.IsFalse(IsValid(RequestEmailValidation("ísducsai3@graphisoft.com")));
            Assert.IsFalse(IsValid(RequestEmailValidation("barki@graphisoft.com")));
            Assert.IsFalse(IsValid(RequestEmailValidation(@"ísd/:\\ai3@gr#&>ap\""hisoft.com")));
        }
        [TestMethod]
        public void BadServerTest() {
            //TODO
        }
        [TestMethod]
        public void BadApplicationTest() {
            //TODO
        }


        private IRestResponse RequestEmailValidation (string email)
        {
            var request = new RestRequest(applicationUri, Method.POST, DataFormat.Json);
            request.AddJsonBody(new EmailAPIRequest()
            {
                GraphisoftUserDto = new UserData() { EmailAddress = email }
            });
            return client.Execute(request);

        }
        private bool IsValid(IRestResponse restResponse)
        {
            var data = new JavaScriptSerializer().DeserializeObject(restResponse.Content);
            var keyValuePair = (data as Dictionary<string, Object>);
            return (bool)keyValuePair["UserWithEmailExists"];
        }
    }
}
