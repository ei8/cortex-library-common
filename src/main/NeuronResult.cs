using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ei8.Cortex.Library.Common
{
    public class NeuronResult
    {
        protected IList<string> restrictionReasons;
        public NeuronResult()
        {
            this.restrictionReasons = new List<string>();
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
                this.restrictionReasons = new List<string>(original.RestrictionReasons);
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

        public IEnumerable<string> RestrictionReasons => this.restrictionReasons.ToArray();

        public bool ReadOnly { get; protected set; }

        public void RestrictAccess(AccessType type, string reason)
        {
            if (type == AccessType.Write)
                this.ReadOnly = true;
            else
            {
                this.Id = Guid.Empty.ToString();
                this.Tag = string.Empty;

                if (this.Terminal != null)
                    this.Terminal = new Terminal() { Creation = NeuronResult.CreateAuthorEventInfo() };

                this.Active = true;
                this.Creation = NeuronResult.CreateAuthorEventInfo();
                this.Region = new NeuronInfo();
                this.LastModification = NeuronResult.CreateAuthorEventInfo();
                this.UnifiedLastModification = NeuronResult.CreateAuthorEventInfo();
                this.Version = 0;
            }

            this.restrictionReasons.Add(reason);
        }

        private static AuthorEventInfo CreateAuthorEventInfo()
        {
            return new AuthorEventInfo() { Author = new NeuronInfo() };
        }
    }
}
