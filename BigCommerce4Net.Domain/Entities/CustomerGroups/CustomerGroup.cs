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

using System.Collections.Generic;
using Newtonsoft.Json;

namespace BigCommerce4Net.Domain
{
    public class CustomerGroup : EntityBase
    {
        /// <summary>
        /// The ID of the customer group.
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// The Name of the customer group.
        /// </summary>
        [JsonProperty("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Whether or not this customer group is the default group for new customers.
        /// </summary>
        [JsonProperty("is_default")]
        public virtual bool IsDefault { get; set; }

        [JsonProperty("category_access")]
        public virtual CustomerGroupCategoryAccess CategoryAccess { get; set; }

        [JsonProperty("discount_rules")]
        public virtual IList<CustomerGroupDiscountRule> DiscountRules { get; set; }

        public CustomerGroup()
        {
            DiscountRules = new List<CustomerGroupDiscountRule>();
        }
    }
}
