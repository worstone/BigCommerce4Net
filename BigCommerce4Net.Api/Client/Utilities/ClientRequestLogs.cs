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
using BigCommerce4Net.Domain;

namespace BigCommerce4Net.Api.ResourceClients
{
    public class ClientRequestLogs : ClientBase
    {
        public ClientRequestLogs(Configuration configuration)
            :base(configuration)
        {}

        public IClientResponse<List<RequestLog>> Get() {
            string resourceEndpoint = "/requestlogs";
            return base.GetData<List<RequestLog>>(resourceEndpoint);
        }
        public IClientResponse<RequestLog> Get(int requestLogId) {
            string resourceEndpoint = string.Format("/requestlogs/{0}", requestLogId);
            return base.GetData<RequestLog>(resourceEndpoint);
        }
        public IClientResponse<List<RequestLog>> Get(string resourceEndPoint) {
            return base.GetData<List<RequestLog>>(resourceEndPoint);
        }

        public IClientResponse<HttpOptions> GetHttpOptions() {
            string resourceEndpoint = string.Format("/requestlogs");
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
        public IClientResponse<HttpOptions> GetHttpOptions(int requestLogId) {
            string resourceEndpoint = string.Format("/requestlogs/{0}", requestLogId);
            return base.GetHttpOptionsData<HttpOptions>(resourceEndpoint);
        }
    }
}
