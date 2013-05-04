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
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BigCommerce4Net.Domain
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrdersProductsType
    {
        [EnumMember(Value = "physical")]
        Physical = 0,
        
        [EnumMember(Value = "digital")]
        Digital = 1,
        
        [EnumMember(Value = "giftcertificate")]
        GiftCertificate = 2
    }
}
