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
using BigCommerce4Net.Domain.ExtensionMethods;

namespace BigCommerce4Net.Domain
{
    public class Coupon : EntityBase
    {
        /// <summary>
        /// The ID of the coupon.
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// The name of the coupon.
        /// 
        /// string(?)
        /// </summary>
        [JsonProperty("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The coupon code which customers will use to receive their discounts. Must be Unique.
        /// 
        /// string(?)
        /// </summary>
        [JsonProperty("code")]
        public virtual string CouponCode { get; set; }

        /// <summary>
        /// The coupon type field is an enumerated field and a value from the following list should be used.
        ///per_item_discount
        ///per_total_discount
        ///shipping_discount
        ///free_shipping
        ///percentage_discount
        ///
        /// enum
        /// </summary>
        [JsonProperty("type")]
        public virtual CouponType CouponType { get; set; }

        /// <summary>
        /// The amount is a decimal field which can either be the monetary discount to be applied to an order or a 
        /// percentage discount to be applied to an order. The type of this field is determined by the coupon type.
        /// 
        /// decimal(20,4)
        /// </summary>
        [JsonProperty("amount")]
        public virtual decimal Amount { get; set; }

        /// <summary>
        /// This is a decimal field which specifies the minimum value an order must have before the coupon can be applied to it.
        /// 
        /// decimal(20,4)
        /// </summary>
        [JsonProperty("min_purchase")]
        public virtual decimal MinPurchase { get; set; }

        /// <summary>
        /// True, if coupon is enabled. False otherwise.
        /// 
        /// boolean
        /// </summary>
        [JsonProperty("enabled")]
        public virtual bool Enabled { get; set; }


        /// <summary>
        /// This is a date field which specifies when a coupon expires. Coupons need not have an expiry date as 
        /// you can also control expiry via max_uses and max_uses_per_customer. 
        /// The date field must be formatted as per RFC-2822.
        /// 
        /// Date
        /// </summary>
        [JsonIgnore]
        public virtual DateTime? Expires { get; set; }

        [JsonProperty("expires")]
        public virtual string ExpiresUT {
            get {
                return Expires.DateTimeToString();
            }
            set {
                Expires = value.StringToDateTime();
            }
        }

        /// <summary>
        /// This object provides
        ///ability to restrict a coupon to an entity type (category/product)
        ///and ability to restrict a coupon specific categories/products, where 0 is all categories/products.
        /// 
        /// object
        /// </summary>
        [JsonProperty("applies_to")]
        public virtual object AppliesTo { get; set; }

        /// <summary>
        /// Number of times this coupon has been used. This is a readonly field and can't be changed via PUT or POST.
        /// 
        /// integer
        /// </summary>
        [JsonProperty("num_uses")]
        public virtual int NumberOfUses { get; set; }

        /// <summary>
        /// Maximum number of times this coupon can be used.
        /// 
        /// integer
        /// </summary>
        [JsonProperty("max_uses")]
        public virtual int MaxUses { get; set; }

        /// <summary>
        /// Maximum number of times each customer can use this coupon.
        /// 
        /// integer
        /// </summary>
        [JsonProperty("max_uses_per_customer")]
        public virtual int MaxUsesPerCustomer { get; set; }

        /// <summary>
        /// This field provides the ability to restrict coupon usage  - See Docs
        /// 
        /// array
        /// </summary>
        [JsonProperty("restricted_to")]
        public virtual object RestrictedTo { get; set; }

        /// <summary>
        /// This is a list of shipping method names. If a shipping method isn't enabled on the 
        /// store it can't be used to with a coupon. To check which shipping methods are enabled 
        /// please do a GET request on the /shipping/methods.json endpoint.
        /// 
        /// array
        /// </summary>
        [JsonProperty("shipping_methods")]
        public virtual object ShippingMethods { get; set; }



    }
}
