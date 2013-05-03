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
using RestSharp;

namespace BigCommerce4Net.Api
{
    public class FilterCoupons : Filter, IFilter
    {
        public string CouponCode { get; set; }
        public string CouponType { get; set; }
        public string Name { get; set; }
        public int? MinId { get; set; }
        public int? MaxId { get; set; }


        public override void AddFilter(IRestRequest request) {
            base.AddFilter(request);

            if (this.CouponCode != null) {
                request.AddParameter("code", this.CouponCode, ParameterType.GetOrPost);
            }

            if (this.CouponType != null) {
                request.AddParameter("type", this.CouponType, ParameterType.GetOrPost);
            }

            if (this.Name != null) {
                request.AddParameter("name", this.Name, ParameterType.GetOrPost);
            }

            if (this.MinId != null) {
                request.AddParameter("min_id", this.MinId, ParameterType.GetOrPost);
            }

            if (this.MaxId != null) {
                request.AddParameter("max_id", this.MaxId, ParameterType.GetOrPost);
            }
        }
    }
}
