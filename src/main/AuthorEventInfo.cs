using System;
using System.Collections.Generic;
using System.Text;

namespace ei8.Cortex.Library.Common
{
    public class AuthorEventInfo
    {
        public AuthorEventInfo()
        {
        }

        public AuthorEventInfo(AuthorEventInfo original)
        {
            if (original != null)
            {
                this.Timestamp = original.Timestamp;
                this.Author = new NeuronInfo(original.Author);
            }
        }

        public string Timestamp { get; set; }

        public NeuronInfo Author { get; set; }
    }
}
