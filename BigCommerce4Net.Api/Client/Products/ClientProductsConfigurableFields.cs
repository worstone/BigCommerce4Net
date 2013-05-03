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

namespace BigCommerce4Net.Api.ResourceClients
{
    public class ClientProductsConfigurableFields : 
        ClientBase, 
        IChildResourceGet<ProductsConfigurableField>,
        IChildResourceCount
    {
        public ClientProductsConfigurableFields(Configuration configuration)
            : base(configuration) { }

        public IClientResponse<ItemCount> Count(int productid) {
            string resourceEndpoint = string.Format("/products/{0}/configurablefields/count", productid);
            return base.Count<ItemCount>(resourceEndpoint);
        }
        public IClientResponse<ItemCount> Count(int productid, IFilter filter) {
            string resourceEndpoint = string.Format("/products/{0}/configurablefields/count", productid);
            return base.Count<ItemCount>(resourceEndpoint, filter);
        }
        public IClientResponse<List<ProductsConfigurableField>> Get(int productid) {
            string resourceEndpoint = string.Format("/products/{0}/configurablefields", productid);
            return base.GetData<List<ProductsConfigurableField>>(resourceEndpoint);
        }
        public IClientResponse<ProductsConfigurableField> Get(int productid, int fieldId) {
            string resourceEndpoint = string.Format("/products/{0}/configurablefields/{1}", productid, fieldId);
            return base.GetData<ProductsConfigurableField>(resourceEndpoint);
        }
        public IClientResponse<List<ProductsConfigurableField>> Get(string resourceEndPoint) {
            return base.GetData<List<ProductsConfigurableField>>(resourceEndPoint);
        }
        public IClientResponse<List<ProductsConfigurableField>> Get(string resourceEndPoint, IFilter filter) {
            return base.GetData<List<ProductsConfigurableField>>(resourceEndPoint, filter);
        }

        public IClientResponse<HttpOptions> GetHttpOptions(int productid) {
            string resourceEndpoint = string.Format("/products/{0}/configurablefields", productid);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
        public IClientResponse<HttpOptions> GetHttpOptions(int productid, int fieldId) {
            string resourceEndpoint = string.Format("/products/{0}/configurablefields/{1}", productid, fieldId);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }


        public void Get(IList<Product> items) {
            foreach (var item in items) {
                var response = this.Get(item.Id);

                if (response.RestResponse.StatusCode == System.Net.HttpStatusCode.OK &&
                    response.Data != null && response.Data != null) {
                    foreach (var xitem in response.Data) {
                        item.ConfigurableFields.Add(xitem);
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
                    item.ConfigurableFields.Add(xitem);
                }
                ShowIdAndApiLimit(item.Id, response.RestResponse);
            } else {
                StatusCodeLogging(response.RestResponse, GetType());
            }
        }

    }
}
