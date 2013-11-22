using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BigCommerce4Net.Domain
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomerGroupsDiscountRulesType
    {
        [EnumMember(Value = "all")]
        All = 0,
        [EnumMember(Value = "product")]
        Product = 1,
        [EnumMember(Value = "category")]
        Category = 2
    }
}