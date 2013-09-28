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
    public class ClientOptionSet : 
        ClientBase,
        IParentResourcePaging<OptionSet>,
        IParentResourceGetUpdateDeleteCreate<OptionSet>,
        IParentResourceCount
    {
        public ClientOptionSet(Configuration configuration)
            : base(configuration) { }

        public IClientResponse<ItemCount> Count() {
            string resourceEndpoint = string.Format("/optionsets/count");
            return base.Count<ItemCount>(resourceEndpoint);
        }
        public IClientResponse<ItemCount> Count(IFilter filter) {
            string resourceEndpoint = string.Format("/optionsets/count");
            return base.Count<ItemCount>(resourceEndpoint, filter);
        }

        public IClientResponse<OptionSet> Get(int id) {
            string resourceEndpoint = string.Format("/optionsets/{0}", id);
            return base.GetData<OptionSet>(resourceEndpoint);
        }
        public IClientResponse<OptionSet> Get(int id, IFilter filter) {
            string resourceEndpoint = string.Format("/optionsets/{0}", id);
            return base.GetData<OptionSet>(resourceEndpoint, filter);
        }
        public IClientResponse<List<OptionSet>> Get() {
            string resourceEndpoint = string.Format("/optionsets");
            return base.GetData<List<OptionSet>>(resourceEndpoint);
        }
        public IClientResponse<List<OptionSet>> Get(IFilter filter) {
            string resourceEndpoint = string.Format("/optionsets");
            return base.GetData<List<OptionSet>>(resourceEndpoint, filter);
        }
        public IClientResponse<List<OptionSet>> Get(string resourceEndPoint) {
            return base.GetData<List<OptionSet>>(resourceEndPoint);
        }
        public IClientResponse<List<OptionSet>> Get(string resourceEndPoint, IFilter filter) {
            return base.GetData<List<OptionSet>>(resourceEndPoint, filter);
        }

        public IClientResponse<OptionSet> Update(int id, string json) {
            string resourceEndpoint = string.Format("/optionsets/{0}", id);
            return base.PutData<OptionSet>(resourceEndpoint, json);
        }
        public IClientResponse<OptionSet> Update(int id, object obj) {
            string resourceEndpoint = string.Format("/optionsets/{0}", id);
            return base.PutData<OptionSet>(resourceEndpoint, obj.SerializeObject());
        }

        public IClientResponse<OptionSet> Create(string json) {
            string resourceEndpoint = "/optionsets";
            return base.PostData<OptionSet>(resourceEndpoint, json);
        }
        public IClientResponse<OptionSet> Create(object obj) {
            string resourceEndpoint = "/optionsets";
            return base.PostData<OptionSet>(resourceEndpoint, obj.SerializeObject());
        }

        public IClientResponse<bool> Delete(int id) {
            string resourceEndpoint = string.Format("/optionsets/{0}", id);
            return base.DeleteData(resourceEndpoint);
        }

        public IClientResponse<HttpOptions> GetHttpOptions() {
            string resourceEndpoint = string.Format("/optionsets");
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
        public IClientResponse<HttpOptions> GetHttpOptions(int id) {
            string resourceEndpoint = string.Format("/optionsets/{0}", id);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }

        public IList<OptionSet> GetList() {
            var filter = new Filter();
            return GetList(filter);
        }
        public IList<OptionSet> GetList(IFilter filter) {
            var items = base.RecordPaging<OptionSet>(filter, this);
            return items;
        }
    }
}
