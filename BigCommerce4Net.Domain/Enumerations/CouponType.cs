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
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace BigCommerce4Net.Domain
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CouponType
    {
        [EnumMember(Value = "per_item_discount")]
        PerItemDiscount = 0,

        [EnumMember(Value = "per_total_discount")]
        PerTotalDiscount = 1,

        [EnumMember(Value = "shipping_discount")]
        ShippingDiscount = 2,

        [EnumMember(Value = "free_shipping")]
        FreeShipping = 3,

        [EnumMember(Value = "percentage_discount")]
        PercentageDiscount = 4,

    }
}
