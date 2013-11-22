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
using RestSharp;


namespace BigCommerce4Net.Api
{
    public class FilterCustomerGroups : Filter, IFilter
    {
        public string Name { get; set; }
        public bool? IsDefault { get; set; }

        public override void AddFilter(IRestRequest request)
        {
            base.AddFilter(request);

            if (this.Name != null)
            {
                request.AddParameter("name", this.Name, ParameterType.GetOrPost);
            }

            if (this.IsDefault != null)
            {
                request.AddParameter("is_default", this.IsDefault, ParameterType.GetOrPost);
            }

        }
    }
}

