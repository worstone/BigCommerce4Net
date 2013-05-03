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
    public class Customer : EntityBase
    {

        public Customer() {
            Addresses = new List<CustomersAddress>();
        }

        /// <summary>
        /// The ID of the customer.
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// The customers password. This field can only be used to 
        /// assign the customer a new password and can't be retrieved.
        /// 
        /// [string(50)]
        /// </summary>
        [JsonProperty("password")]
        public virtual string Password { get; set; }

        /// <summary>
        /// The company the customer works for.
        /// 
        /// [string(255)]
        /// </summary>
        [JsonProperty("company")]
        public virtual string Company { get; set; }

        /// <summary>
        /// The customers' first name.
        /// 
        /// [string(100)]
        /// </summary>
        [JsonProperty("first_name")]
        public virtual string FirstName { get; set; }

        /// <summary>
        /// The customers' last name.
        /// 
        /// [string(100)]
        /// </summary>
        [JsonProperty("last_name")]
        public virtual string LastName { get; set; }

        /// <summary>
        /// The customers' email.
        /// 
        /// [string(250)]
        /// </summary>
        [JsonProperty("email")]
        public virtual string Email { get; set; }

        /// <summary>
        /// The customers' phone number.
        /// 
        /// [string(50)]
        /// </summary>
        [JsonProperty("phone")]
        public virtual string Phone { get; set; }

        /// <summary>
        /// The date the customer signed up or was created.
        /// </summary>
        [JsonIgnore]
        public virtual DateTime? DateCreated { get; set; }

        [JsonProperty("date_created")]
        public virtual string DateCreatedUT {
            get {
                return DateCreated.DateTimeToString();
            }
            set {
                DateCreated = value.StringToDateTime();
            }
        }

        /// <summary>
        /// The date the customer was last modified.
        /// </summary>
        [JsonIgnore]
        public virtual DateTime? DateModified { get; set; }

        [JsonProperty("date_modified")]
        public virtual string DateModifiedUT {
            get {
                return DateModified.DateTimeToString();
            }
            set {
                DateModified = value.StringToDateTime();
            }
        }

        /// <summary>
        /// The amount of credit the customer has.
        /// 
        /// [decimal(20,4)]
        /// </summary>
        [JsonProperty("store_credit")]
        public virtual decimal StoreCredit { get; set; }

        /// <summary>
        /// The IP address of the customer when they signed up.
        /// 
        /// [string(15)]
        /// </summary>
        [JsonProperty("registration_ip_address")]
        public virtual string RegistrationIpAddress { get; set; }

        /// <summary>
        /// The ID of the customer group the customer belongs to.
        /// </summary>
        [JsonProperty("customer_group_id")]
        public virtual int CustomerGroupId { get; set; }

        /// <summary>
        /// Store owner notes on the customer.
        /// 
        /// [text]
        /// </summary>
        [JsonProperty("notes")]
        public virtual string Notes { get; set; }

        /// <summary>
        /// The addresses in the customers address book. 
        /// See the ?Customer Addresses resource for details on this object.
        /// </summary>
        [JsonProperty("addresses")]
        public virtual Resource ResourceAddresses { get; set; }


        [JsonIgnore]
        public virtual IList<CustomersAddress> Addresses { get; set; }



        public virtual void AddAddresses(CustomersAddress address) {
            Addresses.Add(address);
        }
        public virtual void AddAddresses(List<CustomersAddress> addresses) {
            ((List<CustomersAddress>)Addresses).AddRange(addresses);
        }

        [JsonIgnore]
        public virtual IList<Order> Orders { get; set; }

    }
}
