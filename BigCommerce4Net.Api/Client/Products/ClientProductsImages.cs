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
    public class ClientProductsImages : 
        ClientBase, 
        IChildResourceGetUpdateDeleteCreate<ProductsImage>,
        IChildResourceCount
    {
        public ClientProductsImages(Configuration configuration)
            : base(configuration) { }

        public IClientResponse<ItemCount> Count(int productid) {
            string resourceEndpoint = string.Format("/products/{0}/images/count", productid);
            return base.Count<ItemCount>(resourceEndpoint);
        }
        public IClientResponse<ItemCount> Count(int productid, IFilter filter) {
            string resourceEndpoint = string.Format("/products/{0}/images/count", productid);
            return base.Count<ItemCount>(resourceEndpoint, filter);
        }
        public IClientResponse<List<ProductsImage>> Get() {
            string resourceEndpoint = string.Format("/products/images");
            return base.GetData<List<ProductsImage>>(resourceEndpoint);
        }
        public IClientResponse<List<ProductsImage>> Get(IFilter filter) {
            string resourceEndpoint = string.Format("/products/images");
            return base.GetData<List<ProductsImage>>(resourceEndpoint, filter);
        }
        public IClientResponse<List<ProductsImage>> Get(int productid) {
            string resourceEndpoint = string.Format("/products/{0}/images", productid);
            return base.GetData<List<ProductsImage>>(resourceEndpoint);
        }
        public IClientResponse<ProductsImage> Get(int productid, int imageid) {
            string resourceEndpoint = string.Format("/products/{0}/images/{1}", productid, imageid);
            return base.GetData<ProductsImage>(resourceEndpoint);
        }
        public IClientResponse<List<ProductsImage>> Get(string resourceEndPoint) {
            return base.GetData<List<ProductsImage>>(resourceEndPoint);
        }
        public IClientResponse<List<ProductsImage>> Get(string resourceEndPoint, IFilter filter) {
            return base.GetData<List<ProductsImage>>(resourceEndPoint, filter);
        }

        public IClientResponse<ProductsImage> Update(int productid, int imageid, string json) {
            string resourceEndpoint = string.Format("/products/{0}/images/{1}", productid, imageid);
            return base.PutData<ProductsImage>(resourceEndpoint, json);
        }
        public IClientResponse<ProductsImage> Update(int productid, int imageid, object obj) {
            string resourceEndpoint = string.Format("/products/{0}/images/{1}", productid, imageid);
            return base.PutData<ProductsImage>(resourceEndpoint, obj.SerializeObject());
        }

        public IClientResponse<ProductsImage> Create(int id, string json) {
            string resourceEndpoint = string.Format("/products/{0}/images", id);
            return base.PostData<ProductsImage>(resourceEndpoint, json);
        }
        public IClientResponse<ProductsImage> Create(int id, object obj) {
            string resourceEndpoint = string.Format("/products/{0}/images", id);
            return base.PostData<ProductsImage>(resourceEndpoint, obj.SerializeObject());
        }

        public IClientResponse<bool> Delete(int productid, int imageid) {
            string resourceEndpoint = string.Format("/products/{0}/images/{1}", productid, imageid);
            return base.DeleteData(resourceEndpoint);
        }

        public IClientResponse<HttpOptions> GetHttpOptions(int productid) {
            string resourceEndpoint = string.Format("/products/{0}/images", productid);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
        public IClientResponse<HttpOptions> GetHttpOptions(int productid, int imageid) {
            string resourceEndpoint = string.Format("/products/{0}/images/{1}", productid, imageid); 
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }

        public void Get(IList<Product> items) {
            foreach (var item in items) {
                var response = this.Get(item.Id);

                if (response.RestResponse.StatusCode == System.Net.HttpStatusCode.OK &&
                    response.Data != null && response.Data != null) {
                    foreach (var xitem in response.Data) {
                        item.Images.Add(xitem);
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
                    item.Images.Add(xitem);
                }
                ShowIdAndApiLimit(item.Id, response.RestResponse);
            } else {
                StatusCodeLogging(response.RestResponse, GetType());
            }
        }

    }
}
