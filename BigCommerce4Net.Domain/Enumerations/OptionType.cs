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
    public enum OptionType
    {
        [EnumMember(Value = "C")]
        Checkbox = 0,

        [EnumMember(Value = "D")]
        Date = 1,

        [EnumMember(Value = "F")]
        File = 2,

        [EnumMember(Value = "N")]
        NumbersOnlyText = 3,

        [EnumMember(Value = "T")]
        Text = 4,

        [EnumMember(Value = "MT")]
        MultiLineText = 5,

        [EnumMember(Value = "P")]
        ProductList = 6,

        [EnumMember(Value = "PI")]
        ProductListWithImages = 7,

        [EnumMember(Value = "RB")]
        RadioList = 8,

        [EnumMember(Value = "RT")]
        RectangleList = 9,

        [EnumMember(Value = "S")]
        SelectBox = 10,

        [EnumMember(Value = "CS")]
        Swatch = 11,
    }
}
