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
    public class Option : EntityBase
    {
        /// <summary>
        /// The unique ID of the Option.
        /// 
        /// int
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// Unique reference name for the option.
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Unique reference name for the option.
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("display_name")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The type of option.
        ///
        ///C - Checkbox
        ///D - Date
        ///F - File
        ///N - Numbers Only Text
        ///T - Text
        ///MT - Multi-line Text
        ///P - Product list
        ///PI - Product list with images
        ///RB - Radio List
        ///RT - Rectangle List
        ///S - Select box
        ///CS - Swatch
        /// 
        /// enum
        /// </summary>
        [JsonProperty("type")]
        public virtual OptionType OptionType { get; set; }

        /// <summary>
        /// The values (if applicable) for the option. See the Option Values resource for details
        /// 
        /// resource
        /// </summary>
        [JsonProperty("values")]
        public virtual Resource ResourceOptionValues { get; set; }
    }
}