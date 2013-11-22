using Newtonsoft.Json;

namespace BigCommerce4Net.Domain
{
    public class CustomerGroupDiscountRule
    {
        [JsonProperty("type")]
        public virtual CustomerGroupsDiscountRulesType Type { get; set; }
        [JsonProperty("method")]
        public virtual CustomerGroupsDiscountRulesMethod Method { get; set; }
        [JsonProperty("amount")]
        public virtual decimal Amount { get; set; }
        [JsonProperty("product_id")]
        public virtual int ProductId { get; set; }
        [JsonProperty("category_id")]
        public virtual int CategoryId { get; set; }

    }
}