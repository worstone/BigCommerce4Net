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
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace BigCommerce4Net.Domain
{
    public class Country : EntityBase
    {
        /// <summary>
        /// The ID of the country.
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// The name of the country.
        /// 
        /// [string(255)]
        /// </summary>
        [JsonProperty("country")]
        public virtual string CountryName { get; set; }

        /// <summary>
        /// The 2 character ISO country code.
        /// 
        /// [string(2)]
        /// </summary>
        [JsonProperty("country_iso2")]
        public virtual string CountryIso2 { get; set; }


        /// <summary>
        /// The 3 character ISO country code.
        /// 
        /// [string(3)]
        /// </summary>
        [JsonProperty("country_iso3")]
        public virtual string CountryIso3 { get; set; }

    }
}
