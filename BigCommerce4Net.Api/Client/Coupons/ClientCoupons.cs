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
    public class ClientCoupons : 
        ClientBase, 
        IParentResourceGetUpdateDeleteCreate<Coupon> 
    {
        public ClientCoupons(Configuration configuration)
            : base(configuration) { }

        public IClientResponse<List<Coupon>> Get() {
            var filter = new FilterCoupons();
            return Get(filter);
        }
        public IClientResponse<List<Coupon>> Get(IFilter filter) {
            string resourceEndpoint = "/coupons";
            return base.GetData<List<Coupon>>(resourceEndpoint, filter);
        }
        public IClientResponse<Coupon> Get(int id, IFilter filter) {
            string resourceEndpoint = string.Format("/coupons/{0}", id);
            return base.GetData<Coupon>(resourceEndpoint, filter);
        }
        public IClientResponse<Coupon> Get(int id) {
            string resourceEndpoint = string.Format("/coupons/{0}", id);
            return base.GetData<Coupon>(resourceEndpoint);
        }
        public IClientResponse<List<Coupon>> Get(string resourceEndPoint) {
            return base.GetData<List<Coupon>>(resourceEndPoint);
        }
        public IClientResponse<List<Coupon>> Get(string resourceEndPoint, IFilter filter) {
            return base.GetData<List<Coupon>>(resourceEndPoint, filter);
        }
        public IClientResponse<Coupon> Update(int id, string json) {
            string resourceEndpoint = string.Format("/coupons/{0}", id);
            return base.PutData<Coupon>(resourceEndpoint, json);
        }
        public IClientResponse<Coupon> Update(int id, object obj) {
            string resourceEndpoint = string.Format("/coupons/{0}", id);
            return base.PutData<Coupon>(resourceEndpoint, obj.SerializeObject());
        }
        public IClientResponse<Coupon> Create(string json) {
            string resourceEndpoint = "/coupons";
            return base.PostData<Coupon>(resourceEndpoint, json);
        }
        public IClientResponse<Coupon> Create(object obj) {
            string resourceEndpoint = "/coupons";
            return base.PostData<Coupon>(resourceEndpoint, obj.SerializeObject());
        }
        public IClientResponse<bool> Delete(int id) {
            string resourceEndpoint = string.Format("/coupons/{0}", id);
            return base.DeleteData(resourceEndpoint);
        }
        
        public IClientResponse<HttpOptions> GetHttpOptions(int id) {
            string resourceEndpoint = string.Format("/coupons/{0}", id);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
        public IClientResponse<HttpOptions> GetHttpOptions() {
            string resourceEndpoint = string.Format("/coupons");
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }

    }
}
