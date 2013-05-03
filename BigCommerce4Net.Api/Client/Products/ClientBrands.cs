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
    public class ClientBrands : 
        ClientBase, 
        IParentResourcePaging<Brand>, 
        IParentResourceGetUpdateDeleteCreate<Brand>,
        IParentResourceCount
    {
        public ClientBrands(Configuration configuration)
            :base(configuration)
        {}

        public IClientResponse<ItemCount> Count() {
            string resourceEndpoint = "/brands/count";
            return base.Count<ItemCount>(resourceEndpoint);
        }
        public IClientResponse<ItemCount> Count(IFilter filter) {
            string resourceEndpoint = "/brands/count";
            return base.Count<ItemCount>(resourceEndpoint,filter);
        }
        public IClientResponse<List<Brand>> Get(IFilter filter) {
            string resourceEndpoint = "/brands";
            return base.GetData<List<Brand>>(resourceEndpoint, filter);
        }
        public IClientResponse<Brand> Get(int id, IFilter filter) {
            string resourceEndpoint = string.Format("/brands/{0}", id);
            return base.GetData<Brand>(resourceEndpoint, filter);
        }
        public IClientResponse<Brand> Get(int id) {
            string resourceEndpoint = string.Format("/brands/{0}", id);
            return base.GetData<Brand>(resourceEndpoint);
        }
        public IClientResponse<List<Brand>> Get(string resourceEndPoint) {
            return base.GetData<List<Brand>>(resourceEndPoint);
        }
        public IClientResponse<List<Brand>> Get(string resourceEndPoint, IFilter filter) {
            return base.GetData<List<Brand>>(resourceEndPoint, filter);
        }

        public IClientResponse<Brand> Update(int id, string json) {
            string resourceEndpoint = string.Format("/brands/{0}", id);
            return base.PutData<Brand>(resourceEndpoint, json);
        }
        public IClientResponse<Brand> Update(int id, object obj) {
            string resourceEndpoint = string.Format("/brands/{0}", id);
            return base.PutData<Brand>(resourceEndpoint, obj.SerializeObject());
        }

        public IClientResponse<Brand> Create(string json) {
            string resourceEndpoint = "/brands";
            return base.PostData<Brand>(resourceEndpoint, json);
        }
        public IClientResponse<Brand> Create(object obj) {
            string resourceEndpoint = "/brands";
            return base.PostData<Brand>(resourceEndpoint, obj.SerializeObject());
        }

        public IClientResponse<bool> Delete(int id) {
            string resourceEndpoint = string.Format("/brands/{0}", id);
            return base.DeleteData(resourceEndpoint);
        }

        public IClientResponse<HttpOptions> GetHttpOptions() {
            string resourceEndpoint = string.Format("/brands");
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
        public IClientResponse<HttpOptions> GetHttpOptions(int id) {
            string resourceEndpoint = string.Format("/brands/{0}", id);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }

        public IList<Brand> GetList() {
            FilterOrders filter = new FilterOrders();
            return GetList(filter);
        }
        public IList<Brand> GetList(IFilter filter) {
            var items = base.RecordPaging<Brand>(filter, this);
            return items;
        }
    }
}