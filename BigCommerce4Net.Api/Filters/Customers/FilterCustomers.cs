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
    public class FilterCustomers : Filter, IFilter
    {
        /// <summary>
        /// The minimum id of the customer.
        /// </summary>
        public int? MinimumId { get; set; }

        /// <summary>
        /// The maximum id of the customer.
        /// </summary>
        public int? MaximumId { get; set; }

        /// <summary>
        /// Filter by first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Filter by last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Filter by company.
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// Filter by email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Filter by phone number.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Filter by store credit.
        /// </summary>
        public decimal? StoreCredit { get; set; }

        /// <summary>
        /// Filter by customer group.
        /// </summary>
        public int? CustomerGroupId { get; set; }

        /// <summary>
        /// The minimum creation date of the customer.
        /// </summary>
        public DateTime? MinDateCreated { get; set; }

        /// <summary>
        /// The maximum creation date of the customer.
        /// </summary>
        public DateTime? MaxDateCreated { get; set; }

        public override void AddFilter(IRestRequest request) {
            base.AddFilter(request);

            if (this.MinimumId != null) {
                request.AddParameter("min_id", this.MinimumId, ParameterType.GetOrPost);
            }
            if (this.MaximumId != null) {
                request.AddParameter("max_id", this.MaximumId, ParameterType.GetOrPost);
            }
            if (this.FirstName != null) {
                request.AddParameter("first_name", this.FirstName, ParameterType.GetOrPost);
            }
            if (this.LastName != null) {
                request.AddParameter("last_name", this.LastName, ParameterType.GetOrPost);
            }
            if (this.Company != null) {
                request.AddParameter("company", this.Company, ParameterType.GetOrPost);
            }
            if (this.Email != null) {
                request.AddParameter("email", this.Email, ParameterType.GetOrPost);
            }
            if (this.Phone != null) {
                request.AddParameter("phone", this.Phone, ParameterType.GetOrPost);
            }
            if (this.StoreCredit != null) {
                request.AddParameter("store_credit", this.StoreCredit, ParameterType.GetOrPost);
            }
            if (this.CustomerGroupId != null) {
                request.AddParameter("customer_group_id", this.CustomerGroupId, ParameterType.GetOrPost);
            }
            if (this.MinDateCreated != null) {
                request.AddParameter("min_date_created", String.Format(RFC2822_DATE_FORMAT, this.MinDateCreated), ParameterType.GetOrPost);
            }
            if (this.MaxDateCreated != null) {
                request.AddParameter("max_date_created", String.Format(RFC2822_DATE_FORMAT, this.MaxDateCreated), ParameterType.GetOrPost);
            }
        }
    }
}
