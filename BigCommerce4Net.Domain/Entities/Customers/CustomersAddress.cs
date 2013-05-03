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
    public class CustomersAddress : EntityBase
    {
        /// <summary>
        /// The ID of the address. 
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// The ID of the customer the address belongs to.
        /// </summary>
        [JsonProperty("customer_id")]
        public virtual int CustomerId { get; set; }
        
        [JsonIgnore]
        public virtual Guid Customer_OId { get; set; }

        /// <summary>
        /// The first name of the addressee.
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("first_name")]
        public virtual string FirstName { get; set; }

        /// <summary>
        /// The last name of the addressee. 
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("last_name")]
        public virtual string LastName { get; set; }

        /// <summary>
        /// The company of the addressee.
        /// 
        /// string(100)
        /// </summary>
        [JsonProperty("company")]
        public virtual string Company { get; set; }

        /// <summary>
        /// The first street line of the address.
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("street_1")]
        public virtual string Street1 { get; set; }

        /// <summary>
        /// The second street line of the address.
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("street_2")]
        public virtual string Street2 { get; set; }

        /// <summary>
        /// The city or suburb of the address.
        /// 
        /// string(50)
        /// </summary>
        [JsonProperty("city")]
        public virtual string City { get; set; }

        /// <summary>
        /// The state of the address.
        /// 
        /// string(50)
        /// </summary>
        [JsonProperty("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// The zip or postcode of the address.
        /// 
        /// string(20)
        /// </summary>
        [JsonProperty("zip")]
        public virtual string ZipCode { get; set; }

        /// <summary>
        /// The country of the address.
        /// 
        /// string(50)
        /// </summary>
        [JsonProperty("country")]
        public virtual string Country { get; set; }

        /// <summary>
        /// The country code of the address.
        /// 
        /// string(50)
        /// </summary>
        [JsonProperty("country_iso2")]
        public virtual string CountryIso2 { get; set; }

        /// <summary>
        /// The phone number of the addressee.
        /// 
        /// string(50)
        /// </summary>
        [JsonProperty("phone")]
        public virtual string Phone { get; set; }
    }
}
