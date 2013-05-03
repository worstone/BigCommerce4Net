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
    public class OrdersProductsOption : EntityBase
    {
        /// <summary>
        /// The ID of the order product option applied to the order product.
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// The ID of the order product the option is applied to. 
        /// </summary>
        [JsonProperty("order_product_id")]
        public virtual int OrderProductId { get; set; }

        /// <summary>
        /// The ID of the Product Option the order product option refers to. 
        /// </summary>
        [JsonProperty("option_id")]
        public virtual int OptionId { get; set; }

        /// <summary>
        /// The ID of the Product Option that was applied to the actual product. 
        /// </summary>
        [JsonProperty("product_option_id")]
        public virtual int ProductOptionId { get; set; }

        /// <summary>
        /// The type of Product Option. eg. Multiple choice 
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("type")]
        public virtual string ProductOptionType { get; set; }

        /// <summary>
        /// The display style of the Product Option. eg. Radio 
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("display_style")]
        public virtual string DisplayStyle { get; set; }

        /// <summary>
        /// The unique internal reference name of the Product Option. 
        /// </summary>
        [JsonProperty("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The display name of the Product Option (as shown on the product page). 
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("display_name")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The customer supplied value for this option. The value depends on the type 
        /// of Product Option. See the Product Option supplemental document for more details.  
        /// </summary>
        [JsonProperty("value")]
        public virtual string Value { get; set; }

        /// <summary>
        /// A readable representation of the customer supplied value. 
        /// 
        /// text 
        /// </summary>
        [JsonProperty("display_value")]
        public virtual string DisplayValue { get; set; }
    }
}
