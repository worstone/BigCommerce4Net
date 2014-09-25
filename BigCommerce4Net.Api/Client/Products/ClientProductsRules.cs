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
using BigCommerce4Net.Domain;
using BigCommerce4Net.Api.ExtensionMethods;
// modified by KD
namespace BigCommerce4Net.Api.ResourceClients
{
    public class ClientProductsRules :
        ClientBase,
        IChildResourceGetUpdateDeleteCreate<ProductsRule>,
        IChildResourceCount
    {
        public ClientProductsRules(Configuration configuration)
            : base(configuration) { }

        public IClientResponse<ItemCount> Count(int productid) {
            string resourceEndpoint = string.Format("/products/{0}/rules/count", productid);
            return base.Count<ItemCount>(resourceEndpoint);
        }
        public IClientResponse<ItemCount> Count(int productid, IFilter filter) {
            string resourceEndpoint = string.Format("/products/{0}/rules/count", productid);
            return base.Count<ItemCount>(resourceEndpoint, filter);
        }
        public IClientResponse<List<ProductsRule>> Get(int productid) {
            string resourceEndpoint = string.Format("/products/{0}/rules", productid);
            return base.GetData<List<ProductsRule>>(resourceEndpoint);
        }
        public IClientResponse<ProductsRule> Get(int productId, int ruleId) {
            string resourceEndpoint = string.Format("/products/{0}/rules/{1}", productId, ruleId);
            return base.GetData<ProductsRule>(resourceEndpoint);
        }
        public IClientResponse<List<ProductsRule>> Get(string resourceEndPoint) {
            return base.GetData<List<ProductsRule>>(resourceEndPoint);
        }
        public IClientResponse<List<ProductsRule>> Get(string resourceEndPoint, IFilter filter) {
            return base.GetData<List<ProductsRule>>(resourceEndPoint, filter);
        }

        public IClientResponse<ProductsRule> Update(int productId, int ruleId, string json) {
            string resourceEndpoint = string.Format("/products/{0}/rules/{1}", productId, ruleId);
            return base.PutData<ProductsRule>(resourceEndpoint, json);
        }
        public IClientResponse<ProductsRule> Update(int productId, int ruleId, object obj) {
            string resourceEndpoint = string.Format("/products/{0}/rules/{1}", productId, ruleId);
            return base.PutData<ProductsRule>(resourceEndpoint, obj.SerializeObject());
        }

        public IClientResponse<ProductsRule> Create(int productId, string json) {
            string resourceEndpoint = string.Format("/products/{0}/rules", productId);
            return base.PostData<ProductsRule>(resourceEndpoint, json);
        }
        public IClientResponse<ProductsRule> Create(int productId, object obj) {
            string resourceEndpoint = string.Format("/products/{0}/rules", productId);
            return base.PostData<ProductsRule>(resourceEndpoint, obj.SerializeObject());
        }

        public IClientResponse<bool> Delete(int productId, int ruleId) {
            string resourceEndpoint = string.Format("/products/{0}/rules/{1}", productId, ruleId);
            return base.DeleteData(resourceEndpoint);
        }

        public IClientResponse<HttpOptions> GetHttpOptions(int productid) {
            string resourceEndpoint = string.Format("/products/{0}/rules", productid);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
        public IClientResponse<HttpOptions> GetHttpOptions(int productId, int ruleId) {
            string resourceEndpoint = string.Format("/products/{0}/rules/{1}", productId, ruleId);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }



        public void Get(IList<Product> items) {
            foreach (var item in items) {
                var response = this.Get(item.Id);

                if (response.RestResponse.StatusCode == System.Net.HttpStatusCode.OK &&
                    response.Data != null && response.Data != null) {
                    foreach (var xitem in response.Data) {
                        item.Rules.Add(xitem);
                    }
                    ShowIdAndApiLimit(item.Id, response.RestResponse);
                } else {
                    StatusCodeLogging(response.RestResponse, GetType());
                }
            }
        }
        public void Get(Product item) {
            var response = this.Get(item.Id);

            if (response.RestResponse.StatusCode == System.Net.HttpStatusCode.OK &&
                response.Data != null && response.Data != null) {
                foreach (var xitem in response.Data) {
                    item.Rules.Add(xitem);
                }
                ShowIdAndApiLimit(item.Id, response.RestResponse);
            } else {
                StatusCodeLogging(response.RestResponse, GetType());
            }
        }

    }
}