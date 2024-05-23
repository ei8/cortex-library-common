using System;
using System.Collections.Generic;
using System.Text;

namespace ei8.Cortex.Library.Common
{
    public enum RelativeType
    {
        NotSet,
        Postsynaptic,
        Presynaptic
    }

    [Flags]
    public enum DirectionValues
    {
        None = 0x0,
        Outbound = 0x1,
        Inbound = 0x2,
        Any = Outbound | Inbound
    }

    [Flags]
    public enum RelativeValues
    {
        None = 0x0,
        Postsynaptic = 0x1,
        Presynaptic = 0x2,
        All = Postsynaptic | Presynaptic
    }

    [Flags]
    public enum ActiveValues
    {
        None = 0x0,
        Active = 0x1,
        Inactive = 0x2,
        All = Active | Inactive
    }

    public enum SortByValue
    {
        NeuronTag,
        NeuronCreationTimestamp,
        NeuronCreationAuthorTag,
        NeuronLastModificationTimestamp,
        NeuronLastModificationAuthorTag,
        NeuronUnifiedLastModificationTimestamp,
        NeuronUnifiedLastModificationAuthorTag,
        NeuronActive,
        NeuronRegionTag,
        TerminalEffect,
        TerminalStrength,
        TerminalCreationTimestamp,
        TerminalCreationAuthorTag,
        TerminalLastModificationTimestamp,
        TerminalLastModificationAuthorTag,
        TerminalActive,
        NeuronExternalReferenceUrl,
        TerminalExternalReferenceUrl
    }

    public enum SortOrderValue
    {
        Ascending,
        Descending
    }

    public enum AccessType
    {
        Read,
        Write
    }
}
