/*
 * Created by US Legal PRO.
*/
using System;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFileApp.Helper
{
	
	public class APICall
	{ 
		readonly string BASE_URL = null;
		string authtoken = null;
        string clienttoken = null;
        string env = null;
        string state = null;
		
		public APICall(string env, string state, string clienttoken){
            this.clienttoken = clienttoken;
            try
            {
                if (env.ToUpper().Equals("PROD"))
                {
                    BASE_URL = Properties.Settings.Default.ProdApiEndPoint + state.ToLower();
                    this.env = state;
                    this.state = state;
                }
                else
                {
                    BASE_URL = Properties.Settings.Default.StageApiEndPoint + state.ToLower();
                    this.env = state + "-stage";
                    this.state = state;
                }
            }
            catch (Exception)
            {

                throw;
            }
		}

        public string getEnv()
        {
            return env;
        }
		
		//-------------------------------------------------------------------------------------------------------
		//For any user specific action, need to login and get authtoken
		public async Task<string> AuthenticateAsync(string clientoken, string username, string password)
        {
            try
            {

                var client = new RestClient(BASE_URL + AppConstants.AUTH_API);
                client.AddDefaultHeader("clienttoken", clientoken);
                var request = new RestRequest(Method.POST);
                request.AddParameter("application/json", "{ \"data\": { \"password\": \"" + password + "\", \"username\": \"" + username + "\" } }", ParameterType.RequestBody);
                IRestResponse response = await client.ExecuteAsync(request);
                var content = response.Content;
                dynamic json = SimpleJson.DeserializeObject(content);
                if (!response.IsSuccessful)
                {
                    throw new Exception(json["message"]);
                }
                this.authtoken = json["item"]["auth_token"];
                return authtoken;
            }
            catch (Exception)
            {

                throw;
            }
		}
		
		//-------------------------------------------------------------------------------------------------------
		//For any user specific action, need to login and get authtoken
		public dynamic GetFilingDetails(string filingid)
		{
            try
            {
                var client = new RestClient(BASE_URL + AppConstants.FILING_API + filingid);
                client.AddDefaultHeader("authtoken", authtoken);
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                var content = response.Content;
                dynamic json = SimpleJson.DeserializeObject(content);
                return json;
            }
            catch (Exception)
            {

                throw;
            }
		}
		//-------------------------------------------------------------------------------------------------------
		//For any user specific action, need to login and get authtoken
		public bool CancelFiling(string filingid)
		{
            try
            {
                var client = new RestClient(BASE_URL +AppConstants.FILING_API + filingid);
                client.AddDefaultHeader("authtoken",authtoken);
                var request = new RestRequest(Method.DELETE);
                IRestResponse response = client.Execute(request);
                dynamic json = SimpleJson.DeserializeObject(response.Content);
                if (!response.IsSuccessful)
                {
                    throw new Exception(json["message"]);
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
		}
		//-------------------------------------------------------------------------------------------------------
		//Actual filing
		public dynamic Efile(string id, string payload, List<string> filepaths)
		{
            try
            {
                var client = new RestClient(BASE_URL + AppConstants.EFILE_API);
                client.ConfigureWebRequest((r) => { r.ServicePoint.Expect100Continue = false; r.KeepAlive = true; });
                client.Timeout = 60000;
                client.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
                client.AddDefaultHeader("authtoken", authtoken);
                var request = new RestRequest(Method.POST);
                request.AddParameter("meta_data", payload);
                request.AddParameter("strict", "false");
                foreach (var filepath in filepaths)
                {
                    request.AddFile("file", filepath);
                }
                request.AlwaysMultipartFormData = true;
                IRestResponse response = client.Execute(request);
                dynamic json = SimpleJson.DeserializeObject(response.Content);
                if (!response.IsSuccessful)
                {
                    throw new Exception(json["message"]);
                }
                json["id"] = id;
                return json;
            }
            catch (Exception)
            { 
                throw;
            }
		}
		//-------------------------------------------------------------------------------------------------------
		//For any user specific action, need to login and get authtoken
		public string CreateBatch(string batchname, string batchid, int batchsize = 100)
		{
            try
            {
                string integration_type = "";
                if(state == "MD")
                {
                    integration_type = "REMOTE";
                } else
                {
                    batchsize = 100;
                }
                var client = new RestClient(BASE_URL + AppConstants.BATCH_API);
                client.AddDefaultHeader("authtoken", authtoken);
                var request = new RestRequest(Method.POST);
                request.AddParameter("application/json", "{ \"data\": { \"batch_name\": \"" + batchname + "\", \"batch_id\": \"" + batchid + "\", \"batch_size\": \"" + batchsize + "\", \"integration_type\": \"" + integration_type + "\" } }", ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                var content = response.Content;
                dynamic json = SimpleJson.DeserializeObject(content);
                if (!response.IsSuccessful)
                {
                    throw new Exception(json["message"]);
                }
                return json["item"]["batch_id"];
            }
            catch (Exception)
            {

                throw;
            }
		}

		//-------------------------------------------------------------------------------------------------------
		//For any user specific action, need to login and get authtoken
		public dynamic Listbatches(int startBatch=1, int limit=10, string searchString="")
		{
            try
            {
                var client = new RestClient(BASE_URL + AppConstants.BATCH_LISTING_API);
                string api = string.Format("/batches?start={0}&limit={1}", startBatch, limit);

                if (!string.IsNullOrEmpty(searchString))
                    api = api + "&qs=" + searchString;
                else
                    api = api + "&q=BATCH";

                client = new RestClient(BASE_URL + api);

                client.AddDefaultHeader("authtoken", authtoken);
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                var content = response.Content;
                dynamic json = SimpleJson.DeserializeObject(content);
                if (!response.IsSuccessful)
                {
                    throw new Exception(json["message"]);
                }
                return json;
            }
            catch (Exception)
            {

                throw;
            }
		}
		
		//-------------------------------------------------------------------------------------------------------
		//For any user specific action, need to login and get authtoken
		public dynamic GetBatchDetails(string batchid)
		{
            try
            {
                var client = new RestClient(BASE_URL + AppConstants.BATCH_API + "/" + batchid);
                client.AddDefaultHeader("authtoken", authtoken);
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                var content = response.Content;
                dynamic json = SimpleJson.DeserializeObject(content);
                if (!response.IsSuccessful)
                {
                    throw new Exception(json["message"]);
                }
                return json;
            }
            catch (Exception)
            {

                throw;
            }
		}
		//-------------------------------------------------------------------------------------------------------
		//For any user specific action, need to login and get authtoken
		public bool DeleteBatch(string batchid)
		{
            try
            {
                var client = new RestClient(BASE_URL + AppConstants.BATCH_API + "/" + batchid);
                client.AddDefaultHeader("authtoken", authtoken);
                var request = new RestRequest(Method.DELETE);
                IRestResponse response = client.Execute(request);
                var content = response.Content;
                dynamic json = SimpleJson.DeserializeObject(content);
                if (!response.IsSuccessful)
                {
                    throw new Exception(json["message"]);
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
		}
		//-------------------------------------------------------------------------------------------------------
		//For any user specific action, need to login and get authtoken
		public dynamic GetEnvelopDetails(string envelopeid)
		{
            try
            {
                var client = new RestClient(BASE_URL + AppConstants.ENVELOPE_API + "/" + envelopeid);
                client.AddDefaultHeader("authtoken", authtoken);
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                var content = response.Content;
                dynamic json = SimpleJson.DeserializeObject(content);
                if (!response.IsSuccessful)
                {
                    throw new Exception(json["message"]);
                }
                return json;
            }
            catch (Exception)
            {

                throw;
            }
		}

        //-------------------------------------------------------------------------------------------------------
        //For any user specific action, need to login and get authtoken
        public dynamic refreshBatch(string batchId)
        {
            try
            {
                var client = new RestClient(BASE_URL + AppConstants.BATCH_API + "/" + batchId + "/refresh");
                client.AddDefaultHeader("authtoken", authtoken);
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                var content = response.Content;
                dynamic json = SimpleJson.DeserializeObject(content);
                if (!response.IsSuccessful)
                {
                    throw new Exception(json["message"]);
                }
                return json;
            }
            catch (Exception)
            {

                throw;
            }
        }


        //-------------------------------------------------------------------------------------------------------
        //For any user specific action, need to login and get authtoken
        public dynamic refreshEnvelope(string envelopeId)
        {
            try
            {
                var client = new RestClient(BASE_URL + AppConstants.ENVELOPE_API + envelopeId + "/refresh");
                client.AddDefaultHeader("authtoken", authtoken);
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                var content = response.Content;
                dynamic json = SimpleJson.DeserializeObject(content);
                if (!response.IsSuccessful)
                {
                    throw new Exception(json["message"]);
                }
                return json;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //-------------------------------------------------------------------------------------------------------
        //For any user specific action, need to login and get authtoken
        public dynamic get(string path)
        {
            try
            {
                var client = new RestClient(BASE_URL +  path);
                client.AddDefaultHeader("clienttoken", clienttoken);
                client.AddDefaultHeader("authtoken", authtoken);
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                var content = response.Content;
                dynamic json = SimpleJson.DeserializeObject(content);
                if (!response.IsSuccessful)
                {
                    throw new Exception(json["message"]);
                }
                return json;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task<dynamic> getAsync(string path, bool isclienttoken)
        {
            try
            {
                var client = new RestClient(BASE_URL + path);
                if (isclienttoken)
                {
                    client.AddDefaultHeader("clienttoken", clienttoken);
                }
                else
                {
                    client.AddDefaultHeader("authtoken", authtoken);
                }
                var request = new RestRequest(Method.GET);
                IRestResponse response = await client.ExecuteAsync(request);
                var content = response.Content;
                dynamic json = SimpleJson.DeserializeObject(content);
                if (!response.IsSuccessful)
                {
                    throw new Exception(json["message"]);
                }
                return json;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //-------------------------------------------------------------------------------------------------------
        //For any user specific action, need to login and get authtoken
        public dynamic getUsingAuthToken(string path)
        {
            try
            {
                var client = new RestClient(BASE_URL + "/" + path);
                client.AddDefaultHeader("authtoken", authtoken);
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                var content = response.Content;
                dynamic json = SimpleJson.DeserializeObject(content);
                if (!response.IsSuccessful)
                {
                    throw new Exception(json["message"]);
                }
                return json;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}