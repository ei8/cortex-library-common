using System;
using System.Collections.Generic;
using System.Text;

namespace ei8.Cortex.Library.Common
{
    public class QueryResult<T> where T : class
    {
        public IEnumerable<T> Items { get; set; }

        public int Count { get; set; }
    }
}
