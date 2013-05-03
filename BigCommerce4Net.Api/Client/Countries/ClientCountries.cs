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
    public class ClientCountries : 
        ClientBase,
        IParentResourcePaging<Country>,
        IParentResourceGet<Country>,
        IParentResourceCount
    {
        public ClientCountries(Configuration configuration)
            :base(configuration)
        {}
        public IClientResponse<ItemCount> Count() {
            string resourceEndpoint = "/countries/count";
            return base.Count<ItemCount>(resourceEndpoint);
        }
        public IClientResponse<ItemCount> Count(IFilter filter) {
            string resourceEndpoint = "/countries/count";
            return base.Count<ItemCount>(resourceEndpoint, filter);
        }

        public IClientResponse<List<Country>> Get() {
            var filter = new FilterCountries();
            return Get(filter);
        }
        public IClientResponse<List<Country>> Get(IFilter filter) {
            string resourceEndpoint = "/countries";
            return base.GetData<List<Country>>(resourceEndpoint, filter);
        }
        public IClientResponse<Country> Get(int id, IFilter filter) {
            string resourceEndpoint = string.Format("/countries/{0}", id);
            return base.GetData<Country>(resourceEndpoint, filter);
        }
        public IClientResponse<Country> Get(int id) {
            string resourceEndpoint = string.Format("/countries/{0}", id);
            return base.GetData<Country>(resourceEndpoint);
        }
        public IClientResponse<List<Country>> Get(string resourceEndPoint) {
            return base.GetData<List<Country>>(resourceEndPoint);
        }
        public IClientResponse<List<Country>> Get(string resourceEndPoint, IFilter filter) {
            return base.GetData<List<Country>>(resourceEndPoint, filter);
        }

        public IClientResponse<HttpOptions> GetHttpOptions(int id) {
            string resourceEndpoint = string.Format("/countries/{0}", id);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
        public IClientResponse<HttpOptions> GetHttpOptions() {
            string resourceEndpoint = string.Format("/countries");
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }


        public IList<Country> GetList() {
            var filter = new FilterCountries();
            return GetList(filter);
        }
        public IList<Country> GetList(IFilter filter) {
            var items = base.RecordPaging<Country>(filter, this);
            return items;
        }
    }
}
