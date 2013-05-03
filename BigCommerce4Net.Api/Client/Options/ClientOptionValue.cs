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
    //TODO: Look at the interface on ClientOptionValue - the online docs suck!
    public class ClientOptionValue : 
        ClientBase, 
        IParentResourcePaging<OptionValue>
    {
        public ClientOptionValue(Configuration configuration)
            : base(configuration) { }

        public IClientResponse<ItemCount> Count() {
            string resourceEndpoint = string.Format("/options/values/count");
            return base.Count<ItemCount>(resourceEndpoint);
        }
        public IClientResponse<ItemCount> Count(IFilter filter) {
            string resourceEndpoint = string.Format("/options/values/count");
            return base.Count<ItemCount>(resourceEndpoint, filter);
        }
        public IClientResponse<OptionValue> Get(int id, int valueid) {
            string resourceEndpoint = string.Format("/options/{0}/values/{1}", id, valueid);
            return base.GetData<OptionValue>(resourceEndpoint);
        }
        public IClientResponse<OptionValue> Get(int id,int valueid, IFilter filter) {
            string resourceEndpoint = string.Format("/options/{0}/values/{1}", id, valueid);
            return base.GetData<OptionValue>(resourceEndpoint, filter);
        }
        public IClientResponse<List<OptionValue>> Get() {
            string resourceEndpoint = string.Format("/options/values");
            return base.GetData<List<OptionValue>>(resourceEndpoint);
        }
        public IClientResponse<List<OptionValue>> Get(IFilter filter) {
            string resourceEndpoint = string.Format("/options/values");
            return base.GetData<List<OptionValue>>(resourceEndpoint, filter);
        }
        public IClientResponse<List<OptionValue>> Get(string resourceEndPoint) {
            return base.GetData<List<OptionValue>>(resourceEndPoint);
        }
        public IClientResponse<List<OptionValue>> Get(string resourceEndPoint, IFilter filter) {
            return base.GetData<List<OptionValue>>(resourceEndPoint, filter);
        }

        public IClientResponse<HttpOptions> GetHttpOptions() {
            string resourceEndpoint = string.Format("/options/values");
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
        public IClientResponse<HttpOptions> GetHttpOptions(int id, int valueid) {
            string resourceEndpoint = string.Format("/options/{0}/values/{1}", id, valueid);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }

        public IList<OptionValue> GetList() {
            var filter = new Filter();
            return GetList(filter);
        }
        public IList<OptionValue> GetList(IFilter filter) {
            var items = base.RecordPaging<OptionValue>(filter, this);
            return items;
        }
    }
}
