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
using BigCommerce4Net.Api.ExtensionMethods;

namespace BigCommerce4Net.Api.ResourceClients
{
    public class ClientOrdersShipments : 
        ClientBase, 
        IChildResourceGetUpdateDeleteCreate<OrdersShipment>,
        IChildResourceCount
    {
        public ClientOrdersShipments(Configuration configuration)
            :base(configuration)
        {}

        public IClientResponse<ItemCount> Count(int orderId) {
            string resourceEndpoint = string.Format("/orders/{0}/shipments/count", orderId);
            return base.Count<ItemCount>(resourceEndpoint);
        }
        public IClientResponse<ItemCount> Count(int orderId, IFilter filter) {
            string resourceEndpoint = string.Format("/orders/{0}/shipments/count", orderId);
            return base.Count<ItemCount>(resourceEndpoint, filter);
        }
        public IClientResponse<List<OrdersShipment>> Get(int orderId) {
            string resourceEndpoint = string.Format("/orders/{0}/shipments", orderId);
            return base.GetData<List<OrdersShipment>>(resourceEndpoint);
        }
        public IClientResponse<OrdersShipment> Get(int orderId, int shipmentId) {
            string resourceEndpoint = string.Format("/orders/{0}/shipments/{1}", orderId, shipmentId);
            return base.GetData<OrdersShipment>(resourceEndpoint);
        }
        public IClientResponse<List<OrdersShipment>> Get(string resourceEndPoint) {
            return base.GetData<List<OrdersShipment>>(resourceEndPoint);
        }
        public IClientResponse<List<OrdersShipment>> Get(string resourceEndPoint, IFilter filter) {
            return base.GetData<List<OrdersShipment>>(resourceEndPoint, filter);
        }

        public IClientResponse<OrdersShipment> Update(int orderId, int shipmentId, string json) {
            string resourceEndpoint = string.Format("/orders/{0}/shipments/{1}", orderId, shipmentId);
            return base.PutData<OrdersShipment>(resourceEndpoint, json);
        }
        public IClientResponse<OrdersShipment> Update(int orderId, int shipmentId, object obj) {
            string resourceEndpoint = string.Format("/orders/{0}/shipments/{1}", orderId, shipmentId);
            return base.PutData<OrdersShipment>(resourceEndpoint, obj.SerializeObject());
        }

        public IClientResponse<OrdersShipment> Create(int orderId, string json) {
            string resourceEndpoint = string.Format("/orders/{0}/shipments", orderId);
            return base.PostData<OrdersShipment>(resourceEndpoint, json);
        }
        public IClientResponse<OrdersShipment> Create(int orderId, object obj) {
            string resourceEndpoint = string.Format("/orders/{0}/shipments", orderId);
            return base.PostData<OrdersShipment>(resourceEndpoint, obj.SerializeObject());
        }


        public IClientResponse<bool> Delete(int orderId, int shipmentId) {
            string resourceEndpoint = string.Format("/orders/{0}/shipments/{1}", orderId, shipmentId);
            return base.DeleteData(resourceEndpoint);
        }

        public IClientResponse<HttpOptions> GetHttpOptions(int orderId) {
            string resourceEndpoint = string.Format("/orders/{0}/shipments", orderId);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
        public IClientResponse<HttpOptions> GetHttpOptions(int orderId, int shipmentId) {
            string resourceEndpoint = string.Format("/orders/{0}/shipments/{1}", orderId, shipmentId);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }

        public void Get(IList<Order> orders) {
            List<OrdersShipment> items = new List<OrdersShipment>();

            foreach (var item in orders) {
                var response = this.Get(item.Id);

                if (response.RestResponse.StatusCode == System.Net.HttpStatusCode.OK &&
                    response.Data != null && response.Data != null) {

                    foreach (var xitem in response.Data) {
                        item.Shipments.Add(xitem);
                    }
                    ShowIdAndApiLimit(item.Id, response.RestResponse);

                }
                else {
                    StatusCodeLogging(response.RestResponse, GetType());
                }
            }
        }
        public void Get(Order order) {
            var response = this.Get(order.Id);

            if (response.RestResponse.StatusCode == System.Net.HttpStatusCode.OK && 
                response.Data != null && response.Data != null) {

                foreach (var xitem in response.Data) {
                    order.Shipments.Add(xitem);
                }
                ShowIdAndApiLimit(order.Id, response.RestResponse);
            }
            else {
                StatusCodeLogging(response.RestResponse, GetType());
            }
        }
    }
}
