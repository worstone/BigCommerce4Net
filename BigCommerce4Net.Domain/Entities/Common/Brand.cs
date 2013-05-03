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
    public class Brand :  EntityBase
    {
        /// <summary>
        /// The ID of the brand.
        /// 
        /// Store ID
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// The name of the brand. A brand's name must be unique.
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The title shown in the browser when viewing the brand in 
        /// the store front.
        /// 
        /// string(250)
        /// </summary>
        [JsonProperty("page_title")]
        public virtual string PageTitle { get; set; }

        /// <summary>
        /// A comma separated list of meta keywords to include in the html.
        /// 
        /// text
        /// </summary>
        [JsonProperty("meta_keywords")]
        public virtual string MetaKeywords { get; set; }

        /// <summary>
        /// A meta description to include in the html.
        /// 
        /// text
        /// </summary>
        [JsonProperty("meta_description")]
        public virtual string MetaDescription { get; set; }

        /// <summary>
        /// The URI to the image used for this brand.
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("image_file")]
        public virtual string ImageFile { get; set; }

        /// <summary>
        /// A comma separated list of keywords that can be used to locate 
        /// this brand when searching the store.
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("search_keywords")]
        public virtual string SearchKeywords { get; set; }
    }
}
