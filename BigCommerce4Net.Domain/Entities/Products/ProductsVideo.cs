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
    public class ProductsVideo : EntityBase
    {
        /// <summary>
        /// The YouTube ID for the video. - unique
        /// 
        /// string(255) 
        /// </summary>
        [JsonProperty("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The ID of the product the video is a preview for. 
        /// 
        /// int
        /// </summary>
        [JsonProperty("product_id")]
        public virtual int ProductId { get; set; }

        /// <summary>
        /// The ID of the product the video is a preview for. 
        /// 
        /// int
        /// </summary>
        [JsonProperty("sort_order")]
        public virtual int SortOrder { get; set; }

        /// <summary>
        /// The order in which the video will be displayed on the product page. 
        ///When updating if the video is given a lower priority, all videos with a sort_order the 
        ///same or greater than the videos new sort_order value will have there priority 
        ///decreased (the sort_order value will be increased by 1). 
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The description for the video.
        /// 
        /// text
        /// </summary>
        [JsonProperty("description")]
        public virtual string Description { get; set; }
    }
}
