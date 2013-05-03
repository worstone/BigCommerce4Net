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
    public class ClientCategories : 
        ClientBase, 
        IParentResourcePaging<Category>, 
        IParentResourceGetUpdateDeleteCreate<Category>,
        IParentResourceCount
    {
        public ClientCategories(Configuration configuration)
            :base(configuration)
        {}

        public IClientResponse<ItemCount> Count() {
            string resourceEndpoint = "/categories/count";
            return base.Count<ItemCount>(resourceEndpoint);
        }
        public IClientResponse<ItemCount> Count(IFilter filter) {
            string resourceEndpoint = "/categories/count";
            return base.Count<ItemCount>(resourceEndpoint, filter);
        }
        public IClientResponse<List<Category>> Get(IFilter filter) {
            string resourceEndpoint = "/categories";
            return base.GetData<List<Category>>(resourceEndpoint, filter);
        }
        public IClientResponse<Category> Get(int id) {
            string resourceEndpoint = string.Format("/categories/{0}", id);
            return base.GetData<Category>(resourceEndpoint);
        }
        public IClientResponse<Category> Get(int id, IFilter filter) {
            string resourceEndpoint = string.Format("/categories/{0}", id);
            return base.GetData<Category>(resourceEndpoint, filter);
        }
        public IClientResponse<List<Category>> Get(string resourceEndPoint) {
            return base.GetData<List<Category>>(resourceEndPoint);
        }
        public IClientResponse<List<Category>> Get(string resourceEndPoint, IFilter filter) {
            return base.GetData<List<Category>>(resourceEndPoint, filter);
        }

        public IClientResponse<Category> Update(int id, string json) {
            string resourceEndpoint = string.Format("/categories/{0}", id);
            return base.PutData<Category>(resourceEndpoint, json);
        }
        public IClientResponse<Category> Update(int id, object obj) {
            string resourceEndpoint = string.Format("/categories/{0}", id);
            return base.PutData<Category>(resourceEndpoint, obj.SerializeObject());
        }

        public IClientResponse<Category> Create(string json) {
            string resourceEndpoint = "/categories";
            return base.PostData<Category>(resourceEndpoint, json);
        }
        public IClientResponse<Category> Create(object obj) {
            string resourceEndpoint = "/categories";
            return base.PostData<Category>(resourceEndpoint, obj.SerializeObject());
        }

        public IClientResponse<bool> Delete(int id) {
            string resourceEndpoint = string.Format("/categories/{0}", id);
            return base.DeleteData(resourceEndpoint);
        }

        public IClientResponse<HttpOptions> GetHttpOptions() {
            string resourceEndpoint = string.Format("/categories");
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
        public IClientResponse<HttpOptions> GetHttpOptions(int id) {
            string resourceEndpoint = string.Format("/categories/{0}", id);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }


        public IList<Category> GetList() {
            var filter = new FilterCategories();
            return GetList(filter);
        }
        public IList<Category> GetList(IFilter filter) {
            var items = base.RecordPaging<Category>(filter, this);
            return items;
        }
    }
}
