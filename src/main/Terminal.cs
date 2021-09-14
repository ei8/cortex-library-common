using System;
using System.Collections.Generic;
using System.Text;

namespace ei8.Cortex.Library.Common
{
    public class Terminal
    {
        public Terminal()
        {
            this.Validation = new ValidationInfo();
        }

        public Terminal(Terminal original) : this()
        {
            if (original != null)
            {
                this.Id = original.Id;
                this.PostsynapticNeuronId = original.PostsynapticNeuronId;
                this.PresynapticNeuronId = original.PresynapticNeuronId;
                this.Effect = original.Effect;
                this.Strength = original.Strength;
                this.Version = original.Version;
                this.Creation = new AuthorEventInfo(original.Creation);
                this.LastModification = new AuthorEventInfo(original.LastModification);
                this.ExternalReferenceUrl = original.ExternalReferenceUrl;
                this.Active = original.Active;
                this.Url = original.Url;
                this.Validation = new ValidationInfo(original.Validation);
            }
        }

        public string Id { get; set; }
        public string PresynapticNeuronId { get; set; }
        public string PostsynapticNeuronId { get; set; }
        public string Effect { get; set; }
        public string Strength { get; set; }
        public int Version { get; set; }
        public AuthorEventInfo Creation { get; set; }
        public AuthorEventInfo LastModification { get; set; }
        public string ExternalReferenceUrl { get; set; }
        public bool Active { get; set; }
        public string Url { get; set; }
        public ValidationInfo Validation { get; set; }
    }
}
