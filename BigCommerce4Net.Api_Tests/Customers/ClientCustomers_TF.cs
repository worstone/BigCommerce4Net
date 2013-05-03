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
using BigCommerce4Net.Domain;
using Newtonsoft.Json;


namespace BigCommerce4Net.Api_Tests.Customers
{
    [TestFixture]
    public class ClientCustomers_TF : FixtureBase
    {
        [Test]
        public void Can_Get_Count_Of_Customers() {
            
            var response = Client.Customers.Count();
            
            Assert.AreEqual(response.RestResponse.StatusCode, System.Net.HttpStatusCode.OK);
            Assert.Greater(response.Data.Count, 0);
        }

        [Test]
        public void Can_Get_List_Of_Customers_Using_Filter() {
            
            var filter = new Api.FilterCustomers()
            {
                MinimumId = 2600,
                MaximumId = 2600
            };

            var response = Client.Customers.Get(filter);

            Assert.AreEqual(response.RestResponse.StatusCode, System.Net.HttpStatusCode.OK);
            Assert.AreEqual(response.Data.Count, 1);
            Assert.AreEqual(response.Data[0].Id, 2600);
        }
        [Test]
        public void Can_Customer_StoreCredit_Be_Updated() {

            decimal storecredit = 8000.00M;

            var updatedata = new { store_credit = storecredit };

            string json = JsonConvert.SerializeObject(updatedata, Formatting.None);

            var response = Client.Customers.Update(TEST_CUSTOMER_ID, json);

            Assert.AreNotEqual(null, response.Data);
            Assert.AreEqual(TEST_CUSTOMER_ID, response.Data.Id);
            Assert.AreEqual(storecredit, response.Data.StoreCredit);
        }
        [Test]
        public void Can_Customer_StoreCredit_Be_Updated_Then_Get_Will_IfModifiedSince() {
            
            var response = Client.Utilities.GetTime();
            var date = response.Data.CurrentDateTime;
            var serverdatetime = string.Format("{0:r}", date);
            
            decimal storecredit = 8000.00M;

            var updatedata = new { store_credit = storecredit };

            string json = JsonConvert.SerializeObject(updatedata, Formatting.None);

            var response1 = Client.Customers.Update(TEST_CUSTOMER_ID, json);

            Assert.AreNotEqual(null, response.Data);
            Assert.AreEqual(TEST_CUSTOMER_ID, response1.Data.Id);
            Assert.AreEqual(storecredit, response1.Data.StoreCredit);

            var filter = new Api.FilterCustomers();
            filter.IfModifiedSince = ((DateTime)date).AddMinutes(-10);

            var response2 = Client.Customers.Count(filter);
            Assert.Greater(0, response2.Data.Count);
        }

        [Test]
        public void Check_Customer_Modified_Since() {

            IEntity order = new Domain.Order() {
                Id = 1,
                PaymentStatus = PaymentStatus.PartiallyRefunded
            };
            

            string json = JsonConvert.SerializeObject(order, Formatting.Indented);


            //var client = new Client(this.ApiConfig);
            //var response1 = client.Utilities.GetTime();
            //var date = response1.Data.Item.CurrentTime;

            //var filter = new FilterCustomers();
            //filter.IfModifiedSince = ((DateTime)date).AddMinutes(-10);
            //var response2 = client.Customers.Get(filter);
            //var response3 = client.Customers.Count(filter);

        }
        [Test]
        public void Can_Get_GetHttpOptions() {

            var response = Client.Customers.GetHttpOptions();
            Assert.AreEqual(response.RestResponse.StatusCode, System.Net.HttpStatusCode.OK);
            Assert.AreNotEqual(response.Data, null);
        }
        
    }
}