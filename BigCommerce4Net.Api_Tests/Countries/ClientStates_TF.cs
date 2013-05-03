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

namespace BigCommerce4Net.Api_Tests.Countries
{
    [TestFixture]
    public class ClientStates_TF : FixtureBase
    {
        [Test]
        public void Can_Get_Count() {

            var response = Client.States.Count();

            Assert.AreEqual(response.RestResponse.StatusCode, System.Net.HttpStatusCode.OK);
            Assert.Greater(response.Data.Count, 0);
        }
        [Test]
        public void Can_Get_All_States_Default_Paging() {

            var response = Client.States.Get();

            Assert.AreEqual(response.RestResponse.StatusCode, System.Net.HttpStatusCode.OK);
            Assert.AreEqual(response.Data.Count, 50);
        }

        [Test]
        public void Can_Get_All_States_With_Paging() {

            var response = Client.States.GetList();

            Assert.Greater(response.Count, 50);
        }
        [Test]
        public void Can_Get_All_States_With_Limit_Parameter_Paging() {
            var filter = new Api.FilterStates {
                Limit = 200
            };

            var response = Client.States.Get(filter);
            Assert.AreEqual(response.RestResponse.StatusCode, System.Net.HttpStatusCode.OK);
            Assert.NotNull(response.Data);
            Assert.AreEqual(response.Data.Count, 200);
        }
        [Test]
        public void Can_Get_One_State_By_Id() {

            var response = Client.States.Get(TEST_STATE_ID);
            Assert.AreEqual(response.RestResponse.StatusCode, System.Net.HttpStatusCode.OK);
            Assert.NotNull(response.Data);
            Assert.AreEqual(response.Data.Id, TEST_STATE_ID);
        }

        [Test]
        public void Can_Get_States_By_Countries_Id() {

            var response = Client.States.GetStatesInCountry(TEST_COUNTRY_ID);

            Assert.AreEqual(response.RestResponse.StatusCode, System.Net.HttpStatusCode.OK);
            Assert.NotNull(response.Data);
            Assert.Greater(response.Data.Count, 0);
        }
        [Test]
        public void Can_Get_GetHttpOptions() {

            var response = Client.States.GetHttpOptions();
            Assert.AreEqual(response.RestResponse.StatusCode, System.Net.HttpStatusCode.OK);
            Assert.NotNull(response.Data);
        }
    }
}
