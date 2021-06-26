using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ei8.Cortex.Library.Common
{
    public class NeuronResult
    {
        public NeuronResult()
        {
            this.RestrictionReasons = new string[0];
        }

        public NeuronResult(NeuronResult original) : this()
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
                this.RestrictionReasons = original.RestrictionReasons.ToArray();
                this.ReadOnly = original.ReadOnly;
                this.IsCurrentUserCreationAuthor = original.IsCurrentUserCreationAuthor;
                this.Active = original.Active;
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

        public bool IsCurrentUserCreationAuthor { get; set; }

        public bool Active { get; set; }

        public IEnumerable<string> RestrictionReasons { get; set; }

        public bool ReadOnly { get; set; }
    }
}
