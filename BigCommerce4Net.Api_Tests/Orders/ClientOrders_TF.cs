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
using NUnit.Framework;
using Api = BigCommerce4Net.Api;
using Domain = BigCommerce4Net.Domain;

namespace BigCommerce4Net.Api_Tests.Orders
{
    [TestFixture]
    public class ClientOrders_TF : FixtureBase
    {
        [Test]
        public void Can_Get_Count() {

            var response = Client.Orders.Count();

            Assert.AreEqual(response.RestResponse.StatusCode, System.Net.HttpStatusCode.OK);
            Assert.Greater(response.Data.Count, 0);
        }

        [Test]
        public void Can_Get_Filtered() {

            var filter = new Api.FilterOrders() {
                MaximumId = 4000
            };


            var response = Client.Orders.Get(filter);

            Assert.AreEqual(response.RestResponse.StatusCode, System.Net.HttpStatusCode.OK);
            Assert.Greater(response.Data.Count, 0);
        }

        [Test]
        public void Can_Get_Filtered_RecordPaging() {

            var filter = new Api.FilterOrders() {
                MinimumId = 3000
            };
            var response_count = Client.Orders.Count(filter);
            var response_list = Client.Orders.GetList(filter);

            Assert.AreEqual(response_list.Count, response_count.Data.Count);
        }

        [Test]
        public void Can_Get_Non_Filtered_RecordPaging() {

            var response_count = Client.Orders.Count();
            var response_list = Client.Orders.GetList();

            Assert.AreEqual(response_list.Count, response_count.Data.Count);
        }
        [Test]
        public void Can_Get_ShippingAddresses_And_Add() {

            var response_order = Client.Orders.Get(200);

            Client.OrdersShippingAddresses.Get(response_order.Data);

            Assert.Greater(response_order.Data.ShippingAddresses.Count, 0);
            Assert.AreEqual(response_order.Data.Id, response_order.Data.ShippingAddresses[0].OrderId);

        }
         [Test]
        public void Can_Get_OrdersProducts_And_Add() {

            var response_order = Client.Orders.Get(200);

            Client.OrdersProducts.Get(response_order.Data);

            Assert.Greater(response_order.Data.Products.Count, 0);
            Assert.AreEqual(response_order.Data.Id, response_order.Data.Products[0].OrderId);

        }
         [Test]
         public void Can_Get_GetHttpOptions() {

             var response = Client.Orders.GetHttpOptions();
             Assert.AreEqual(response.RestResponse.StatusCode, System.Net.HttpStatusCode.OK);
             Assert.AreNotEqual(response.Data, null);
         }

    }
}