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
    public class ClientStates : 
        ClientBase, 
        IParentResourcePaging<State>, 
        IParentResourceGet<State>, 
        IParentResourceCount
    {
        public ClientStates(Configuration configuration)
            :base(configuration)
        {}

        public IClientResponse<ItemCount> Count() {
            string resourceEndpoint = "/countries/states/count";
            return base.Count<ItemCount>(resourceEndpoint);
        }
        public IClientResponse<ItemCount> Count(IFilter filter) {
            string resourceEndpoint = "/countries/states/count";
            return base.Count<ItemCount>(resourceEndpoint, filter);
        }

        public IClientResponse<List<State>> Get() {
            var filter = new FilterStates();
            return Get(filter);
        }
        public IClientResponse<List<State>> Get(IFilter filter) {
            string resourceEndpoint = "/countries/states";
            return base.GetData<List<State>>(resourceEndpoint, filter);
        }
        public IClientResponse<State> Get(int id, IFilter filter) {
            string resourceEndpoint = string.Format("/countries/states/{0}", id);
            return base.GetData<State>(resourceEndpoint, filter);
        }
        public IClientResponse<State> Get(int id) {
            string resourceEndpoint = string.Format("/countries/states/{0}", id);
            return base.GetData<State>(resourceEndpoint);
        }
        public IClientResponse<List<State>> Get(string resourceEndPoint) {
            return base.GetData<List<State>>(resourceEndPoint);
        }
        public IClientResponse<List<State>> Get(string resourceEndPoint, IFilter filter) {
            return base.GetData<List<State>>(resourceEndPoint, filter);
        }

        public IClientResponse<List<State>> GetStatesInCountry(int id) {
            string resourceEndpoint = string.Format("/countries/{0}/states", id);
            return base.GetData<List<State>>(resourceEndpoint);
        }

        public IClientResponse<HttpOptions> GetHttpOptions(int id) {
            string resourceEndpoint = string.Format("/countries/states/{0}", id);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
        public IClientResponse<HttpOptions> GetHttpOptions() {
            string resourceEndpoint = string.Format("/countries/states");
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }


        public IList<State> GetList() {
            var filter = new FilterStates();
            return GetList(filter);
        }
        public IList<State> GetList(IFilter filter) {
            var items = base.RecordPaging<State>(filter, this);
            return items;
        }
    }
}
