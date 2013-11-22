using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BigCommerce4Net.Domain
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomerGroupsDiscountRulesMethod
    {
        [EnumMember(Value = "price")]
        Price = 0,
        [EnumMember(Value = "percent")]
        Percent = 1,
        [EnumMember(Value = "fixed")]
        Fixed = 2
    }
}