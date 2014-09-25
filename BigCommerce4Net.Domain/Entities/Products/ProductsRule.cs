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
    public class ProductsRule : EntityBase
    {
        // Modified by KD
        public ProductsRule() {
            Conditions = new List<ProductsRuleConditionField>();
        }

        //List<ProductsRuleConditionField>
        /// <summary>
        /// The unique ID of the product level rule. 
        /// 
        /// int
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// The ID of the product which the rule applies to. 
        /// 
        /// int
        /// </summary>
        [JsonProperty("product_id")]
        public virtual int ProductId { get; set; }

        /// <summary>
        /// The order in which the rule will be evaluated. 
        ///When updating if the rule is given a lower priority, all rules with a sort_order of the 
        ///same value or greater will have there priority decreased (the sort_order value will be increased by 1). 
        ///If no sort_order is provided with a POST request, the rule will be added to the end of the chain.
        /// 
        /// int
        /// </summary>
        [JsonProperty("sort_order")]
        public virtual int SortOrder { get; set; }

        /// <summary>
        /// If set to true, the rule will be evaluated when a customer configures a products options.
        /// 
        /// boolean
        /// </summary>
        [JsonProperty("is_enabled")]
        public virtual bool IsEnabled { get; set; }

        /// <summary>
        /// If set to true and the rule evaluates to true, no more rules with a higher sort_order will be processed. 
        /// 
        /// boolean
        /// </summary>
        [JsonProperty("is_stop")]
        public virtual bool IsStop { get; set; }

        /// <summary>
        /// See the adjuster object definition below.
        /// 
        /// object
        /// </summary>
        [JsonProperty("price_adjuster")]
        public virtual ProductsRuleAdjuster PriceAdjuster { get; set; }

        /// <summary>
        /// See the adjuster object definition below.
        /// 
        /// object
        /// </summary>
        [JsonProperty("weight_adjuster")]
        public virtual ProductsRuleAdjuster WeightAdjuster { get; set; }

        /// <summary>
        /// If true this rule prohibits purchasing the product with the configured option values. 
        /// 
        /// boolean
        /// </summary>
        [JsonProperty("is_purchasing_disabled")]
        public virtual bool IsPurchasingDisabled { get; set; }

        /// <summary>
        /// The message to display if the rule disabled purchasing the product. 
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("purchasing_disabled_message")]
        public virtual string PurchasingDisabledMessage { get; set; }

        /// <summary>
        /// If true the rule hides the options on the product. Setting this to true has no effect if the rule is based on an SKU or has 
        /// conditions from multiple product options.
        /// 
        /// boolean
        /// </summary>
        [JsonProperty("is_purchasing_hidden")]
        public virtual bool IsPurchasingHidden { get; set; }

        /// <summary>
        /// The URI to the image used for this sku.
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("image_file")]
        public virtual string ImageFile { get; set; }

        /// <summary>
        ///See the condition fields below for a definition of the object.
        /// 
        /// object
        /// </summary>
        [JsonProperty("conditions")]
        public virtual IList<ProductsRuleConditionField> Conditions { get; set; }
    }
}