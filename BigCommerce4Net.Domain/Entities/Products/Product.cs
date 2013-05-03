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
    public class Product : EntityBase
    {
        public Product() {

            Rules = new List<ProductsRule>();
            Options = new List<ProductsOption>();
            Skus = new List<ProductsSku>();
            OptionSets = new List<OptionSet>();
            Videos = new List<ProductsVideo>();
            CustomFields = new List<ProductsCustomField>();
            ConfigurableFields = new List<ProductsConfigurableField>();
            DiscountRules = new List<ProductsDiscountRule>();
            Images = new List<ProductsImage>();
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}-[{3}]", Id, Sku, Name, Price);
        }
        
        /// <summary>
        /// The unique ID of this product. The ID is auto generated and can not be changed.
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// The product name.
        /// 
        /// [string(250)]
        /// </summary>
        [JsonProperty("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The product type: 
        /// 
        ///physical - a physical stock unit
        ///digital - a digital download
        /// </summary>
        [JsonProperty("type")]
        public virtual ProductsType Type { get; set; }

        /// <summary>
        /// User defined product code/stock keeping unit (SKU).
        /// 
        /// The SKU must be unique.
        /// 
        /// [string(250)]
        /// </summary>
        [JsonProperty("sku")]
        public virtual string Sku { get; set; }

        /// <summary>
        /// The product description which can include HTML formatting.
        /// 
        /// [text]
        /// </summary>
        [JsonProperty("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// A comma separated list of keywords that can be used to locate 
        /// the product when searching the store.
        /// 
        /// [text]
        /// </summary>
        [JsonProperty("search_keywords")]
        public virtual string SearchKeywords { get; set; }

        /// <summary>
        /// Availability text displayed on the checkout page under the product 
        /// title telling the customer how long it will normally take to ship 
        /// this product, such as "Usually ships in 24 hours".
        /// 
        /// [string(250)]
        /// </summary>
        [JsonProperty("availability_description")]
        public virtual string AvailabilityDescription { get; set; }

        /// <summary>
        /// The price of the product, the price should include or exclude tax based 
        /// on the store settings.
        /// </summary>
        [JsonProperty("price")]
        public virtual decimal Price { get; set; }

        /// <summary>
        /// The cost price of the product, stored for reference only, it is not used or 
        /// displayed anywhere on the store.
        /// </summary>
        [JsonProperty("cost_price")]
        public virtual decimal CostPrice { get; set; }

        /// <summary>
        /// The retail cost of the product, if entered the retail cost price will be shown 
        /// on the product page.
        /// </summary>
        [JsonProperty("retail_price")]
        public virtual decimal RetailPrice { get; set; }

        /// <summary>
        /// The sale price will be used instead of value in the price field when calculating 
        /// the products cost if entered.
        /// </summary>
        [JsonProperty("sale_price")]
        public virtual decimal SalePrice { get; set; }

        /// <summary>
        /// Priority this product will be given when included in product lists on category 
        /// pages and search results. The lower the number, the closer to the top of the 
        /// results the product will be.
        /// </summary>
        [JsonProperty("sort_order")]
        public virtual int SortOrder { get; set; }

        /// <summary>
        /// Flag to determine if the product should be displayed to customers browsing the 
        /// store or not. If true the product will be displayed, false the product will be 
        /// hidden from view.
        /// </summary>
        [JsonProperty("is_visible")]
        public virtual bool IsVisible { get; set; }

        /// <summary>
        /// Flag to determine if the product should be included in "featured products" 
        /// panel when viewing the store.
        /// </summary>
        [JsonProperty("is_featured")]
        public virtual bool IsFeatured { get; set; }

        /// <summary>
        /// A list of related products which will be shown on the products page.  If not specified 
        /// related products will be generated automatically by the store.
        /// 
        /// [string(250)]
        /// </summary>
        [JsonProperty("related_products")]
        public virtual string RelatedProducts { get; set; }

        /// <summary>
        /// Current inventory level of the product. Simple inventory tracking must be enabled 
        /// (See the inventory_tracking field) for this to take any effect.
        /// </summary>
        [JsonProperty("inventory_level")]
        public virtual int InventoryLevel { get; set; }

        /// <summary>
        /// Inventory Warning level for the product. When the products inventory 
        /// level drops below the warning level the store owner will be informed. Simple 
        /// inventory tracking must be enabled (See the inventory_tracking field) for this 
        /// to take any effect.
        /// </summary>
        [JsonProperty("inventory_warning_level")]
        public virtual int InventoryWarningLevel { get; set; }

        /// <summary>
        /// Warranty information displayed on the product page which can include HTML formatting.
        /// 
        /// [text]
        /// </summary>
        [JsonProperty("warranty")]
        public virtual string Warranty { get; set; }

        /// <summary>
        /// Weight of the product used which can be used when calculating shipping costs.
        /// </summary>
        [JsonProperty("weight")]
        public virtual decimal Weight { get; set; }

        /// <summary>
        /// Width of the product used which can be used when calculating shipping costs. 
        /// </summary>
        [JsonProperty("width")]
        public virtual decimal Width { get; set; }

        /// <summary>
        /// Height of the product used which can be used when calculating shipping costs.
        /// </summary>
        [JsonProperty("height")]
        public virtual decimal Height { get; set; }

        /// <summary>
        /// Depth of the product used which can be used when calculating shipping costs.
        /// </summary>
        [JsonProperty("depth")]
        public virtual decimal Depth { get; set; }

        /// <summary>
        /// A fixed shipping cost for the product, if defined the value will be used during 
        /// checkout instead of normal shipping cost calculation.
        /// </summary>
        [JsonProperty("fixed_cost_shipping_price")]
        public virtual decimal FixedCostShippingPrice { get; set; }

        /// <summary>
        /// Flag used to indicate if the product has free shipping or not. If true 
        /// the shipping cost for the product will be zero.
        /// </summary>
        [JsonProperty("is_free_shipping")]
        public virtual bool IsFreeShipping { get; set; }

        /// <summary>
        ///The type of inventory tracking for the product: 
        ///none - inventory levels will not be tracked.
        ///simple - inventory levels will be tracked using the "inventory_level" and "inventory_warning_level" fields.
        ///sku - inventory levels will be tracked based on individual product options which maintain their own warning levels and inventory levels.
        /// </summary>
        [JsonProperty("inventory_tracking")]
        public virtual ProductsInventoryTracking InventoryTracking { get; set; }

        /// <summary>
        /// The total rating for the product.
        /// </summary>
        [JsonProperty("rating_total")]
        public virtual int RatingTotal { get; set; }

        /// <summary>
        /// The total number of ratings the product has had.
        /// </summary>
        [JsonProperty("rating_count")]
        public virtual int RatingCount { get; set; }

        /// <summary>
        /// The total number of times this product has been sold.
        /// </summary>
        [JsonProperty("total_sold")]
        public virtual int NumberSold { get; set; }

        /// <summary>
        /// The date of which the product was created.
        /// </summary>
        [JsonIgnore]
        public virtual DateTime? DateCreated { get; set; }

        [JsonProperty("date_created")]
        public virtual string DateCreatedUT
        {
            get
            {
                return DateCreated.DateTimeToString();
            }
            set
            {
                DateCreated = value.StringToDateTime();
            }
        }

        /// <summary>
        /// The ID of the brand the product belongs to. See the Brands resource 
        /// for information.
        /// </summary>
        [JsonProperty("brand_id")]
        public virtual int BrandId { get; set; }

        /// <summary>
        /// The number of times the product has been viewed.
        /// </summary>
        [JsonProperty("view_count")]
        public virtual int ViewCount { get; set; }

        /// <summary>
        /// Custom title for the products page, if not defined the product name 
        /// will be used as the page title.
        /// 
        /// [string(250)]
        /// </summary>
        [JsonProperty("page_title")]
        public virtual string PageTitle { get; set; }

        /// <summary>
        /// Custom meta keywords for the product page, if not defined the store 
        /// default keywords will be used.
        /// 
        /// [text]
        /// </summary>
        [JsonProperty("meta_keywords")]
        public virtual string MetaKeywords { get; set; }

        /// <summary>
        /// Custom meta description for the product page, if not defined the store default 
        /// meta description will be used.
        /// 
        /// [text]
        /// </summary>
        [JsonProperty("meta_description")]
        public virtual string MetaDescription { get; set; }

        /// <summary>
        /// The layout template file used to render this category.
        /// 
        /// [string(50)]
        /// </summary>
        [JsonProperty("layout_file")]
        public virtual string LayoutFile { get; set; }

        /// <summary>
        /// Flag used to determine if the price for this product should be hidden on the product page.
        /// </summary>
        [JsonProperty("is_price_hidden")]
        public virtual bool IsPriceHidden { get; set; }

        /// <summary>
        /// If the product price is hidden (see the "is_price_hidden" field), then a label will be displayed 
        /// instead with the value of this field if it is defined.
        /// 
        /// [string(200)]
        /// </summary>
        [JsonProperty("price_hidden_label")]
        public virtual string PriceHiddenLabel { get; set; }

        /// <summary>
        /// An array of IDs for the categories this product belongs to. 
        ///When updating a product, if an array of categories is supplied all product categories will be over written.
        /// </summary>
        [JsonProperty("categories")]
        public virtual IList<int> Categories { get; set; }

        /// <summary>
        /// The date that the product was last modified.
        /// </summary>
        [JsonIgnore]
        public virtual DateTime? DateModified { get; set; }

        [JsonProperty("date_modified")]
        public virtual string DateModifiedUT
        {
            get
            {
                return DateModified.DateTimeToString();
            }
            set
            {
                DateModified = value.StringToDateTime();
            }
        }

        /// <summary>
        /// Name of the field to be displayed on the product page when selecting the "delivery/event" date.
        /// 
        /// [string(255)]
        /// </summary>
        [JsonProperty("event_date_field_name")]
        public virtual string EventDateFieldName { get; set; }

        /// <summary>
        ///none - If set to none then the event/delivery date requirement and field will be disabled.
        ///after - The selected date must fall either on or after the date specified in the "event_date_start" field.
        ///before - The selected date must fall either before or on the date specified in the "event_date_end" field.
        ///range - The selected date must fall between the "event_date_start" and "event_date_end" dates.
        /// </summary>
        [JsonProperty("event_date_type")]
        public virtual ProductsEventDateType EventDateType { get; set; }

        /// <summary>
        /// The date which is used as the "after" date when the product requires the customer 
        /// to select a delivery/event date.
        /// </summary>
        [JsonIgnore]
        public virtual DateTime? EventDateStart { get; set; }

        [JsonProperty("event_date_start")]
        public virtual string EventDateStartUT
        {
            get
            {
                return EventDateStart.DateTimeToString();
            }
            set
            {
                EventDateStart = value.StringToDateTime();
            }
        }

        /// <summary>
        /// The date which is used as the "before" date when the product requires the customer 
        /// to select a delivery/event date.
        /// </summary>
        [JsonIgnore]
        public virtual DateTime? EventDateEnd { get; set; }

        [JsonProperty("event_date_end")]
        public virtual string EventDateEndUT
        {
            get
            {
                return EventDateEnd.DateTimeToString();
            }
            set
            {
                EventDateEnd = value.StringToDateTime();
            }
        }

        /// <summary>
        /// MYOB Asset Account.
        /// 
        /// [string(20)]
        /// </summary>
        [JsonProperty("myob_asset_account")]
        public virtual string MyobAssetAccount { get; set; }

        /// <summary>
        /// MYOB Income Account.
        /// 
        /// [string(20)]
        /// </summary>
        [JsonProperty("myob_income_account")]
        public virtual string MyobIncomeAccount { get; set; }

        /// <summary>
        /// MYOB Expense/COS Account.
        /// 
        /// [string(20)]
        /// </summary>
        [JsonProperty("myob_expense_account")]
        public virtual string MyobExpenseAccount { get; set; }

        /// <summary>
        /// Peachtree General Ledger Account.
        /// 
        /// [string(20)]
        /// </summary>
        [JsonProperty("peachtree_gl_account")]
        public virtual string PeachtreeGlAccount { get; set; }

        /// <summary>
        /// The product condition, will be shown on the product page if the value of 
        /// the "is_condition_shown" field is true. Possible values: 
        ///New
        ///Used
        ///Refurbished
        /// </summary>
        [JsonProperty("condition")]
        public virtual ProductsCondition Condition { get; set; }

        /// <summary>
        /// Flag used to determine if the product condition is shown to the customer on 
        /// the product page.
        /// </summary>
        [JsonProperty("is_condition_shown")]
        public virtual bool IsConditionShown { get; set; }

        /// <summary>
        /// Pre-order release date. See availability field for details on setting a 
        /// products availability to accept pre-orders.
        /// </summary>
        [JsonIgnore]
        public virtual DateTime? PreorderReleaseDate { get; set; }

        [JsonProperty("preorder_release_date")]
        public virtual string PreorderReleaseDateUT
        {
            get
            {
                return PreorderReleaseDate.DateTimeToString();
            }
            set
            {
                PreorderReleaseDate = value.StringToDateTime();
            }
        }

        /// <summary>
        /// If set to false, the product will not change its availability from 
        /// preorder to available on the release date. Otherwise on the release date
        /// the products availability/status will change to available.
        /// </summary>
        [JsonProperty("is_preorder_only")]
        public virtual bool IsPreorderOnly { get; set; }

        /// <summary>
        /// Custom expected date message to display on the product page, if undefined 
        /// the message defaults to the store wide setting. Can contain the %%DATE%% 
        /// place holder which will be substituted for the release date
        /// </summary>
        [JsonProperty("preorder_message")]
        public virtual string PreorderMessage { get; set; }

        /// <summary>
        /// The minimum quantity an order has to contain to be able to purchase this product.
        /// </summary>
        [JsonProperty("order_quantity_minimum")]
        public virtual int OrderQuantityMinimum { get; set; }

        /// <summary>
        /// The maximum quantity an order can contain when purchasing the product.
        /// </summary>
        [JsonProperty("order_quantity_maximum")]
        public virtual int OrderQuantityMaximum { get; set; }

        /// <summary>
        /// Type of product, valid values are: 
        ///product
        ///album
        ///book
        ///drink
        ///food
        ///game
        ///movie
        ///song
        ///tv_show
        /// </summary>
        [JsonProperty("open_graph_type")]
        public virtual ProductsOpenGraphType OpenGraphType { get; set; }

        /// <summary>
        /// Title of the product, if not specified the product name will be used instead.
        /// 
        /// [string(250)]
        /// </summary>
        [JsonProperty("open_graph_title")]
        public virtual string OpenGraphTitle { get; set; }

        /// <summary>
        /// Description to use for the product, if not specified then the meta_description 
        /// will be used instead.
        /// 
        /// [text]
        /// </summary>
        [JsonProperty("open_graph_description")]
        public virtual string OpenGraphDescription { get; set; }

        /// <summary>
        /// If set to true, the product thumbnail image will be used as the open graph image.
        /// </summary>
        [JsonProperty("is_open_graph_thumbnail")]
        public virtual bool IsOpenGraphThumbnail { get; set; }

        /// <summary>
        /// The product UPC code which is used in feeds for shopping comparison sites. 
        /// 
        /// [string(32)]
        /// </summary>
        [JsonProperty("upc")]
        public virtual string Upc { get; set; }

        /// <summary>
        /// The date of which the product was last imported using the bulk importer.
        /// </summary>
        [JsonIgnore]
        public virtual DateTime? DateLastImported { get; set; }

        [JsonProperty("date_last_imported")]
        public virtual string DateLastImportedUT
        {
            get
            {
                return DateLastImported.DateTimeToString();
            }
            set
            {
                DateLastImported = value.StringToDateTime();
            }
        }

        /// <summary>
        /// The ID of the option set applied to the product. 
        /// Note: To remove the option set off the product, set the value to "null" on update.
        /// </summary>
        [JsonProperty("option_set_id")]
        public virtual string OptionSetId { get; set; }

        /// <summary>
        /// The ID of the tax class applied to the product.
        /// </summary>
        [JsonProperty("tax_class_id")]
        public virtual int TaxClassId { get; set; }

        /// <summary>
        /// The position the option set options will be displayed on the product page.
        /// </summary>
        [JsonProperty("option_set_display")]
        public virtual ProductsOptionSetDisplay OptionSetDisplay { get; set; }

        /// <summary>
        /// The BIN picking number for the product.
        /// 
        /// [string(255)]
        /// </summary>
        [JsonProperty("bin_picking_number")]
        public virtual string BinPickingNumber { get; set; }

        /// <summary>
        /// Availability of the product. availability options: 
        ///available - The product can be purchased in the store front.
        ///disabled - The product is listed in the store front but can not be purchased.
        ///preorder - The product is listed for pre-orders.
        /// </summary>
        [JsonProperty("availability")]
        public virtual ProductsAvailability Availability { get; set; }

        [JsonProperty("custom_url")]
        public virtual string CustomUrl { get; set; }

        /// <summary>
        /// See the Images resource for information.
        /// </summary>
        [JsonProperty("images")]
        public virtual Resource ResourceImages { get; set; }

        [JsonIgnore]
        public virtual IList<ProductsImage> Images { get; set; }

        /// <summary>
        /// See the Bulk Discount Rules resource for information.
        /// </summary>
        [JsonProperty("discount_rules")]
        public virtual Resource ResourceDiscountRules { get; set; }

        [JsonIgnore]
        public virtual IList<ProductsDiscountRule> DiscountRules { get; set; }

        /// <summary>
        /// See the Configurable Fields resource for information.
        /// </summary>
        [JsonProperty("configurable_fields")]
        public virtual Resource ResourceConfigurableFields { get; set; }

        [JsonIgnore]
        public virtual IList<ProductsConfigurableField> ConfigurableFields { get; set; }

        /// <summary>
        /// See the Custom Fields resource for information.
        /// </summary>
        [JsonProperty("custom_fields")]
        public virtual Resource ResourceCustomFields { get; set; }

        [JsonIgnore]
        public virtual IList<ProductsCustomField> CustomFields { get; set; }

        /// <summary>
        /// See the Videos resource for information.
        /// </summary>
        [JsonProperty("videos")]
        public virtual Resource ResourceVideos { get; set; }

        [JsonIgnore]
        public virtual IList<ProductsVideo> Videos { get; set; }

        /// <summary>
        /// See the Option Set resource for information.
        /// </summary>
        [JsonProperty("option_set")]
        public virtual Resource ResourceOptionSet { get; set; }

        [JsonIgnore]
        public virtual IList<OptionSet> OptionSets { get; set; }

        /// <summary>
        /// Rules which apply to this product only which are based on the products Option Set. 
        /// See Rules resource for information.
        /// </summary>
        [JsonProperty("rules")]
        public virtual Resource ResourceRules { get; set; }

        [JsonIgnore]
        public virtual IList<ProductsRule> Rules { get; set; }
        
        /// <summary>
        /// Stock Keeping Units for the product. 
        /// See the SKU resource for the definition of a sku object.
        /// </summary>
        [JsonProperty("skus")]
        public virtual Resource ResourceSkus { get; set; }

        [JsonIgnore]
        public virtual IList<ProductsSku> Skus { get; set; }
        
        /// <summary>
        /// Options from the option set applied to the product. 
        /// See the Product Options resource for information.
        /// </summary>
        [JsonProperty("options")]
        public virtual Resource ResourceOptions { get; set; }

        [JsonIgnore]
        public virtual IList<ProductsOption> Options { get; set; }

    }
}
