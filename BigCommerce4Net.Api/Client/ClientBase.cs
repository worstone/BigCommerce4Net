#region License
//   Copyright 2013 Ken Worst - R.C. Worst & Company Inc.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License. 
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;
using Newtonsoft.Json;

namespace BigCommerce4Net.Api
{
    public abstract class ClientBase
    {
        private readonly Configuration _Configuration;

        protected ClientBase(Configuration _configuration) {
            _configuration.AreConfigurationSet();
            _Configuration = _configuration;
        }
        protected IClientResponse<T> Count<T>(string resourceEndpoint)
            where T : new() {
                return Count<T>(resourceEndpoint, null);
        }

        protected IClientResponse<T> Count<T>(string resourceEndpoint, IFilter filter)
            where T :  new() {

            var request = new RestRequest(resourceEndpoint);
            if (filter != null) {
                filter.AddFilter(request);
            }

            var response = RestGet<T>(request);

            var clientResponse = new ClientResponse<T>() {
                RestResponse = response,
            };

            if (response.Data != null) {
                clientResponse.Data = response.Data;
            }

            DeserializeErrorData<T>(clientResponse);
            return clientResponse as IClientResponse<T>;
        }
        protected IClientResponse<T> GetData<T>(string resourceEndpoint)
            where T : new() {
            return GetData<T>(resourceEndpoint, null);
        }

        protected IClientResponse<T> GetData<T>(string resourceEndpoint, IFilter filter)
            where T : new() {
            var request = new RestRequest(resourceEndpoint);

            if (filter != null) {
                filter.AddFilter(request);
            }
            
            var response = RestGet<T>(request);

            var clientResponse = new ClientResponse<T>() {
                RestResponse = response,
            };
            if (response.Data != null) {
                clientResponse.Data = response.Data;
            }

            DeserializeErrorData<T>(clientResponse);
            return (IClientResponse<T>)clientResponse;
        }

        protected IClientResponse<T> PutData<T>(string resourceEndpoint, string json)
            where T : new() {
            var request = new RestRequest(resourceEndpoint);

            request.AddParameter("application/json", json, ParameterType.RequestBody);

            var response = RestPut<T>(request);

            var clientResponse = new ClientResponse<T>() {
                RestResponse = response,
                Data = response.Data
            };

            DeserializeErrorData<T>(clientResponse);
            return clientResponse;
        }

        protected IClientResponse<T> PostData<T>(string resourceEndpoint, string json)
            where T : new() {
            var request = new RestRequest(resourceEndpoint);

            request.AddParameter("application/json", json, ParameterType.RequestBody);

            var response = RestPost<T>(request);

            var clientResponse = new ClientResponse<T>() {
                RestResponse = response,
                Data = response.Data
            };

            DeserializeErrorData<T>(clientResponse);
            return clientResponse;
        }
        protected IClientResponse<bool> DeleteData(string resourceEndpoint) {

            IClientResponse<bool> clientResponse = null;

            //Just making sure you want to delete data --just for little extra safety
            if (_Configuration.AllowDeletions) {

                var request = new RestRequest(resourceEndpoint);

                var response = RestDelete<object>(request);

                clientResponse = new ClientResponse<bool>() {
                    RestResponse = response,
                    Data = response.StatusCode == System.Net.HttpStatusCode.NoContent ? true : false
                };

            } else {
                clientResponse = new ClientResponse<bool>() {
                    RestResponse = null,
                    Data =  false
                };
            }
            DeserializeErrorData<bool>(clientResponse);
            return clientResponse;
        }
        protected IClientResponse<T> GetHttpOptionsData<T>(string resourceEndpoint)
            where T : new() {
            var request = new RestRequest(resourceEndpoint);

            var response = RestOptions<T>(request);

            var clientResponse = new ClientResponse<T>() {
                RestResponse = response,
                Data = response.Data
            };

            DeserializeErrorData<T>(clientResponse);
            return clientResponse;
        }

        //Private Methods
        private void DeserializeErrorData<T>(IClientResponse<T> response) {

            if (response.RestResponse.StatusCode == System.Net.HttpStatusCode.OK) return;
            if (response.RestResponse.StatusCode == System.Net.HttpStatusCode.Created) return;
            if (response.RestResponse.StatusCode == System.Net.HttpStatusCode.Accepted) return;
            if (response.RestResponse.StatusCode == System.Net.HttpStatusCode.NoContent) return;
            
            try {
                response.ResponseErrors = JsonConvert.DeserializeObject<List<Domain.Error>>(response.RestResponse.Content);
            } catch (JsonSerializationException ex) {
                log.Warn("Trouble Deserialize Error Object", ex);
                throw;
            }
        }

        private IRestResponse<T> RestGet<T>(IRestRequest request) where T : new() {
            request.Method = Method.GET;

            var client = new RestClient(_Configuration.ServiceURL);

            var response = RestExecute<T>(request, client);

            return response;
        }
        private IRestResponse<T> RestPut<T>(IRestRequest request) where T : new() {
            request.Method = Method.PUT;

            var client = new RestClient(_Configuration.ServiceURL);

            var response = RestExecute<T>(request, client);

            return response;
        }
        private IRestResponse<T> RestPost<T>(IRestRequest request) where T : new() {
            request.Method = Method.POST;

            var client = new RestClient(_Configuration.ServiceURL);

            var response = RestExecute<T>(request, client);

            return response;
        }
        private IRestResponse<T> RestDelete<T>(IRestRequest request) where T : new() {
            request.Method = Method.DELETE;
            
            var client = new RestClient(_Configuration.ServiceURL);

            var response = RestExecute<T>(request, client);

            return response;
        }
        private IRestResponse<T> RestOptions<T>(IRestRequest request) where T : new() {
            request.Method = Method.OPTIONS;

            var client = new RestClient(_Configuration.ServiceURL);

            var response = RestExecute<T>(request, client);

            return response;
        }



