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

namespace BigCommerce4Net.Api
{
    public class Configuration
    {
        public string ServiceURL { get; set; }
        public string UserName { get; set; }
        public string UserApiKey { get; set; }
        public string UserAgent { get; set; }
        public int ErrorRetryMax { get; set; }
        public int ErrorRetryDelay { get; set; }
        public int RequestTimeout { get; set; }
        public bool RequestThrottling { get; set; }
        public int RequestThrottlingDelay { get; set; }
        public int MaxPageLimit { get; set; }
        public int RecordsPerPage { get; set; }
        public bool AllowDeletions { get; set; }


        public Configuration() {
            UserAgent = "BigCommerce4Net";
            RequestTimeout = 100000;
            ErrorRetryMax = 5;
            ErrorRetryDelay = 60000;
            RequestThrottling = true;
            RequestThrottlingDelay = 60000;
            MaxPageLimit = 250;
            RecordsPerPage = 250;
            AllowDeletions = false;
        }
        public Configuration(string serviceURL, string userName, string userApiKey)
            : this() {
            this.ServiceURL = serviceURL;
            this.UserName = userName;
            this.UserApiKey = userApiKey;
        }
        
        internal void AreConfigurationSet() {
            if (ServiceURL == null)
                throw new ArgumentNullException("ServiceURL", "ServiceURL cannot be null.");
            if (UserName == null)
                throw new ArgumentNullException("UserName", "UserName cannot be null.");
            if (UserApiKey == null)
                throw new ArgumentNullException("UserApiKey", "UserApiKey cannot be null.");
        }
    }
}
