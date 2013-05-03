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
    public class FilterBrands : Filter, IFilter
    {
        /// <summary>
        /// The minimum id of the brand.
        /// </summary>
        public int? MinimumId { get; set; }

        /// <summary>
        /// The maximum id of the brand.
        /// </summary>
        public int? MaximumId { get; set; }

        /// <summary>
        /// Filter by brand name.
        /// </summary>
        public string Name { get; set; }


        public override void AddFilter(IRestRequest request) {
            base.AddFilter(request);

            if (MinimumId != null) {
                request.AddParameter("min_id", MinimumId, ParameterType.GetOrPost);
            }
            if (MaximumId != null) {
                request.AddParameter("max_id", MaximumId, ParameterType.GetOrPost);
            }
            if (Name != null) {
                request.AddParameter("name", Name, ParameterType.GetOrPost);
            }
        }
    }

}
