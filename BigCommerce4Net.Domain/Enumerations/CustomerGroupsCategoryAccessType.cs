using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BigCommerce4Net.Domain
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomerGroupsCategoryAccessType
    {
        [EnumMember(Value = "all")]
        All = 0,
        [EnumMember(Value = "specific")]
        Specific = 1,
        [EnumMember(Value = "none")]
        None = 2
    }
}