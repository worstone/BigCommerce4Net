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

namespace BigCommerce4Net.Domain
{
    public class ProductsSku : EntityBase
    {
        public ProductsSku() {
            Options = new List<ProductsSkuOption>();
        }

        /// <summary>
        /// The unique numerical ID of the SKU.
        /// 
        /// int
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// The ID of the product the SKU belongs to.
        /// 
        /// int
        /// </summary>
        [JsonProperty("product_id")]
        public virtual int ProductId { get; set; }

        /// <summary>
        /// The name of the SKU.
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("sku")]
        public virtual string Sku { get; set; }

        /// <summary>
        /// Cost price for this product combination.
        /// 
        /// decimal(10,4)
        /// </summary>
        [JsonProperty("cost_price")]
        public virtual decimal CostPrice { get; set; }

        /// <summary>
        /// UPC for the product combination.
        /// 
        /// string(12)
        /// </summary>
        [JsonProperty("upc")]
        public virtual string Upc { get; set; }

        /// <summary>
        /// The current stock level for this product combination.
        /// 
        /// int
        /// </summary>
        [JsonProperty("inventory_level")]
        public virtual int InventoryLevel { get; set; }

        /// <summary>
        /// The low stock level warning for this product combination.
        /// 
        /// int
        /// </summary>
        [JsonProperty("inventory_warning_level")]
        public virtual int InventoryWarningLevel { get; set; }

        /// <summary>
        /// The bin picking number for this product combination.
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("bin_picking_number")]
        public virtual string BinPickingNumber { get; set; }

        /// <summary>
        /// See the Option fields below for a list of fields each object will contain.
        /// 
        /// object
        /// </summary>
        [JsonProperty("options")]
        public virtual IList<ProductsSkuOption> Options { get; set; }
    }
}
