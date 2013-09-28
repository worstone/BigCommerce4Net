BigCommerce4Net
===============

BigCommerce API REST Client for .NET


Requirements
------------

- .NET Framwork 4 - http://msdn.microsoft.com/en-US/vstudio/aa496123.aspx
- log4net - http://logging.apache.org/log4net/
- Newtonsoft.Json - http://james.newtonking.com/projects/json-net.aspx
- NUnit - http://nunit.org/
- RestSharp - http://restsharp.org/

To connect to the API, you need the following credentials:

- Secure URL pointing to a Bigcommerce store (https://www.yourstore.com/api/v2
- Username 
- API key for the user

Namespaces
---------

```
using BigCommerce4Net.Api;
using BigCommerce4Net.Domain;
```

Basic Configuration
-------------

```
Api_Configuration = new Api.Configuration() {
                ServiceURL = "https://--yourstore--/api/v2",
                UserName = "--Your User Name--",
                UserApiKey = "--Your Api Key--",
                MaxPageLimit = 250,
                AllowDeletions = true // Is false by default, must be true to allow deletions
            };
            
var Client = new Api.Client(Api_Configuration);
            
```

Accessing Store Data
-------------

```
var response = Client.Countries.Count();
            Assert.AreEqual(response.RestResponse.StatusCode, System.Net.HttpStatusCode.OK);
            Assert.Greater(response.Data.Count, 0);
```	
```		
		
var response = Client.Countries.Get();
            Assert.AreEqual(response.RestResponse.StatusCode, System.Net.HttpStatusCode.OK);
            Assert.AreEqual(response.Data.Count, 50);			
```
```	
			
var filter = new Api.FilterCountries
            {
                Limit = 200
            };

            var response = Client.Countries.Get(filter);
            Assert.AreEqual(response.RestResponse.StatusCode, System.Net.HttpStatusCode.OK);
            Assert.AreEqual(response.Data.Count, 200);			
```

Updating Store Data
-------------

```	
			
var updatedata = new { store_credit = 2500M };

            var response = Client.Customers.Update(100, updatedata);	
	    Assert.AreNotEqual(null, response.Data);
            Assert.AreEqual(100, response.Data.Id);
            Assert.AreEqual(2500M, response.Data.StoreCredit);			
```

Create Store Data
-------------
```	
var customer = new { 
			first_name = "FirstName",
			last_name = "LastName",
			email = "email@email.com"
		};

var response = Client.Customers.Create(customer);
Assert.AreEqual(response.RestResponse.StatusCode, System.Net.HttpStatusCode.Created);			
Assert.AreNotEqual(null, response.Data);
Assert.AreEqual("FirstName", response.Data.FirstName);
Assert.AreEqual("LastName", response.Data.LastName);	
Assert.AreEqual(""email@email.com"", response.Data.Email);			
			
```

Delete Store Data
-------------
Note: Configuration.AllowDeletions must be true

```
var response = Client.Customers.Delete(100);
Assert.AreEqual(response.Data, true);
Assert.AreEqual(response.RestResponse.StatusCode, System.Net.HttpStatusCode.NoContent );

```

License
-------------

Copyright 2013 Ken Worst - R.C. Worst & Company Inc.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

  http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License. 
