using System;
using System.Collections.Generic;
using System.Text;

namespace ei8.Cortex.Library.Common
{
    public class NeuronInfo
    {
        public NeuronInfo()
        {
        }

        public NeuronInfo(NeuronInfo original)
        {
            if (original != null)
            {
                this.Id = original.Id;
                this.Tag = original.Tag;
            }
        }

        public string Id { get; set; }
        public string Tag { get; set; }
    }
}
