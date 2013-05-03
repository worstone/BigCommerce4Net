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
    public class OrdersProductsConfigurableField : EntityBase
    {
        /// <summary>
        /// The ID of the order configurable field applied to the order product.
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// The ID of the configurable field originally applied to the Product.
        /// </summary>
        [JsonProperty("configurable_field_id")]
        public virtual int ConfigurableFieldId { get; set; }

        /// <summary>
        /// The ID of the order the configurable field is associated with. 
        /// </summary>
        [JsonProperty("order_id")]
        public virtual int OrderId { get; set; }

        /// <summary>
        /// The ID of the order product the configurable field is associated with.
        /// </summary>
        [JsonProperty("order_product_id")]
        public virtual int OrderProductId { get; set; }

        /// <summary>
        /// The ID of the actual product the field was applied to.
        /// </summary>
        [JsonProperty("product_id")]
        public virtual int ProductId { get; set; }

        /// <summary>
        /// The value that was configured/chosen by the customer. The data type of the value depends on the type of field, as described below:
        ///
        /// Short Text - text
        /// Textarea - text
        /// Select Box - text
        /// Checkbox - boolean
        /// File - string(255) - A URI to the file supplied by the customer
        /// </summary>
        [JsonProperty("value")]
        public virtual string FieldValue { get; set; }

        /// <summary>
        /// The name of the file as originally uploaded by the customer.
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("original_filename")]
        public virtual string OriginalFilename { get; set; }

        /// <summary>
        /// The name/label of the field. 
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("name")]
        public virtual string NameLabel { get; set; }

        /// <summary>
        /// The type of configurable field, one of the following string values:
        ///
        ///text (Short Text)
        ///textarea
        ///select
        ///checkbox
        ///file
        ///
        /// ?string(50)
        /// </summary>
        [JsonProperty("type")]
        public virtual string FieldType { get; set; }

        /// <summary>
        /// The list of valid options for a Select Box field as defined on the Product. 
        /// 
        /// ?string(255)
        /// </summary>
        [JsonProperty("select_box_options")]
        public virtual string SelectBoxOptions { get; set; }
    }
}
