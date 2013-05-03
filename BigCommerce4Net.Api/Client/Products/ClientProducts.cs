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
    public class ClientProducts : 
        ClientBase, 
        IParentResourcePaging<Product>, 
        IParentResourceGetUpdateDeleteCreate<Product>,
        IParentResourceCount
    {
        public ClientProducts(Configuration configuration)
            :base(configuration)
        {}

        public IClientResponse<ItemCount> Count() {
            string resourceEndpoint = "/products/count";
            return base.Count<ItemCount>(resourceEndpoint);
        }
        public IClientResponse<ItemCount> Count(IFilter filter) {
            string resourceEndpoint = "/products/count";
            return base.Count<ItemCount>(resourceEndpoint, filter);
        }
        public IClientResponse<List<Product>> Get(IFilter filter) {
            string resourceEndpoint = "/products";
            return base.GetData<List<Product>>(resourceEndpoint, filter);
        }
        public IClientResponse<Product> Get(int id) {
            string resourceEndpoint = string.Format("/products/{0}", id);
            return base.GetData<Product>(resourceEndpoint);
        }
        public IClientResponse<Product> Get(int id, IFilter filter) {
            string resourceEndpoint = string.Format("/products/{0}", id);
            return base.GetData<Product>(resourceEndpoint, filter);
        }
        public IClientResponse<List<Product>> Get(string resourceEndPoint) {
            return base.GetData<List<Product>>(resourceEndPoint);
        }
        public IClientResponse<List<Product>> Get(string resourceEndPoint, IFilter filter) {
            return base.GetData<List<Product>>(resourceEndPoint, filter);
        }
        
        public IClientResponse<Product> Update(int id, string json) {
            string resourceEndpoint = string.Format("/products/{0}", id);
            return base.PutData<Product>(resourceEndpoint, json);
        }
        public IClientResponse<Product> Update(int id, object obj) {
            string resourceEndpoint = string.Format("/products/{0}", id);
            return base.PutData<Product>(resourceEndpoint, obj.SerializeObject());
        }

        public IClientResponse<Product> Create(string json) {
            string resourceEndpoint = "/products";
            return base.PostData<Product>(resourceEndpoint, json);
        }
        public IClientResponse<Product> Create(object obj) {
            string resourceEndpoint = "/products";
            return base.PostData<Product>(resourceEndpoint, obj.SerializeObject());
        }

        public IClientResponse<bool> Delete(int id) {
            string resourceEndpoint = string.Format("/products/{0}", id);
            return base.DeleteData(resourceEndpoint);
        }

        public IClientResponse<HttpOptions> GetHttpOptions() {
            string resourceEndpoint = string.Format("/products");
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
        public IClientResponse<HttpOptions> GetHttpOptions(int id) {
            string resourceEndpoint = string.Format("/products/{0}", id);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }



        public IList<Product> GetList() {
            FilterProducts filter = new FilterProducts();
            return GetList(filter);
        }
        public IList<Product> GetList(IFilter filter) {
            var items = base.RecordPaging<Product>(filter, this);
            return items;
        }
    }
}
