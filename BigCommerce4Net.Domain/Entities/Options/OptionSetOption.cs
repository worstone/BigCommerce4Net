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
    public class OptionSetOption : EntityBase
    {
        /// <summary>
        /// The unique ID of the Option that has been applied to the Option Set.
        /// 
        /// int
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// The ID of that Option that this option set option refers to. 
        /// 
        /// int
        /// </summary>
        [JsonProperty("option_id")]
        public virtual int OptionId { get; set; }

        /// <summary>
        /// The ID of the Option Set that the Option was applied to. 
        /// 
        /// int
        /// </summary>
        [JsonProperty("option_set_id")]
        public virtual int OptionSetId { get; set; }

        /// <summary>
        /// The name to use for the option for this option set. This must be unique for the Option Set. 
        /// 
        /// string(255) 
        /// </summary>
        [JsonProperty("display_name")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The order in which the Option is displayed on the product's page.  
        /// 
        /// int
        /// </summary>
        [JsonProperty("sort_order")]
        public virtual int SortOrder { get; set; }

        /// <summary>
        /// Specifies whether the customer is required to enter or pick a value for this option before they can add the product to their cart. 
        /// 
        /// boolean 
        /// </summary>
        [JsonProperty("is_required")]
        public virtual bool IsRequired { get; set; }

        /// <summary>
        /// Resource link to the option this option set option is derived from. 
        /// 
        /// resource
        /// </summary>
        [JsonProperty("option")]
        public virtual Resource ResourceOption { get; set; }
    }
}
