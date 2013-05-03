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
    public class ClientOrdersCoupons : 
        ClientBase, 
        IChildResourceGet<OrdersCoupon>,
        IChildResourceCount
    {
        public ClientOrdersCoupons(Configuration configuration)
            :base(configuration)
        {}

        public IClientResponse<ItemCount> Count(int orderId) {
            string resourceEndpoint = string.Format("/orders/{0}/coupons/count", orderId);
            return base.Count<ItemCount>(resourceEndpoint);
        }
        public IClientResponse<ItemCount> Count(int orderId, IFilter filter) {
            string resourceEndpoint = string.Format("/orders/{0}/coupons/count", orderId);
            return base.Count<ItemCount>(resourceEndpoint, filter);
        }
        public IClientResponse<List<OrdersCoupon>> Get(int orderId) {
            string resourceEndpoint = string.Format("/orders/{0}/coupons", orderId);
            return base.GetData<List<OrdersCoupon>>(resourceEndpoint);
        }
        public IClientResponse<OrdersCoupon> Get(int orderId, int couponId) {
            string resourceEndpoint = string.Format("/orders/{0}/coupons/{1}", orderId, couponId);
            return base.GetData<OrdersCoupon>(resourceEndpoint);
        }
        public IClientResponse<List<OrdersCoupon>> Get(string resourceEndPoint) {
            return base.GetData<List<OrdersCoupon>>(resourceEndPoint);
        }
        public IClientResponse<List<OrdersCoupon>> Get(string resourceEndPoint, IFilter filter) {
            return base.GetData<List<OrdersCoupon>>(resourceEndPoint, filter);
        }

        public IClientResponse<HttpOptions> GetHttpOptions(int orderId) {
            string resourceEndpoint = string.Format("/orders/{0}/coupons", orderId);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
        public IClientResponse<HttpOptions> GetHttpOptions(int orderId, int couponId) {
            string resourceEndpoint = string.Format("/orders/{0}/coupons/{1}", orderId, couponId);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }


        public void Get(IList<Order> orders) {
            foreach (var item in orders) {
                var response = this.Get(item.Id);

                if (response.RestResponse.StatusCode == System.Net.HttpStatusCode.OK && 
                    response.Data != null && response.Data != null) {
                    foreach (var xitem in response.Data) {
                        item.Coupons.Add(xitem);
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
                    order.Coupons.Add(xitem);
                }
                ShowIdAndApiLimit(order.Id, response.RestResponse);
            } else {
                StatusCodeLogging(response.RestResponse, GetType());
            }
        }

    }
}