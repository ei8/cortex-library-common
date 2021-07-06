using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ei8.Cortex.Library.Common
{
    public class Neuron
    {
        public Neuron()
        {
            this.Validation = new ValidationInfo();
        }

        public Neuron(Neuron original) : this()
        {
            if (original != null)
            {
                this.Id = original.Id;
                this.Tag = original.Tag;
                this.Terminal = new Terminal(original.Terminal);
                this.Version = original.Version;
                this.Region = new NeuronInfo(original.Region);
                this.Creation = new AuthorEventInfo(original.Creation);
                this.LastModification = new AuthorEventInfo(original.LastModification);
                this.UnifiedLastModification = new AuthorEventInfo(original.UnifiedLastModification);
                this.Active = original.Active;
                this.Validation = new ValidationInfo(original.Validation);
            }
        }        

        public string Id { get; set; }

        public string Tag { get; set; }

        public Terminal Terminal { get; set; }

        [JsonIgnore]
        public RelativeType Type => this.Terminal != null && this.Terminal.PresynapticNeuronId != null ?
            this.Terminal.PresynapticNeuronId.EndsWith(this.Id) ?
                RelativeType.Presynaptic :
                RelativeType.Postsynaptic :
            RelativeType.NotSet;

        public int Version { get; set; }

        public NeuronInfo Region { get; set; }

        public AuthorEventInfo Creation { get; set; }

        public AuthorEventInfo LastModification { get; set; }

        public AuthorEventInfo UnifiedLastModification { get; set; }

        public bool Active { get; set; }

        public ValidationInfo Validation { get; set; }
    }
}
