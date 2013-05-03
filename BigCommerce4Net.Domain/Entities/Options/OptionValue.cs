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
    public class OptionValue : EntityBase
    {
        /// <summary>
        /// The unique ID of the Option Value.
        /// 
        /// int
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// The ID of the Option the value belongs to. Read only.
        /// 
        /// int
        /// </summary>
        [JsonProperty("option_id")]
        public virtual int OptionId { get; set; }

        /// <summary>
        /// The order in which the option value will be displayed.    
        /// 
        /// int
        /// </summary>
        [JsonProperty("sort_order")]
        public virtual int SortOrder { get; set; }

        /// <summary>
        /// The value in this field depends on the type of the option the value is for   
        /// 
        /// Variable
        /// </summary>
        [JsonProperty("value")]
        public virtual string OptionTypeValue { get; set; }


        /// <summary>
        /// Display option label.
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("label")]
        public virtual string Label { get; set; }
    }
}
