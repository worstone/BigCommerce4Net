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
using System.Text;
using RestSharp;

namespace BigCommerce4Net.Api
{
    public class FilterProducts : Filter, IFilter
    {
        /// <summary>
        /// The minimum id of the product.
        /// </summary>
        public int? MinimumId { get; set; }

        /// <summary>
        /// The maximum id of the product.
        /// </summary>
        public int? MaximumId { get; set; }

        /// <summary>
        /// The product name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The product sku.
        /// </summary>
        public string Sku { get; set; }

        /// <summary>
        /// The product description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The product condition.
        /// </summary>
        public string Condition { get; set; }

        /// <summary>
        /// Filter on the availability of the product.
        /// </summary>
        public string Availability { get; set; }

        /// <summary>
        /// Filter by the products brand.
        /// </summary>
        public int? BrandId { get; set; }

        /// <summary>
        /// The minimum creation date of the product.
        /// </summary>
        public DateTime? MimimumDateCreated { get; set; }

        /// <summary>
        /// The maximum creation date of the product.
        /// </summary>
        public DateTime? MaximumDateCreated { get; set; }

        /// <summary>
        /// The minimum last modified date of the product. 
        /// </summary>
        public DateTime? MimimumDateModified { get; set; }

        /// <summary>
        /// The maximum last modified date of the product. 
        /// </summary>
        public DateTime? MaximumDateModified { get; set; }

        /// <summary>
        /// The minimum import date of the product. 
        /// </summary>
        public DateTime? MinimumDateLastImported { get; set; }

        /// <summary>
        /// The maximum import date of the product. 
        /// </summary>
        public DateTime? MaximumDateLastImported { get; set; }

        /// <summary>
        /// Filter by product visibility status.
        /// </summary>
        public bool? IsVisible { get; set; }

        /// <summary>
        /// Filter by product featured status.
        /// </summary>
        public bool? IsFeatured { get; set; }

        /// <summary>
        /// Filter by inventory level.
        /// </summary>
        public int? MimimumInventoryLevel { get; set; }

        /// <summary>
        /// Filter by inventory level.
        /// </summary>
        public int? MaximumInventoryLevel { get; set; }

        /// <summary>
        /// Filter on product price.
        /// </summary>
        public decimal? MimimumPrice { get; set; }

        /// <summary>
        /// Filter on product price.
        /// </summary>
        public decimal? MaximumPrice { get; set; }

        /// <summary>
        /// Filter on the number of the product that has been sold.
        /// </summary>
        public int? MimimumNumberSold { get; set; }

        /// <summary>
        /// Filter on the number of the product that has been sold. 
        /// </summary>
        public int? MaximumNumberSold { get; set; }


        public override void AddFilter(IRestRequest request) {
            base.AddFilter(request);

            if (this.MinimumId != null) {
                request.AddParameter("min_id", this.MinimumId, ParameterType.GetOrPost);
            }
            if (this.MaximumId != null) {
                request.AddParameter("max_id", this.MaximumId, ParameterType.GetOrPost);
            }
            if (this.Name != null) {
                request.AddParameter("name", this.Name, ParameterType.GetOrPost);
            }
            if (this.Sku != null) {
                request.AddParameter("sku", this.Sku, ParameterType.GetOrPost);
            }
            if (this.Description != null) {
                request.AddParameter("description", this.Description, ParameterType.GetOrPost);
            }
            if (this.Condition != null) {
                request.AddParameter("condition", this.Condition, ParameterType.GetOrPost);
            }
            if (this.Availability != null) {
                request.AddParameter("availability", this.Availability, ParameterType.GetOrPost);
            }
            if (this.BrandId != null) {
                request.AddParameter("brand_id", this.BrandId, ParameterType.GetOrPost);
            }
            if (this.MimimumDateCreated != null) {
                request.AddParameter("min_date_created",
                    String.Format(RFC2822_DATE_FORMAT, this.MimimumDateCreated), ParameterType.GetOrPost);
            }
            if (this.MaximumDateCreated != null) {
                request.AddParameter("max_date_created",
                    String.Format(RFC2822_DATE_FORMAT, this.MaximumDateCreated), ParameterType.GetOrPost);
            }
            if (this.MimimumDateModified != null) {
                request.AddParameter("min_date_modified",
                    String.Format(RFC2822_DATE_FORMAT, this.MimimumDateModified), ParameterType.GetOrPost);
            }
            if (this.MaximumDateModified != null) {
                request.AddParameter("max_date_modified",
                    String.Format(RFC2822_DATE_FORMAT, this.MaximumDateModified), ParameterType.GetOrPost);
            }
            if (this.MinimumDateLastImported != null) {
                request.AddParameter("min_date_last_imported",
                    String.Format(RFC2822_DATE_FORMAT, this.MinimumDateLastImported), ParameterType.GetOrPost);
            }
            if (this.MaximumDateLastImported != null) {
                request.AddParameter("max_date_last_imported",
                    String.Format(RFC2822_DATE_FORMAT, this.MaximumDateLastImported), ParameterType.GetOrPost);
            }
            if (this.IsVisible != null) {
                request.AddParameter("is_visible", this.IsVisible, ParameterType.GetOrPost);
            }
            if (this.IsFeatured != null) {
                request.AddParameter("is_featured", this.IsFeatured, ParameterType.GetOrPost);
            }
            if (this.MimimumInventoryLevel != null) {
                request.AddParameter("min_inventory_level", this.MimimumInventoryLevel, ParameterType.GetOrPost);
            }
            if (this.MaximumInventoryLevel != null) {
                request.AddParameter("max_inventory_level", this.MaximumInventoryLevel, ParameterType.GetOrPost);
            }
            if (this.MimimumPrice != null) {
                request.AddParameter("min_price", this.MimimumPrice, ParameterType.GetOrPost);
            }
            if (this.MaximumPrice != null) {
                request.AddParameter("max_price", this.MaximumPrice, ParameterType.GetOrPost);
            }
            if (this.MimimumNumberSold != null) {
                request.AddParameter("min_number_sold", this.MimimumNumberSold, ParameterType.GetOrPost);
            }
            if (this.MaximumNumberSold != null) {
                request.AddParameter("max_number_sold", this.MaximumNumberSold, ParameterType.GetOrPost);
            }
        }
    }
}
