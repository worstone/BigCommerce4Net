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

namespace BigCommerce4Net.Api.ResourceClients
{
    public class ClientProductsSkus :
        ClientBase,
        IChildResourceGetUpdateDeleteCreate<ProductsSku>,
        IChildResourceCount
    {
        public ClientProductsSkus(Configuration configuration)
            : base(configuration) { }

        public IClientResponse<ItemCount> Count(int productid) {
            string resourceEndpoint = string.Format("/products/{0}/skus/count", productid);
            return base.Count<ItemCount>(resourceEndpoint);
        }
        public IClientResponse<ItemCount> Count(int productid, IFilter filter) {
            string resourceEndpoint = string.Format("/products/{0}/skus/count", productid);
            return base.Count<ItemCount>(resourceEndpoint, filter);
        }
        public IClientResponse<List<ProductsSku>> Get(int productid) {
            string resourceEndpoint = string.Format("/products/{0}/skus", productid);
            return base.GetData<List<ProductsSku>>(resourceEndpoint);
        }
        public IClientResponse<ProductsSku> Get(int productId, int skuId) {
            string resourceEndpoint = string.Format("/products/{0}/skus/{1}", productId, skuId);
            return base.GetData<ProductsSku>(resourceEndpoint);
        }
        public IClientResponse<List<ProductsSku>> Get(string resourceEndPoint) {
            return base.GetData<List<ProductsSku>>(resourceEndPoint);
        }
        public IClientResponse<List<ProductsSku>> Get(string resourceEndPoint, IFilter filter) {
            return base.GetData<List<ProductsSku>>(resourceEndPoint, filter);
        }

        public IClientResponse<ProductsSku> Update(int productId, int skuId, string json) {
            string resourceEndpoint = string.Format("/products/{0}/skus/{1}", productId, skuId);
            return base.PutData<ProductsSku>(resourceEndpoint, json);
        }
        public IClientResponse<ProductsSku> Update(int productId, int skuId, object obj) {
            string resourceEndpoint = string.Format("/products/{0}/skus/{1}", productId, skuId);
            return base.PutData<ProductsSku>(resourceEndpoint, obj.SerializeObject());
        }

        public IClientResponse<ProductsSku> Create(int productId, string json) {
            string resourceEndpoint = string.Format("/products/{0}/skus", productId);
            return base.PostData<ProductsSku>(resourceEndpoint, json);
        }
        public IClientResponse<ProductsSku> Create(int productId, object obj) {
            string resourceEndpoint = string.Format("/products/{0}/skus", productId);
            return base.PostData<ProductsSku>(resourceEndpoint, obj.SerializeObject());
        }

        public IClientResponse<bool> Delete(int productId, int skuId) {
            string resourceEndpoint = string.Format("/products/{0}/skus/{1}", productId, skuId);
            return base.DeleteData(resourceEndpoint);
        }

        public IClientResponse<HttpOptions> GetHttpOptions(int productid) {
            string resourceEndpoint = string.Format("/products/{0}/skus", productid);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
        public IClientResponse<HttpOptions> GetHttpOptions(int productId, int skuId) {
            string resourceEndpoint = string.Format("/products/{0}/skus/{1}", productId, skuId);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }




        public void Get(IList<Product> items) {
            foreach (var item in items) {
                var response = this.Get(item.Id);

                if (response.RestResponse.StatusCode == System.Net.HttpStatusCode.OK &&
                    response.Data != null && response.Data != null) {
                    foreach (var xitem in response.Data) {
                        item.Skus.Add(xitem);
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
                    item.Skus.Add(xitem);
                }
                ShowIdAndApiLimit(item.Id, response.RestResponse);
            } else {
                StatusCodeLogging(response.RestResponse, GetType());
            }
        }

    }
}
