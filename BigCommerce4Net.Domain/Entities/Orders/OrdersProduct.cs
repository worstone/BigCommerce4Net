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
using BigCommerce4Net.Domain.ExtensionMethods;


namespace BigCommerce4Net.Domain
{
    public class OrdersProduct : EntityBase
    {
        /// <summary>
        /// The ID of the product.
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// The SKU of the product.
        /// 
        /// [string(250)]
        /// </summary>
        [JsonProperty("sku")]
        public virtual string Sku { get; set; }

        /// <summary>
        /// The name of the product.
        /// 
        /// [string(250)]
        /// </summary>
        [JsonProperty("name")]
        public virtual string ProductName { get; set; }

        /// <summary>
        /// The type of product that is one of the following values:
        ///
        /// physical
        /// digital
        /// giftcertificate
        /// </summary>
        [JsonProperty("type")]
        public virtual OrdersProductsType ProductType { get; set; }

        /// <summary>
        /// The base price of the product as entered by the store owner. 
        /// May be inc or ex tax depending on the "Prices Entered With Tax?" tax setting.
        /// 
        /// [decimal(20,4)]
        /// </summary>
        [JsonProperty("base_price")]
        public virtual decimal BasePrice { get; set; }

        /// <summary>
        /// The price of the product excluding tax.
        /// 
        /// [decimal(20,4)]
        /// </summary>
        [JsonProperty("price_ex_tax")]
        public virtual decimal PriceExcludingTax { get; set; }

        /// <summary>
        /// The price of the product include tax.
        /// 
        /// [decimal(20,4)]
        /// </summary>
        [JsonProperty("price_inc_tax")]
        public virtual decimal PriceIncludingTax { get; set; }

        /// <summary>
        /// The amount of tax on the product price.
        /// 
        /// [decimal(20,4)]
        /// </summary>
        [JsonProperty("price_tax")]
        public virtual decimal PriceTax { get; set; }

        /// <summary>
        /// The total base price (base_price * quantity).
        /// 
        /// [decimal(20,4)]
        /// </summary>
        [JsonProperty("base_total")]
        public virtual decimal BaseTotal { get; set; }

        /// <summary>
        /// The total price (price * quantity) excluding tax.
        /// 
        /// [decimal(20,4)]
        /// </summary>
        [JsonProperty("total_ex_tax")]
        public virtual decimal TotalExcludingTax { get; set; }

        /// <summary>
        /// The total price (price * quantity) including tax.
        /// 
        /// [decimal(20,4)]
        /// </summary>
        [JsonProperty("total_inc_tax")]
        public virtual decimal TotalIncludingTax { get; set; }

        /// <summary>
        /// The tax on the total price.
        /// 
        /// [decimal(20,4)]
        /// </summary>
        [JsonProperty("total_tax")]
        public virtual decimal TotalTax { get; set; }

        /// <summary>
        /// The weight of the product.
        /// 
        /// [decimal(20,4)]
        /// </summary>
        [JsonProperty("weight")]
        public virtual decimal Weight { get; set; }

        /// <summary>
        /// The quantity of the product that was purchased.
        /// </summary>
        [JsonProperty("quantity")]
        public virtual int Quantity { get; set; }

        /// <summary>
        /// The ID of the order that this product is associated with.
        /// </summary>
        [JsonProperty("order_id")]
        public virtual int OrderId { get; set; }

        /// <summary>
        /// The ID of the actual product this order product refers to.
        /// </summary>
        [JsonProperty("product_id")]
        public virtual int ProductId { get; set; }

        /// <summary>
        /// The base cost price of the product as entered by the store owner. 
        /// May be inc or ex tax depending on the "Prices Entered With Tax?" tax setting.
        /// 
        /// [decimal(20,4)]
        /// </summary>
        [JsonProperty("base_cost_price")]
        public virtual decimal BaseCostPrice { get; set; }

        /// <summary>
        /// The cost price of the product excluding tax.
        /// 
        /// [decimal(20,4)]
        /// </summary>
        [JsonProperty("cost_price_inc_tax")]
        public virtual decimal CostPriceIncludingTax { get; set; }

        /// <summary>
        /// The cost price of the product including tax.
        /// 
        /// [decimal(20,4)]
        /// </summary>
        [JsonProperty("cost_price_ex_tax")]
        public virtual decimal CostPriceExcludingTax { get; set; }

        /// <summary>
        /// The amount of tax on the cost price.
        /// 
        /// [decimal(20,4)]
        /// </summary>
        [JsonProperty("cost_price_tax")]
        public virtual decimal CostPriceTax { get; set; }

        /// <summary>
        /// Indicates if this product has been refunded.
        /// </summary>
        [JsonProperty("is_refunded")]
        public virtual bool IsRefunded { get; set; }

        /// <summary>
        /// The amount that was refunded to the customer.
        /// 
        /// [decimal(20,4)]
        /// </summary>
        [JsonProperty("refund_amount")]
        public virtual decimal RefundAmount { get; set; }

        /// <summary>
        /// The ID of the return request submitted for this product.
        /// </summary>
        [JsonProperty("return_id")]
        public virtual int ReturnId { get; set; }

        /// <summary>
        /// The name of the wrapping applied to the product.
        /// 
        /// [string(100)]
        /// </summary>
        [JsonProperty("wrapping_name")]
        public virtual string WrappingName { get; set; }

        /// <summary>
        /// The base wrapping cost as entered by the store owner. 
        /// May be inc or ex tax depending on the "Prices Entered With Tax?" tax setting.
        /// 
        /// [decimal(20,4)]
        /// </summary>
        [JsonProperty("base_wrapping_cost")]
        public virtual decimal BaseWrappingCost { get; set; }

