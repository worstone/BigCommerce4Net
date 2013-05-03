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
    public class ProductsOption : EntityBase
    {
        /// <summary>
        /// The unique ID of the product option. 
        /// 
        /// int
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// The ID of the options entity the product option refers to. 
        /// 
        /// int
        /// </summary>
        [JsonProperty("option_id")]
        public virtual int OptionId { get; set; }

        /// <summary>
        /// The custom name for the option when displayed under the product.
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("display_name")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The position the option will be shown on the products page.
        /// 
        /// int
        /// </summary>
        [JsonProperty("sort_order")]
        public virtual int SortOrder { get; set; }

        /// <summary>
        /// If true the customer must choose an option when ordering the product.
        /// 
        /// boolean
        /// </summary>
        [JsonProperty("is_required")]
        public virtual bool IsRequired { get; set; }
    }
}