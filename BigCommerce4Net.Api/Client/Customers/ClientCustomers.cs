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
    public class ClientCustomers : 
        ClientBase, 
        IParentResourcePaging<Customer>, 
        IParentResourceGetUpdateDeleteCreate<Customer>, 
        IParentResourceCount
    {
        public ClientCustomers(Configuration configuration)
            :base(configuration)
        {}
        
        public IClientResponse<ItemCount> Count() {
            string resourceEndpoint = "/customers/count";
            return base.Count<ItemCount>(resourceEndpoint);
        }
        public IClientResponse<ItemCount> Count(IFilter filter) {
            string resourceEndpoint = "/customers/count";
            return base.Count<ItemCount>(resourceEndpoint, filter);
        }
        public IClientResponse<List<Customer>> Get(IFilter filter) {
            string resourceEndpoint = "/customers";
            return base.GetData<List<Customer>>(resourceEndpoint, filter);
        }
        public IClientResponse<Customer> Get(int id) {
            string resourceEndpoint = string.Format("/customers/{0}", id);
            return base.GetData<Customer>(resourceEndpoint, null);
        }
        public IClientResponse<Customer> Get(int id, IFilter filter) {
            string resourceEndpoint = string.Format("/customers/{0}", id);
            return base.GetData<Customer>(resourceEndpoint, filter);
        }
        public IClientResponse<List<Customer>> Get(string resourceEndPoint) {
            return base.GetData<List<Customer>>(resourceEndPoint);
        }
        public IClientResponse<List<Customer>> Get(string resourceEndPoint, IFilter filter) {
            return base.GetData<List<Customer>>(resourceEndPoint, filter);
        }

        public IClientResponse<Customer> Update(int Id, string json) {
            string resourceEndpoint = string.Format("/customers/{0}", Id);
            return base.PutData<Customer>(resourceEndpoint, json);
        }
        public IClientResponse<Customer> Update(int Id, object obj) {
            string resourceEndpoint = string.Format("/customers/{0}", Id);
            return base.PutData<Customer>(resourceEndpoint, obj.SerializeObject());
        }

        public IClientResponse<Customer> Create(string json) {
            string resourceEndpoint = string.Format("/customers");
            return base.PostData<Customer>(resourceEndpoint, json);
        }
        public IClientResponse<Customer> Create(object obj) {
            string resourceEndpoint = string.Format("/customers");
            return base.PostData<Customer>(resourceEndpoint, obj.SerializeObject());
        }

        public IClientResponse<bool> Delete(int Id) {
            string resourceEndpoint = string.Format("/customers/{0}", Id);
            return base.DeleteData(resourceEndpoint);
        }

        public IClientResponse<HttpOptions> GetHttpOptions(int id) {
            string resourceEndpoint = string.Format("/customers/{0}", id);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
        public IClientResponse<HttpOptions> GetHttpOptions() {
            string resourceEndpoint = string.Format("/customers");
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }

        public List<Customer> GetList() {
            FilterCustomers filter = new FilterCustomers();
            return GetList(filter);
        }
        public List<Customer> GetList(IFilter filter) {
            var items = base.RecordPaging<Customer>(filter, this);
            return items;
        }
    }
}
