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
using BigCommerce4Net.Domain;

namespace BigCommerce4Net.Api.ResourceClients
{
    public class ClientOrderStatuses : 
        ClientBase, 
        IParentResourceGet<OrderStatus>
    {
        public ClientOrderStatuses(Configuration configuration)
            :base(configuration)
        {}

        public IClientResponse<List<OrderStatus>> Get() {
            string resourceEndpoint = "/orderstatuses";
            return base.GetData<List<OrderStatus>>(resourceEndpoint);
        }
        public IClientResponse<List<OrderStatus>> Get(IFilter filter) {
            string resourceEndpoint = "/orderstatuses";
            return base.GetData<List<OrderStatus>>(resourceEndpoint, filter);
        }
        public IClientResponse<OrderStatus> Get(int id) {
            string resourceEndpoint = string.Format("/orderstatuses/{0}", id);
            return base.GetData<OrderStatus>(resourceEndpoint);
        }
        public IClientResponse<OrderStatus> Get(int id, IFilter filter) {
            string resourceEndpoint = string.Format("/orderstatuses/{0}", id);
            return base.GetData<OrderStatus>(resourceEndpoint,filter);
        }
        public IClientResponse<List<OrderStatus>> Get(string resourceEndPoint) {
            return base.GetData<List<OrderStatus>>(resourceEndPoint);
        }
        public IClientResponse<List<OrderStatus>> Get(string resourceEndPoint, IFilter filter) {
            return base.GetData<List<OrderStatus>>(resourceEndPoint, filter);
        }

        public IClientResponse<HttpOptions> GetHttpOptions() {
            string resourceEndpoint = string.Format("/orderstatuses");
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
        public IClientResponse<HttpOptions> GetHttpOptions(int id) {
            string resourceEndpoint = string.Format("/orderstatuses/{0}", id);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }

        public IList<OrderStatus> GetList() {

            List<OrderStatus> items = new List<OrderStatus>();
            var response = Get();
            if (response.RestResponse.StatusCode == System.Net.HttpStatusCode.OK &&
                response.Data != null && response.Data != null) {
                items.AddRange(response.Data);
            } else {
                StatusCodeLogging(response.RestResponse, GetType());
            }
            return items;
        }
    }
}
