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
    public class ProductsConfigurableField : EntityBase
    {
        /// <summary>
        /// The unique ID of this configurable field. The ID is auto generated and can not be changed.
        /// 
        /// int
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// The ID of the product the configurable field belongs to.
        /// 
        /// int
        /// </summary>
        [JsonProperty("product_id")]
        public virtual int ProductId { get; set; }

        /// <summary>
        /// The name of the field used when asking the customer to fill out the field.
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The type of the configurable field: 
        ///
        ///T - Text
        ///ML - Multi-line text
        ///C - Checkbox
        ///F - File
        ///S - Select box
        /// 
        /// enum 
        /// </summary>
        [JsonProperty("type")]
        public virtual ProductsConfigurableFieldType FieldType { get; set; }


        /// <summary>
        /// A comma separated list of file extensions for allowed file types.
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("allowed_file_types")]
        public virtual string AllowedFileTypes { get; set; }

        /// <summary>
        /// The maximum file size allowed when the type is File.
        /// 
        /// int
        /// </summary>
        [JsonProperty("max_size")]
        public virtual int MaxFileSize { get; set; }

        /// <summary>
        /// A comma separated list of values to be used when the type is a select box.
        /// 
        /// text
        /// </summary>
        [JsonProperty("select_options")]
        public virtual string SelectOptions { get; set; }

        /// <summary>
        /// If true, the customer must enter a value when purchasing the product.
        /// 
        /// boolean
        /// </summary>
        [JsonProperty("is_required")]
        public virtual bool IsRequired { get; set; }

        /// <summary>
        /// The order in which the configurable field will be displayed. 
        ///When updating if the configurable field is given a lower priority, all configurable fields 
        ///with a sort_order the same or greater than the configurable field new sort_order value  
        ///will have there priority decreased (the sort_order value will be increased by 1). 
        /// 
        /// int 
        /// </summary>
        [JsonProperty("sort_order")]
        public virtual int SortOrder { get; set; }
    }
}