        /// <summary>
        /// The wrapping cost excluding tax.
        /// 
        /// [decimal(20,4)]
        /// </summary>
        [JsonProperty("wrapping_cost_ex_tax")]
        public virtual decimal WrappingCostExcludingTax { get; set; }

        /// <summary>
        /// The wrapping cost including tax.
        /// 
        /// [decimal(20,4)]
        /// </summary>
        [JsonProperty("wrapping_cost_inc_tax")]
        public virtual decimal WrappingCostIncludingTax { get; set; }

        /// <summary>
        /// The amount of tax on the wrapping cost.
        /// 
        /// [decimal(20,4)]
        /// </summary>
        [JsonProperty("wrapping_cost_tax")]
        public virtual decimal WrappingCostTax { get; set; }

        /// <summary>
        /// The message left by the customer for the wrapping.
        /// 
        /// [text]
        /// </summary>
        [JsonProperty("wrapping_message")]
        public virtual string WrappingMessage { get; set; }

        /// <summary>
        /// The quantity of the product that has been shipped at this time.
        /// </summary>
        [JsonProperty("quantity_shipped")]
        public virtual int QuantityShipped { get; set; }

        /// <summary>
        /// The name of the event date defined for the product.
        /// 
        /// [string(255)]
        /// </summary>
        [JsonProperty("event_name")]
        public virtual string EventName { get; set; }

        /// <summary>
        /// The date selected by the customer for the event date.
        /// </summary>
        [JsonIgnore]
        public virtual DateTime? EventDate { get; set; }

        [JsonProperty("event_date")]
        public virtual string EventDateUT
        {
            get
            {
                return EventDate.DateTimeToString();
            }
            set
            {
                EventDate = value.StringToDateTime();
            }
        }

        /// <summary>
        /// The fixed shipping cost for the product as defined by the store owner. 
        /// May be inc or ex tax depending on the "Prices Entered With Tax?" tax setting.
        /// 
        /// [decimal(20,4)]
        /// </summary>
        [JsonProperty("fixed_shipping_cost")]
        public virtual decimal FixedShippingCost { get; set; }

        /// <summary>
        /// The ID of the shipping address that this product is associated with.
        /// </summary>
        [JsonProperty("order_address_id")]
        public virtual int OrderAddressId { get; set; }

        /// <summary>
        /// eBay's item ID for this product when it was listed on eBay.
        /// 
        /// [string(19)]
        /// </summary>
        [JsonProperty("ebay_item_id")]
        public virtual string EbayItemId { get; set; }

        /// <summary>
        /// A list of discounts (such as from Coupons or Discount Rules) applied to this product. 
        /// See the Product Discounts section below for a definition of this object.
        /// </summary>
        [JsonProperty("applied_discounts")]
        public virtual IList<OrdersProductsDiscount> AppliedDiscounts { get; set; }

        /// <summary>
        /// eBay's transaction ID for this product when purchased on eBay.
        /// 
        /// [string(19)]
        /// </summary>
        
        [JsonProperty("ebay_transaction_id")]
        public virtual string EbayTransactionId { get; set; }

        
        /// <summary>
        /// The ID of the option set applied to this product.
        /// </summary>
        [JsonIgnore]
        public virtual int OptionSetId { get; set; }

        [JsonProperty("option_set_id")]
        public virtual string OptionSetId_InString
        {
            get
            {
                if (OptionSetId == -1)
                    return "NULL";
                else
                    return OptionSetId.ToString();
            }
            set
            {
                int tmpInt;
                bool wasParsed = int.TryParse(value, out tmpInt);
                if (wasParsed)
                    OptionSetId = tmpInt;
                else
                    OptionSetId = -1;
            }
        }

        /// <summary>
        /// The ID of order product if this product was bundled with another product.
        /// </summary>
        [JsonIgnore]
        public virtual int ParentOrderProductId { get; set; }

        
        [JsonProperty("parent_order_product_id")]
        public virtual string ParentOrderProductId_InString
        {
            get
            {
                if (ParentOrderProductId == -1)
                    return "NULL";
                else
                    return ParentOrderProductId.ToString();
            }
            set
            {
                int tmpInt;
                bool wasParsed = int.TryParse(value, out tmpInt);
                if (wasParsed)
                    ParentOrderProductId = tmpInt;
                else
                    ParentOrderProductId = -1;
            }
        }

        /// <summary>
        /// Indicates if this product was bundled with another product.
        /// </summary>
        [JsonProperty("is_bundled_product")]
        public virtual bool IsBundledProduct { get; set; }

        /// <summary>
        /// The bin picking number for the product.
        /// 
        /// [string(255)]
        /// </summary>
        [JsonProperty("bin_picking_number")]
        public virtual string BinPickingNumber { get; set; }

        /// <summary>
        /// The Product Options chosen/configured by the customer when adding the product to their cart. 
        /// See the Product Options section below for a definition of this object.
        /// 
        /// See https://developer.bigcommerce.com/display/API/Order+Products
        /// </summary>
        
        
        [JsonProperty("product_options")]
        public virtual IList<OrdersProductsOption> ProductOptions { get; set; }

        /// <summary>
        /// The Configurable Fields chosen/configured by the customer when adding the product to their cart. 
        /// See the Configurable Fields section below for a definition of this object.
        /// 
        /// See https://developer.bigcommerce.com/display/API/Order+Products
        /// </summary>
        [JsonProperty("configurable_fields")]
        public virtual IList<OrdersProductsConfigurableField> ConfigurableFields { get; set; }

    }
}
