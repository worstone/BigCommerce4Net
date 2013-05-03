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
    public class ClientOrdersProducts : 
        ClientBase,
        IChildResourceGet<OrdersProduct>,
        IChildResourceCount
    {
        public ClientOrdersProducts(Configuration configuration)
            :base(configuration)
        {}

        public IClientResponse<ItemCount> Count(int orderId) {
            string resourceEndpoint = string.Format("/orders/{0}/products/count", orderId);
            return base.Count<ItemCount>(resourceEndpoint);
        }
        public IClientResponse<ItemCount> Count(int orderId, IFilter filter) {
            string resourceEndpoint = string.Format("/orders/{0}/products/count", orderId);
            return base.Count<ItemCount>(resourceEndpoint, filter);
        }
        public IClientResponse<List<OrdersProduct>> Get(int orderId) {
            string resourceEndpoint = string.Format("/orders/{0}/products", orderId);
            return base.GetData<List<OrdersProduct>>(resourceEndpoint);
        }
        public IClientResponse<OrdersProduct> Get(int orderId, int productId) {
            string resourceEndpoint = string.Format("/orders/{0}/products/{1}", orderId, productId);
            return base.GetData<OrdersProduct>(resourceEndpoint);
        }
        public IClientResponse<List<OrdersProduct>> Get(string resourceEndPoint) {
            return base.GetData<List<OrdersProduct>>(resourceEndPoint);
        }
        public IClientResponse<List<OrdersProduct>> Get(string resourceEndPoint, IFilter filter) {
            return base.GetData<List<OrdersProduct>>(resourceEndPoint, filter);
        }

        public IClientResponse<HttpOptions> GetHttpOptions(int orderId) {
            string resourceEndpoint = string.Format("/orders/{0}/products", orderId);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
        public IClientResponse<HttpOptions> GetHttpOptions(int orderId, int productId) {
            string resourceEndpoint = string.Format("/orders/{0}/products/{1}", orderId, productId);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }

        public void Get(IList<Order> orders) {
            foreach (var item in orders) {
                var response = this.Get(item.Id);

                if (response.RestResponse.StatusCode == System.Net.HttpStatusCode.OK && 
                    response.Data != null && response.Data != null) {

                    foreach (var xitem in response.Data) {
                        item.Products.Add(xitem);
                    }
                    ShowIdAndApiLimit(item.Id, response.RestResponse);
                } else {
                    StatusCodeLogging(response.RestResponse, GetType());
                }
            }
        }
        public void Get(Order order) {
            var response = this.Get(order.Id);

            if (response.RestResponse.StatusCode == System.Net.HttpStatusCode.OK && 
                response.Data != null && response.Data != null) {

                foreach (var xitem in response.Data) {
                    order.Products.Add(xitem);
                }
                ShowIdAndApiLimit(order.Id, response.RestResponse);
            } else {
                StatusCodeLogging(response.RestResponse, GetType());
            }
        }
    }
}
