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
using BigCommerce4Net.Api.ExtensionMethods;
using BigCommerce4Net.Domain;

namespace BigCommerce4Net.Api.ResourceClients
{
    public class ClientCustomerGroups :
         ClientBase,
         IParentResourcePaging<CustomerGroup>,
         IParentResourceGetUpdateDeleteCreate<CustomerGroup>,
         IParentResourceCount
    {
        public ClientCustomerGroups(Configuration configuration)
            : base(configuration)
        { }

        public IClientResponse<ItemCount> Count()
        {
            string resourceEndpoint = "/customer_groups/count";
            return base.Count<ItemCount>(resourceEndpoint);
        }
        public IClientResponse<ItemCount> Count(IFilter filter)
        {
            string resourceEndpoint = "/customer_groups/count";
            return base.Count<ItemCount>(resourceEndpoint, filter);
        }
        public IClientResponse<List<CustomerGroup>> Get(IFilter filter)
        {
            string resourceEndpoint = "/customer_groups";
            return base.GetData<List<CustomerGroup>>(resourceEndpoint, filter);
        }
        public IClientResponse<CustomerGroup> Get(int id)
        {
            string resourceEndpoint = string.Format("/customer_groups/{0}", id);
            return base.GetData<CustomerGroup>(resourceEndpoint);
        }
        public IClientResponse<CustomerGroup> Get(int id, IFilter filter)
        {
            string resourceEndpoint = string.Format("/customer_groups/{0}", id);
            return base.GetData<CustomerGroup>(resourceEndpoint, filter);
        }
        public IClientResponse<List<CustomerGroup>> Get(string resourceEndPoint)
        {
            return base.GetData<List<CustomerGroup>>(resourceEndPoint);
        }
        public IClientResponse<List<CustomerGroup>> Get(string resourceEndPoint, IFilter filter)
        {
            return base.GetData<List<CustomerGroup>>(resourceEndPoint, filter);
        }

        public IClientResponse<CustomerGroup> Update(int id, string json)
        {
            string resourceEndpoint = string.Format("/customer_groups/{0}", id);
            return base.PutData<CustomerGroup>(resourceEndpoint, json);
        }
        public IClientResponse<CustomerGroup> Update(int id, object obj)
        {
            string resourceEndpoint = string.Format("/customer_groups/{0}", id);
            return base.PutData<CustomerGroup>(resourceEndpoint, obj.SerializeObject());
        }

        public IClientResponse<CustomerGroup> Create(string json)
        {
            string resourceEndpoint = "/customer_groups";
            return base.PostData<CustomerGroup>(resourceEndpoint, json);
        }
        public IClientResponse<CustomerGroup> Create(object obj)
        {
            string resourceEndpoint = "/customer_groups";
            return base.PostData<CustomerGroup>(resourceEndpoint, obj.SerializeObject());
        }

        public IClientResponse<bool> Delete(int id)
        {
            string resourceEndpoint = string.Format("/customer_groups/{0}", id);
            return base.DeleteData(resourceEndpoint);
        }

        public IClientResponse<HttpOptions> GetHttpOptions()
        {
            string resourceEndpoint = string.Format("/customer_groups");
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
        public IClientResponse<HttpOptions> GetHttpOptions(int id)
        {
            string resourceEndpoint = string.Format("/customer_groups/{0}", id);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }

        public IList<CustomerGroup> GetList()
        {
            var filter = new FilterCustomerGroups();
            return GetList(filter);
        }

        public IList<CustomerGroup> GetList(IFilter filter)
        {
            var items = base.RecordPaging<CustomerGroup>(filter, this);
            return items;
        }
    } 
   
}
