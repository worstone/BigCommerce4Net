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
    public class ClientOptions : 
        ClientBase,
        IParentResourcePaging<Option>,
        IParentResourceGetUpdateDeleteCreate<Option>,
        IParentResourceCount
    {
        public ClientOptions(Configuration configuration)
            : base(configuration) { }

        public IClientResponse<ItemCount> Count() {
            string resourceEndpoint = string.Format("/options/count");
            return base.Count<ItemCount>(resourceEndpoint);
        }
        public IClientResponse<ItemCount> Count(IFilter filter) {
            string resourceEndpoint = string.Format("/options/count");
            return base.Count<ItemCount>(resourceEndpoint, filter);
        }

        public IClientResponse<Option> Get(int id) {
            string resourceEndpoint = string.Format("/options/{0}", id); 
            return base.GetData<Option>(resourceEndpoint);
        }
        public IClientResponse<Option> Get(int id, IFilter filter) {
            string resourceEndpoint = string.Format("/options/{0}", id); 
            return base.GetData<Option>(resourceEndpoint, filter);
        }
        public IClientResponse<List<Option>> Get() {
            string resourceEndpoint = string.Format("/options");
            return base.GetData<List<Option>>(resourceEndpoint);
        }
        public IClientResponse<List<Option>> Get(IFilter filter) {
            string resourceEndpoint = string.Format("/options");
            return base.GetData<List<Option>>(resourceEndpoint, filter);
        }
        public IClientResponse<List<Option>> Get(string resourceEndPoint) {
            return base.GetData<List<Option>>(resourceEndPoint);
        }
        public IClientResponse<List<Option>> Get(string resourceEndPoint, IFilter filter) {
            return base.GetData<List<Option>>(resourceEndPoint, filter);
        }

        public IClientResponse<Option> Update(int id, string json) {
            string resourceEndpoint = string.Format("/options/{0}", id);
            return base.PutData<Option>(resourceEndpoint, json);
        }
        public IClientResponse<Option> Update(int id, object obj) {
            string resourceEndpoint = string.Format("/options/{0}", id);
            return base.PutData<Option>(resourceEndpoint, obj.SerializeObject());
        }

        public IClientResponse<Option> Create(string json) {
            string resourceEndpoint = "/options";
            return base.PostData<Option>(resourceEndpoint, json);
        }
        public IClientResponse<Option> Create(object obj) {
            string resourceEndpoint = "/options";
            return base.PostData<Option>(resourceEndpoint, obj.SerializeObject());
        }
        
        public IClientResponse<bool> Delete(int id) {
            string resourceEndpoint = string.Format("/options/{0}", id);
            return base.DeleteData(resourceEndpoint);
        }

        public IClientResponse<HttpOptions> GetHttpOptions() {
            string resourceEndpoint = string.Format("/options");
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
        public IClientResponse<HttpOptions> GetHttpOptions(int id ) {
            string resourceEndpoint = string.Format("/options/{0}", id); 
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }

        public IList<Option> GetList() {
            var filter = new FilterOptions();
            return GetList(filter);
        }
        public IList<Option> GetList(IFilter filter) {
            var items = base.RecordPaging<Option>(filter, this);
            return items;
        }
    }
}