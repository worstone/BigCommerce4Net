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
using BigCommerce4Net.Api.ResourceClients;

namespace BigCommerce4Net.Api
{
    public class Client
    {
        private readonly Configuration _Configuration;

        public Client(Configuration configuration) {
            _Configuration = configuration;
        }

        private ClientProducts _Products;
        public ClientProducts Products {
            get {
                if (_Products == null)
                    _Products = new ClientProducts(_Configuration);
                return _Products;
            }
        }
        private ClientOrders _Orders;
        public ClientOrders Orders {
            get {
                if (_Orders == null)
                    _Orders = new ClientOrders(_Configuration);
                return _Orders;
            }
        }
        private ClientOrdersProducts _OrdersProducts;
        public ClientOrdersProducts OrdersProducts {
            get {
                if (_OrdersProducts == null)
                    _OrdersProducts = new ClientOrdersProducts(_Configuration);
                return _OrdersProducts;
            }
        }
        private ClientOrdersShipments _OrdersShipments;
        public ClientOrdersShipments OrdersShipments {
            get {
                if (_OrdersShipments == null)
                    _OrdersShipments = new ClientOrdersShipments(_Configuration);
                return _OrdersShipments;
            }
        }
        private ClientOrdersCoupons _OrdersCoupons;
        public ClientOrdersCoupons OrdersCoupons {
            get {
                if (_OrdersCoupons == null)
                    _OrdersCoupons = new ClientOrdersCoupons(_Configuration);
                return _OrdersCoupons;
            }
        }
        private ClientOrdersShippingAddresses _OrdersShippingAddresses;
        public ClientOrdersShippingAddresses OrdersShippingAddresses {
            get {
                if (_OrdersShippingAddresses == null)
                    _OrdersShippingAddresses = new ClientOrdersShippingAddresses(_Configuration);
                return _OrdersShippingAddresses;
            }
        }
        private ClientUtilities _Utilities;
        public ClientUtilities Utilities {
            get {
                if (_Utilities == null)
                    _Utilities = new ClientUtilities(_Configuration);
                return _Utilities;
            }
        }
        private ClientCustomers _Customers;
        public ClientCustomers Customers {
            get {
                if (_Customers == null)
                    _Customers = new ClientCustomers(_Configuration);
                return _Customers;
            }
        }
        private ClientCustomersAddresses _CustomersAddresses;
        public ClientCustomersAddresses CustomersAddresses {
            get {
                if (_CustomersAddresses == null)
                    _CustomersAddresses = new ClientCustomersAddresses(_Configuration);
                return _CustomersAddresses;
            }
        }
        private ClientBrands _Brands;
        public ClientBrands Brands {
            get {
                if (_Brands == null)
                    _Brands = new ClientBrands(_Configuration);
                return _Brands;
            }
        }
        private ClientCategories _Categories;
        public ClientCategories Categories {
            get {
                if (_Categories == null)
                    _Categories = new ClientCategories(_Configuration);
                return _Categories;
            }
        }
        private ClientOrderStatuses _OrderStatuses;
        public ClientOrderStatuses OrderStatuses {
            get {
                if (_OrderStatuses == null)
                    _OrderStatuses = new ClientOrderStatuses(_Configuration);
                return _OrderStatuses;
            }
        }
        private ClientRequestLogs _RequestLogs;
        public ClientRequestLogs RequestLogs {
            get {
                if (_RequestLogs == null)
                    _RequestLogs = new ClientRequestLogs(_Configuration);
                return _RequestLogs;
            }
        }
        private ClientStates _States;
        public ClientStates States {
            get {
                if (_States == null)
                    _States = new ClientStates(_Configuration);
                return _States;
            }
        }
        private ClientCountries _Countries;
        public ClientCountries Countries {
            get {
                if (_Countries == null)
                    _Countries = new ClientCountries(_Configuration);
                return _Countries;
            }
        }
        private ClientProductsConfigurableFields _ProductsConfigurableFields;
        public ClientProductsConfigurableFields ProductsConfigurableFields {
            get {
                if (_ProductsConfigurableFields == null)
                    _ProductsConfigurableFields = new ClientProductsConfigurableFields(_Configuration);
                return _ProductsConfigurableFields;
            }
        }
        private ClientProductsCustomFields _ProductsCustomFields;
        public ClientProductsCustomFields ProductsCustomFields {
            get {
                if (_ProductsCustomFields == null)
                    _ProductsCustomFields = new ClientProductsCustomFields(_Configuration);
                return _ProductsCustomFields;
            }
        }
        private ClientProductsDiscountRules _ProductsDiscountRules;
        public ClientProductsDiscountRules ProductsDiscountRules {
            get {
                if (_ProductsDiscountRules == null)
                    _ProductsDiscountRules = new ClientProductsDiscountRules(_Configuration);
                return _ProductsDiscountRules;
            }
        }
        private ClientProductsImages _ProductsImages;
        public ClientProductsImages ProductsImages {
            get {
                if (_ProductsImages == null)
                    _ProductsImages = new ClientProductsImages(_Configuration);
                return _ProductsImages;
            }
        }
        private ClientProductsOptions _ProductsOptions;
        public ClientProductsOptions ProductsOptions {
            get {
                if (_ProductsOptions == null)
                    _ProductsOptions = new ClientProductsOptions(_Configuration);
                return _ProductsOptions;
            }
        }
        private ClientProductsRules _ProductsRules;
        public ClientProductsRules ProductsRules {
            get {
                if (_ProductsRules == null)
                    _ProductsRules = new ClientProductsRules(_Configuration);
                return _ProductsRules;
            }
        }
        private ClientProductsSkus _ProductsSkus;
        public ClientProductsSkus ProductsSkus {
            get {
                if (_ProductsSkus == null)
                    _ProductsSkus = new ClientProductsSkus(_Configuration);
                return _ProductsSkus;
            }
        }
        private ClientProductsVideo _ProductsVideo;
        public ClientProductsVideo ProductsVideo {
            get {
                if (_ProductsVideo == null)
                    _ProductsVideo = new ClientProductsVideo(_Configuration);
                return _ProductsVideo;
            }
        }
        private ClientOptions _Options;
        public ClientOptions Options {
            get {
                if (_Options == null)
                    _Options = new ClientOptions(_Configuration);
                return _Options;
            }
        }
        private ClientOptionSet _OptionSet;
        public ClientOptionSet OptionSet {
            get {
                if (_OptionSet == null)
                    _OptionSet = new ClientOptionSet(_Configuration);
                return _OptionSet;
            }
        }
        private ClientOptionSetOption _OptionSetOption;
        public ClientOptionSetOption OptionSetOption {
            get {
                if (_OptionSetOption == null)
                    _OptionSetOption = new ClientOptionSetOption(_Configuration);
                return _OptionSetOption;
            }
        }
        private ClientOptionValue _OptionValue;
        public ClientOptionValue OptionValue {
            get {
                if (_OptionValue == null)
                    _OptionValue = new ClientOptionValue(_Configuration);
                return _OptionValue;
            }
        }
        private ClientCoupons _Coupons;
        public ClientCoupons Coupons {
            get {
                if (_Coupons == null)
                    _Coupons = new ClientCoupons(_Configuration);
                return _Coupons;
            }
        }

        private ClientShippingMethods _ShippingMethods;
        public ClientShippingMethods ShippingMethods {
            get {
                if (_ShippingMethods == null)
                    _ShippingMethods = new ClientShippingMethods(_Configuration);
                return _ShippingMethods;
            }
        }

    }
}