        private IRestResponse<T> RestExecute<T>(IRestRequest request, IRestClient restClient) where T : new() {

            request.RequestFormat = DataFormat.Json;
            request.AddParameter("Accept", "application/json", ParameterType.HttpHeader);
            request.AddParameter("User-Agent", _Configuration.UserAgent, ParameterType.HttpHeader);


            ((RestClient)restClient).AddHandler("application/json", new Deserializers.NewtonSoftJsonDeserializer());
            
            var client = restClient;
            client.Authenticator = new HttpBasicAuthenticator(_Configuration.UserName, _Configuration.UserApiKey);
            client.Timeout = _Configuration.RequestTimeout;

            var response = client.Execute<T>(request);

            CheckForThrottling(response);

            return response;
        }
        private void CheckForThrottling(IRestResponse response) {
            if (_Configuration.RequestThrottling == true) {
                var head = response.Headers.Where(x => x.Name == "X-BC-ApiLimit-Remaining").FirstOrDefault();
                if (head != null) {
                    int limitvalue;
                    bool wasParsed = int.TryParse(head.Value.ToString(), out limitvalue);
                    if (wasParsed) {
                        if (limitvalue <= 1000) {
                            log.Warn("------ Throttling Enabled Until Request Limit Gets About 1000 ------");
                            System.Threading.Thread.Sleep(_Configuration.RequestThrottlingDelay);
                        }
                    }
                }
            }

        }
        protected static void ShowIdAndApiLimit(object id, IRestResponse restResponse) {
            var apiLimit = restResponse.Headers.Where(x => x.Name == "X-BC-ApiLimit-Remaining").FirstOrDefault().Value;
            log.InfoFormat("Id {0} -- API Limit: {1}", id, apiLimit);
        }
        


        protected void StatusCodeLogging(RestSharp.IRestResponse response, Type type) {
            if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                log.InfoFormat("[{0}] - Http Status Code: {1} - {2}", type.Name, (int)response.StatusCode, response.StatusDescription);
            }
            else {
                log.ErrorFormat("[{0}] - Http Status Code: {1} - {2}", type.Name, (int)response.StatusCode, response.StatusDescription);
            }
        }


        protected List<T> RecordPaging<T>(IFilter filter, IParentResourcePaging<T> client)
        {
            List<T> items = new List<T>();

            int itemsCount = 0;
            int pageCount = 0;
            int remainingCount = 0;
            int recordsPerPage;

            if (_Configuration.RecordsPerPage > _Configuration.MaxPageLimit)
                recordsPerPage = _Configuration.MaxPageLimit;
            else
                recordsPerPage = _Configuration.RecordsPerPage;

            itemsCount = ((Domain.ItemCount)client.Count(filter).Data).Count;
            pageCount = itemsCount / recordsPerPage;
            remainingCount = itemsCount % recordsPerPage;

            for (int i = 1; i <= pageCount; i++) {
                filter.Page = i;
                filter.Limit = recordsPerPage;

                int retrys = 0;
                do {
                    var response = client.Get(filter);
                    if (response.RestResponse.StatusCode == System.Net.HttpStatusCode.OK && response.Data != null) {
                        
                        items.AddRange(response.Data as List<T>);
                        log.Info(GetPagingStatus(response.RestResponse, filter.Page, items.Count));
                        retrys = int.MaxValue;
                    }
                    else {
                        retrys++;
                        log.ErrorFormat(GetErrorStatus(response.RestResponse));
                        System.Threading.Thread.Sleep(_Configuration.ErrorRetryDelay);
                    }

                } while (retrys <= _Configuration.ErrorRetryMax);
                
                if (retrys != int.MaxValue) {
                    throw new HttpServerException("Http Server not responding after retries");
                }
                

            }
            if (remainingCount > 0) {
                filter.Page = pageCount + 1;
                filter.Limit = recordsPerPage;

                int retrys = 0;
                do {
                    var response = client.Get(filter);
                    if (response.RestResponse.StatusCode == System.Net.HttpStatusCode.OK && response.Data != null) {

                        items.AddRange(response.Data as List<T>);

                        log.Info(GetPagingStatus(response.RestResponse, filter.Page, items.Count));
                        retrys = int.MaxValue;
                    }
                    else {
                        retrys++;
                        log.ErrorFormat(GetErrorStatus(response.RestResponse));
                        System.Threading.Thread.Sleep(_Configuration.ErrorRetryDelay);
                    }

                } while (retrys <= _Configuration.ErrorRetryMax);

                if (retrys != int.MaxValue) {
                    throw new HttpServerException("Http Server not responding after retries");
                }
            }
            return items;
        }
        private static string GetErrorStatus(RestSharp.IRestResponse response) {
            string str = string.Format("Http Status Code: {0} - {1} URL: {2}",
                            (int)response.StatusCode,
                            response.StatusDescription,
                            response.ResponseUri.AbsoluteUri);
            return str;
        }
        private static string GetPagingStatus(RestSharp.IRestResponse response, int? page, int count) {
            if (page == null) {
                page = 0;
            }
            string str = string.Format("Page {0} Record Count {1} -- API Limit: {2}", page, count,
                        response.Headers.Where(x => x.Name == "X-BC-ApiLimit-Remaining").FirstOrDefault().Value);

            return str;
        }
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }
}
