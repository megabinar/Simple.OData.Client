﻿using System.Collections.Generic;
using System.Linq;

namespace Simple.OData.Client
{
    class ResponseNode
    {
        public IList<IDictionary<string, object>> Feed { get; set; }
        public IDictionary<string, object> Entry { get; set; }
        public IList<object> Collection { get; set; }
        public string LinkName { get; set; }
        public long? TotalCount { get; set; }

        public object Value
        {
            get
            {
                if (this.Feed != null && this.Feed.Any())
                    return this.Feed.AsEnumerable();
                else
                    return this.Entry;

            }
        }
    }
}