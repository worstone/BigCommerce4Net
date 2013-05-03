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
    public class ProductsSkuOption : EntityBase
    {
        /// <summary>
        /// The ID of a product option which makes up the SKU. See the ?Product Options resource.
        /// 
        /// int
        /// </summary>
        [JsonProperty("product_option_id")]
        public virtual int ProductOptionId { get; set; }

        /// <summary>
        /// The ID of the option value from the product option. See the Option Values resource. 
        /// 
        /// int
        /// </summary>
        [JsonProperty("option_value_id")]
        public virtual int OptionValueId { get; set; }
    }
}
