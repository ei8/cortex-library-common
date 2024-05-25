using System;
using System.Collections.Generic;

namespace ei8.Cortex.Library.Common
{
    public class DepthIdsPair
    {
        public int Depth { get; set; }
        public IEnumerable<Guid> Ids { get; set; }
    }
}
