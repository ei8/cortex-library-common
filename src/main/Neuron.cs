using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ei8.Cortex.Library.Common
{
    public class Neuron
    {
        public Neuron()
        {
        }

        public Neuron(Neuron original)
        {
            this.Id = original.Id;
            this.Tag = original.Tag;

            if (original.Terminal != null)
                this.Terminal = new Terminal(original.Terminal);

            this.Version = original.Version;
            this.AuthorId = original.AuthorId;
            this.AuthorTag = original.AuthorTag;
            this.RegionId = original.RegionId;
            this.RegionTag = original.RegionTag;
            this.Timestamp = original.Timestamp;
            this.Active = original.Active;
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

        public string AuthorId { get; set; }

        public string AuthorTag { get; set; }

        public string RegionId { get; set; }

        public string RegionTag { get; set; }

        public string Timestamp { get; set; }

        public bool Active { get; set; }
    }
}
