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
using Newtonsoft.Json;

namespace BigCommerce4Net.Domain
{
    public class ProductsRuleAdjuster : EntityBase
    {
        /// <summary>
        /// The adjuster for this rule: 
        ///percent - Reduce or increase the price/weight based by the percentage in the adjuster_value field. For example, setting adjuster_value for a price to 5.25 will increase the price of the product by 5.25%.
        ///relative - Reduce or increase the price/weight based by the relative value in the adjuster_value field. The adjuster_value field is assumed to be the store's default currency or weight.
        ///absolute - Set the price/weight based to the value in the adjuster_value field, regardless of any adjustments made by higher priority rules.
        /// 
        /// enum
        /// </summary>
        [JsonProperty("adjuster")]
        public virtual ProductRuleAdjusterRule AdjusterRule { get; set; }

        /// <summary>
        /// The value that which the rule will adjust the product by.
        /// 
        /// decimal(20,4)
        /// </summary>
        [JsonProperty("adjuster_value")]
        public virtual decimal AdjusterValue { get; set; }

    }
}
