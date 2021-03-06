﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ei8.Cortex.Library.Common
{
    public class Terminal
    {
        public Terminal()
        {
        }

        public Terminal(Terminal original)
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
                this.Active = original.Active;
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
        public bool Active { get; set; }
    }
}
