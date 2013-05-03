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
using BigCommerce4Net.Domain;


namespace BigCommerce4Net.Api.ResourceClients
{
    public class ClientCustomersAddresses : 
        ClientBase, 
        IChildResourceGet<CustomersAddress>,
        IChildResourceCount
    {
        public ClientCustomersAddresses(Configuration configuration)
            :base(configuration)
        {}
        public IClientResponse<ItemCount> Count(int customerId) {
            string resourceEndpoint = string.Format("/customers/{0}/addresses/count", customerId);
            return base.Count<ItemCount>(resourceEndpoint);
        }
        public IClientResponse<ItemCount> Count(int customerId,IFilter filter) {
            string resourceEndpoint = string.Format("/customers/{0}/addresses/count", customerId);
            return base.Count<ItemCount>(resourceEndpoint, filter);
        }
        public IClientResponse<List<CustomersAddress>> Get(int customerId) {
            string resourceEndpoint = string.Format("/customers/{0}/addresses", customerId);
            return base.GetData<List<CustomersAddress>>(resourceEndpoint);
        }
        public IClientResponse<CustomersAddress> Get(int customerId, int recordId) {
            string resourceEndpoint = string.Format("/customers/{0}/addresses/{1}", customerId, recordId);
            return base.GetData<CustomersAddress>(resourceEndpoint);
        }
        public IClientResponse<List<CustomersAddress>> Get(string resourceEndPoint) {
            return base.GetData<List<CustomersAddress>>(resourceEndPoint);
        }
        public IClientResponse<List<CustomersAddress>> Get(string resourceEndPoint, IFilter filter) {
            return base.GetData<List<CustomersAddress>>(resourceEndPoint, filter);
        }

        public IClientResponse<HttpOptions> GetHttpOptions(int customerId) {
            string resourceEndpoint = string.Format("/customers/{0}/addresses", customerId);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
        public IClientResponse<HttpOptions> GetHttpOptions(int customerId, int recordId) {
            string resourceEndpoint = string.Format("/customers/{0}/addresses/{1}", customerId, recordId);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }



        public void Get(IList<Customer> customers) {
            foreach (var item in customers) {
                var response = this.Get(item.Id);

                if (response.RestResponse.StatusCode == System.Net.HttpStatusCode.OK &&
                    response.Data != null && response.Data != null) {

                    foreach (var xitem in response.Data) {
                        item.Addresses.Add(xitem);
                    }
                    ShowIdAndApiLimit(item.Id, response.RestResponse);
                } else {
                    StatusCodeLogging(response.RestResponse, GetType());
                }
            }
        }
        public void Get(Customer customer) {
            var response = this.Get(customer.Id);

            if (response.RestResponse.StatusCode == System.Net.HttpStatusCode.OK &&
                response.Data != null && response.Data != null) {

                foreach (var xitem in response.Data) {
                    customer.Addresses.Add(xitem);
                }
                ShowIdAndApiLimit(customer.Id, response.RestResponse);
            } else {
                StatusCodeLogging(response.RestResponse, GetType());
            }
        }
        
    }
}
