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
    public class ClientOptionSetOption : 
        ClientBase,
        IParentResourcePaging<OptionSetOption>, 
        IParentResourceGetUpdateDeleteCreate<OptionSetOption>,
        IParentResourceCount
    {
        public ClientOptionSetOption(Configuration configuration)
            : base(configuration) { }

        public IClientResponse<ItemCount> Count() {
            string resourceEndpoint = string.Format("/optionsets/options/count");
            return base.Count<ItemCount>(resourceEndpoint);
        }
        public IClientResponse<ItemCount> Count(IFilter filter) {
            string resourceEndpoint = string.Format("/optionsets/options/count");
            return base.Count<ItemCount>(resourceEndpoint, filter);
        }

        public IClientResponse<OptionSetOption> Get(int id) {
            string resourceEndpoint = string.Format("/optionsets/options/{0}", id);
            return base.GetData<OptionSetOption>(resourceEndpoint);
        }
        public IClientResponse<OptionSetOption> Get(int id, IFilter filter) {
            string resourceEndpoint = string.Format("/optionsets/options/{0}", id);
            return base.GetData<OptionSetOption>(resourceEndpoint, filter);
        }
        public IClientResponse<List<OptionSetOption>> Get() {
            string resourceEndpoint = string.Format("/optionsets/options");
            return base.GetData<List<OptionSetOption>>(resourceEndpoint);
        }
        public IClientResponse<List<OptionSetOption>> Get(IFilter filter) {
            string resourceEndpoint = string.Format("/optionsets/options");
            return base.GetData<List<OptionSetOption>>(resourceEndpoint, filter);
        }
        public IClientResponse<List<OptionSetOption>> Get(string resourceEndPoint) {
            return base.GetData<List<OptionSetOption>>(resourceEndPoint);
        }
        public IClientResponse<List<OptionSetOption>> Get(string resourceEndPoint, IFilter filter) {
            return base.GetData<List<OptionSetOption>>(resourceEndPoint, filter);
        }

        public IClientResponse<OptionSetOption> Update(int id, string json) {
            string resourceEndpoint = string.Format("/optionsets/options/{0}", id);
            return base.PutData<OptionSetOption>(resourceEndpoint, json);
        }
        public IClientResponse<OptionSetOption> Update(int id, object obj) {
            string resourceEndpoint = string.Format("/optionsets/options/{0}", id);
            return base.PutData<OptionSetOption>(resourceEndpoint, obj.SerializeObject());
        }

        public IClientResponse<OptionSetOption> Create(string json) {
            string resourceEndpoint = "/optionsets/options";
            return base.PostData<OptionSetOption>(resourceEndpoint, json);
        }
        public IClientResponse<OptionSetOption> Create(object obj) {
            string resourceEndpoint = "/optionsets/options";
            return base.PostData<OptionSetOption>(resourceEndpoint, obj.SerializeObject());
        }

        public IClientResponse<bool> Delete(int id) {
            string resourceEndpoint = string.Format("/optionsets/options/{0}", id);
            return base.DeleteData(resourceEndpoint);
        }

        public IClientResponse<HttpOptions> GetHttpOptions() {
            string resourceEndpoint = string.Format("/optionsets/options");
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
        public IClientResponse<HttpOptions> GetHttpOptions(int id) {
            string resourceEndpoint = string.Format("/optionsets/options/{0}", id);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }


        public IList<OptionSetOption> GetList() {
            var filter = new Filter();
            return GetList(filter);
        }
        public IList<OptionSetOption> GetList(IFilter filter) {
            var items = base.RecordPaging<OptionSetOption>(filter, this);
            return items;
        }
    }
}
