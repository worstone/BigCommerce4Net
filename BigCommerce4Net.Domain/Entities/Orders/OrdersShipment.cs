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
    public class OrdersShipment : EntityBase
    {
        /// <summary>
        /// The ID of the shipment.
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// The ID of the customer that placed the order.
        /// </summary>
        [JsonProperty("customer_id")]
        public virtual int CustomerId { get; set; }

        /// <summary>
        /// The date the shipment was created.
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
        /// The tracking number for the shipment.
        /// 
        /// string(50)
        /// </summary>
        [JsonProperty("tracking_number")]
        public virtual string TrackingNumber { get; set; }

        /// <summary>
        /// The name of the shipping method used.
        /// 
        /// string(100)
        /// </summary>
        [JsonProperty("shipping_method")]
        public virtual string ShippingMethod { get; set; }

        /// <summary>
        /// The ID of the order this shipment is associated with.
        /// </summary>
        [JsonProperty("order_id")]
        public virtual int OrderId { get; set; }


        // TODO: Post that BC is not even sending down this element 12-22-12
        // I will keep it in there just making sure that it set to
        // SqlDateTime.MinValue so that it will post to TSQL
        // SqlDateTime.MinValue set in the Constructor
        /// <summary>
        /// The date the order was placed.
        /// </summary>
        [JsonIgnore]
        public virtual DateTime? OrderDate { get; set; }

        [JsonProperty("order_date")]
        public virtual string OrderDateUT
        {
            get
            {
                return OrderDate.DateTimeToString();
            }
            set
            {
                OrderDate = value.StringToDateTime();
            }
        }

        /// <summary>
        /// Any comments the store owner has added regarding the shipment.
        /// 
        /// text
        /// </summary>
        [JsonProperty("comments")]
        public virtual string Comments { get; set; }

        /// <summary>
        /// The ID of the order address this shipment is associated with.
        /// </summary>
        [JsonProperty("order_address_id")]
        public virtual int OrderAddressId { get; set; }

        /// <summary>
        /// The billing address of the order. 
        /// </summary>
        [JsonProperty("billing_address")]
        public virtual Address BillingAddress { get; set; }

        /// <summary>
        /// The shipping address of the shipment. 
        /// </summary>
        [JsonProperty("shipping_address")]
        public virtual Address ShippingAddress { get; set; }

        /// <summary>
        /// The items in the shipment. 
        /// </summary>
        [JsonProperty("items")]
        public virtual IList<OrdersShipmentItem> ShipmentItems { get; set; }
    }
}
