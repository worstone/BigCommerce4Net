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
using System.Reflection;
//using bigcommerce4net.Utilities;

namespace BigCommerce4Net.Api.ResourceClients
{
    public class ClientOrdersShippingAddresses : 
        ClientBase,
        IChildResourceGet<OrdersShippingAddress>,
        IChildResourceCount
    {
        public ClientOrdersShippingAddresses(Configuration configuration)
            :base(configuration)
        {}

        public IClientResponse<ItemCount> Count(int orderId) {
            string resourceEndpoint = string.Format("/orders/{0}/shippingaddresses/count", orderId);
            return base.Count<ItemCount>(resourceEndpoint);
        }
        public IClientResponse<ItemCount> Count(int orderId, IFilter filter) {
            string resourceEndpoint = string.Format("/orders/{0}/shippingaddresses/count", orderId);
            return base.Count<ItemCount>(resourceEndpoint, filter);
        }
        public IClientResponse<List<OrdersShippingAddress>> Get(int orderId) {
            string resourceEndpoint = string.Format("/orders/{0}/shippingaddresses", orderId);
            return base.GetData<List<OrdersShippingAddress>>(resourceEndpoint);
        }
        public IClientResponse<OrdersShippingAddress> Get(int orderId, int shippingaddressId) {
            string resourceEndpoint = string.Format("/orders/{0}/shippingaddresses/{1}", orderId, shippingaddressId);
            return base.GetData<OrdersShippingAddress>(resourceEndpoint);
        }
        public IClientResponse<List<OrdersShippingAddress>> Get(string resourceEndPoint) {
            return base.GetData<List<OrdersShippingAddress>>(resourceEndPoint);
        }
        public IClientResponse<List<OrdersShippingAddress>> Get(string resourceEndPoint, IFilter filter) {
            return base.GetData<List<OrdersShippingAddress>>(resourceEndPoint, filter);
        }

        public IClientResponse<HttpOptions> GetHttpOptions(int orderId) {
            string resourceEndpoint = string.Format("/orders/{0}/shippingaddresses", orderId);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
        public IClientResponse<HttpOptions> GetHttpOptions(int orderId, int shippingaddressId) {
            string resourceEndpoint = string.Format("/orders/{0}/shippingaddresses/{1}", orderId, shippingaddressId);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }

        public void Get(IList<Order> orders) {
            
            foreach (var item in orders) {
                var response = this.Get(item.ResourceShippingAddresses.ResourceEndPoint);

                if (response.RestResponse.StatusCode == System.Net.HttpStatusCode.OK &&
                    response.Data != null && response.Data != null) {

                    foreach (var xitem in response.Data) {
                        item.ShippingAddresses.Add(xitem);
                    }
                    ShowIdAndApiLimit(item.Id, response.RestResponse);
                } else {

                    StatusCodeLogging(response.RestResponse, GetType());
                }
            }
        }

        public void Get(Order order) {
            var response = this.Get(order.ResourceShippingAddresses.ResourceEndPoint);

            if (response.RestResponse.StatusCode == System.Net.HttpStatusCode.OK && 
                response.Data != null && response.Data != null) {

                foreach (var xitem in response.Data) {
                    order.ShippingAddresses.Add(xitem);
                }
                ShowIdAndApiLimit(order.Id, response.RestResponse);
            } else {
                StatusCodeLogging(response.RestResponse, GetType());
            }
        }
    }
}
