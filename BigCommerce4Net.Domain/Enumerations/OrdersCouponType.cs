using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BigCommerce4Net.Domain
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrdersCouponType
    {
        /// <summary>
        /// 0 - Dollar amount off each item in the order
        /// </summary>
        [EnumMember(Value = "0")]
        DollarAmountOffEachItemInOrder = 0,

        /// <summary>
        /// 1 - Percentage off each item in the order
        /// </summary>
        [EnumMember(Value = "1")]
        PercentageOffEachItemInOrder = 1,

        /// <summary>
        /// 2 - Dollar amount off the order total
        /// </summary>
        [EnumMember(Value = "2")]
        DollarAmountAffOrderTotal = 2,

        /// <summary>
        /// 3 - Dollar amount off the shipping total
        /// </summary>
        [EnumMember(Value = "3")]
        DollarAmountOffShippingTotal = 3,

        /// <summary>
        /// 4 - Free shipping
        /// </summary>
        [EnumMember(Value = "4")]
        FreeShipping = 4
    }
}
