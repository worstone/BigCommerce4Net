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
    public class FilterOrders : Filter, IFilter
    {
        /// <summary>
        /// The minimum id of the order.
        /// </summary>
        public int? MinimumId { get; set; }

        /// <summary>
        /// The maximum id of the order.
        /// </summary>
        public int? MaximumId { get; set; }

        /// <summary>
        /// The minimum total for the order.
        /// </summary>
        public decimal? MinimumTotal { get; set; }

        /// <summary>
        /// The maximum total for the order.
        /// </summary>
        public decimal? MaximumTotal { get; set; }

        /// <summary>
        /// Filter orders by customers.
        /// </summary>
        public int? CustomerId { get; set; }

        /// <summary>
        /// Filter orders by the order status.
        /// </summary>
        public int? StatusId { get; set; }

        /// <summary>
        /// Filter orders by the deleted flag.
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Filter orders by payment method.
        /// </summary>
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Retrieve all orders created after a specified date. 
        /// The date should be URL encoded, for example "Mon, 12 Sep 2011 06:40:17 +0000" 
        /// would be "Mon%2C%2012%20Sep%202011%2006%3A40%3A17%20%2B0000"
        /// </summary>
        public DateTime? MinimumDateCreated { get; set; }

        /// <summary>
        /// Retrieve all orders created before a specified date. 
        /// The date should be URL encoded, for example "Mon, 12 Sep 2011 06:40:17 +0000" 
        /// would be "Mon%2C%2012%20Sep%202011%2006%3A40%3A17%20%2B0000"
        /// </summary>
        public DateTime? MaximumDateCreated { get; set; }

        public override void AddFilter(IRestRequest request) {
            base.AddFilter(request);
                
            if (this.MinimumId != null) {
                request.AddParameter("min_id", this.MinimumId, ParameterType.GetOrPost);
            }
            if (this.MaximumId != null) {
                request.AddParameter("max_id", this.MaximumId, ParameterType.GetOrPost);
            }
            if (this.MinimumTotal != null) {
                request.AddParameter("min_total", this.MinimumTotal, ParameterType.GetOrPost);
            }
            if (this.MaximumTotal != null) {
                request.AddParameter("max_total", this.MaximumTotal, ParameterType.GetOrPost);
            }
            if (this.CustomerId != null) {
                request.AddParameter("customer_id", this.CustomerId, ParameterType.GetOrPost);
            }
            if (this.StatusId != null) {
                request.AddParameter("status_id", this.StatusId, ParameterType.GetOrPost);
            }
            if (this.IsDeleted != null) {
                request.AddParameter("is_deleted", this.IsDeleted, ParameterType.GetOrPost);
            }
            if (this.PaymentMethod != null) {
                request.AddParameter("payment_method", this.PaymentMethod, ParameterType.GetOrPost);
            }
            if (this.MinimumDateCreated != null) {
                request.AddParameter("min_date_created", String.Format(RFC2822_DATE_FORMAT, this.MinimumDateCreated), ParameterType.GetOrPost);
            }
            if (this.MaximumDateCreated != null) {
                request.AddParameter("max_date_created", String.Format(RFC2822_DATE_FORMAT, this.MaximumDateCreated), ParameterType.GetOrPost);
            }
        }
    }
}
