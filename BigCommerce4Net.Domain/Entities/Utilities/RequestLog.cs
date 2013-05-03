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
using Newtonsoft.Json;


namespace BigCommerce4Net.Domain
{
    public class RequestLog
    {
        /// <summary>
        /// The id of the request log entry.
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// The time the request was logged.
        /// </summary>
        [JsonProperty("request_time")]
        public virtual string RequestTime { get; set; }

        /// <summary>
        /// The id of the user which was authenticated for this request. 
        /// This field will be NULL if no user information was available
        /// (such as authentication was not provided or authentication failed).
        /// </summary>
        [JsonProperty("user_id")]
        public virtual string UserId { get; set; }

        /// <summary>
        /// The API version which was used for this request. This field will 
        /// be NULL if no version information was available (such as an invalid URL).
        /// 
        /// string(10)
        /// </summary>
        [JsonProperty("version")]
        public virtual string Version { get; set; }

        /// <summary>
        /// The resource URL, relative to the API version, which was used for this request. 
        /// If version is NULL then this will be the invalid API-relative URL instead 
        /// of version-relative URL.
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("resource")]
        public virtual string Resource { get; set; }

        /// <summary>
        /// The HTTP response status returned for this request.
        /// </summary>
        [JsonProperty("status")]
        public virtual int Status { get; set; }

        /// <summary>
        /// The HTTP method used by the request.
        /// 
        /// string(50)
        /// </summary>
        [JsonProperty("method")]
        public virtual string Method { get; set; }

        /// <summary>
        /// The query string provided in the HTTP request, if any.
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("query_string")]
        public virtual string QueryString { get; set; }

        /// <summary>
        /// The User-Agent header specified by the software making the 
        /// HTTP request, if any. If none was provided this field will be NULL. 
        /// This may be a blank string if a blank user-agent header was specified.
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("user_agent")]
        public virtual string UserAgent { get; set; }


    }
}
