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
    public class OrdersCoupon : EntityBase
    {
        /// <summary>
        /// The ID of the order coupon applied to the order.
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// The ID of the order the coupon was applied to. 
        /// </summary>
        [JsonProperty("order_id")]
        public virtual int OrderId { get; set; }

        /// <summary>
        /// The ID of the actual Coupon that was applied to the order. 
        /// </summary>
        [JsonProperty("coupon_id")]
        public virtual int CouponId { get; set; }

        /// <summary>
        /// The code of the coupon.
        ///
        /// string(50) 
        /// </summary>
        [JsonProperty("code")]
        public virtual string CouponCode { get; set; }

        /// <summary>
        /// The amount that the coupon is configured to discount. eg. 10 for 10% or $10 discount. 
        /// 
        /// decimal(20,4)
        /// </summary>
        [JsonProperty("amount")]
        public virtual decimal CouponAmount { get; set; }

        /// <summary>
        /// The type of coupon which is one of the following int values:
        ///
        /// 0 - Dollar amount off each item in the order
        /// 1 - Percentage off each item in the order
        /// 2 - Dollar amount off the order total
        /// 3 - Dollar amount off the shipping total
        /// 4 - Free shipping
        /// </summary>
        [JsonProperty("type")]
        public virtual OrdersCouponType CouponType { get; set; }

        [JsonProperty("discount")]
        public virtual decimal Discount { get; set; }


    }
}
