﻿// Copyright (c) 2018 Alachisoft
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alachisoft.NCache.Common.Configuration;
using Alachisoft.NCache.Integrations.EntityFramework.Config;

namespace Alachisoft.NCache.Integrations.EntityFramework.Caching.Config
{
    [ConfigurationRoot("query")]
    public sealed class QueryPolicyElement : ICloneable
    {
        /// <summary>
        /// Get or set "query" configuration element
        /// </summary>
        [ConfigurationSection("cache-query")]
        public QueryElement QueryElement { get; set; }

        [ConfigurationSection("cache-policy")]
        public QueryCachePolicyElement CachePolicy { get; set; }


        #region ICloneable Members

        public object Clone()
        {
            return new QueryPolicyElement()
            {
                QueryElement = this.QueryElement.Clone() as QueryElement,
                CachePolicy = this.CachePolicy.Clone() as QueryCachePolicyElement
            };
        }

        #endregion
    }   
}
