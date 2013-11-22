using System.Collections.Generic;
using Newtonsoft.Json;

namespace BigCommerce4Net.Domain
{
    public class CustomerGroupCategoryAccess
    {
        [JsonProperty("type")]
        public virtual CustomerGroupsCategoryAccessType Type { get; set; }
        [JsonProperty("categories")]
        public virtual IList<int> Categories { get; set; }
    }
}