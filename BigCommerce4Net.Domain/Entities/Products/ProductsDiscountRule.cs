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
    public class ProductsDiscountRule : EntityBase
    {
        /// <summary>
        /// The unique ID of this discount rule. The ID is auto generated and can not be changed.
        /// 
        /// int
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// The product id which this bulk discount rule applies to. 
        /// 
        /// int
        /// </summary>
        [JsonProperty("product_id")]
        public virtual int ProductId { get; set; }

        /// <summary>
        /// Min quantity of the product in the shopping cart for this rule to apply.
        /// 
        /// int
        /// </summary>
        [JsonProperty("min")]
        public virtual int MinQuantity { get; set; }
        
        /// <summary>
        /// Max quantity of the product in the shopping cart for this rule to apply. 
        /// 
        /// int
        /// </summary>
        [JsonProperty("max")]
        public virtual int MaxQuantity { get; set; }

        /// <summary>
        /// Type of discount to apply, either apply $X off the product, each product costs $X or percentage discount for the product. 
        ///
        ///price - each product will have the discount applied defined in the type_value field.
        ///percent - each product will have its cost reduced by the percentage defined in the type_value field.
        ///fixed - each product will cost a fixed price defined by the type_value field.
        ///
        /// enum 
        /// </summary>
        [JsonProperty("type")]
        public virtual ProductsDiscountType DiscountType { get; set; }

        /// <summary>
        /// The percentage or price value which will be applied based on the discount type. 
        /// 
        /// decimal(20,4)
        /// </summary>
        [JsonProperty("type_value")]
        public virtual decimal DiscountValue { get; set; }
    }
}