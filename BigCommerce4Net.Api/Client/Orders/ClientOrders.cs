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
using BigCommerce4Net.Api.ExtensionMethods;

namespace BigCommerce4Net.Api.ResourceClients
{
    public class ClientOrders : 
        ClientBase, 
        IParentResourcePaging<Order>,
        IParentResourceGetUpdateDelete<Order>,
        IParentResourceCount
    {

        public ClientOrders(Configuration configuration)
            :base(configuration)
        {}

        public IClientResponse<ItemCount> Count() {
            string resourceEndpoint = "/orders/count";
            return base.Count<ItemCount>(resourceEndpoint);
        }
        public IClientResponse<ItemCount> Count(IFilter filter) {
            string resourceEndpoint = "/orders/count";
            return base.Count<ItemCount>(resourceEndpoint, filter);
        }
        public IClientResponse<List<Order>> Get(IFilter filter) {
            string resourceEndpoint = "/orders";
            return base.GetData<List<Order>>(resourceEndpoint, filter);
        }
        public IClientResponse<Order> Get(int id) {
            string resourceEndpoint = string.Format("/orders/{0}", id);
            return base.GetData<Order>(resourceEndpoint);
        }
        public IClientResponse<Order> Get(int id, IFilter filter) {
            string resourceEndpoint = string.Format("/orders/{0}", id);
            return base.GetData<Order>(resourceEndpoint, filter);
        }
        public IClientResponse<List<Order>> Get(string resourceEndPoint) {
            return base.GetData<List<Order>>(resourceEndPoint);
        }
        public IClientResponse<List<Order>> Get(string resourceEndPoint, IFilter filter) {
            return base.GetData<List<Order>>(resourceEndPoint, filter);
        }

        public IClientResponse<Order> Update(int id, string json) {
            string resourceEndpoint = string.Format("/orders/{0}", id);
            return base.PutData<Order>(resourceEndpoint, json);
        }
        public IClientResponse<Order> Update(int id, object obj) {
            string resourceEndpoint = string.Format("/orders/{0}", id);
            return base.PutData<Order>(resourceEndpoint, obj.SerializeObject());
        }

        public IClientResponse<bool> Delete(int id) {
            string resourceEndpoint = string.Format("/orders/{0}", id);
            return base.DeleteData(resourceEndpoint);
        }

        public IClientResponse<HttpOptions> GetHttpOptions() {
            string resourceEndpoint = string.Format("/orders");
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
        public IClientResponse<HttpOptions> GetHttpOptions(int id) {
            string resourceEndpoint = string.Format("/orders/{0}", id);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }

        public IList<Order> GetList(int recordsPerPage = 250) {
            FilterOrders filter = new FilterOrders();
            return GetList(filter, recordsPerPage);
        }
        public IList<Order> GetList(IFilter filter, int recordsPerPage = 250) {
            var orders = base.RecordPaging<Order>(filter, this);
            return orders;
        }
    }
}
