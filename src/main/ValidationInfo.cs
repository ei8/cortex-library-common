using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ei8.Cortex.Library.Common
{
    public class ValidationInfo
    {
        public ValidationInfo()
        {
            this.RestrictionReasons = new string[0];
        }

        public ValidationInfo(ValidationInfo original)
        {
            this.RestrictionReasons = original.RestrictionReasons.ToArray();
            this.ReadOnly = original.ReadOnly;
            this.IsCurrentUserCreationAuthor = original.IsCurrentUserCreationAuthor;
        }

        public bool IsCurrentUserCreationAuthor { get; set; }

        public bool ReadOnly { get; set; }

        public IEnumerable<string> RestrictionReasons { get; set; }
    }
}
