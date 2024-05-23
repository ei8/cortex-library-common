﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ei8.Cortex.Library.Common
{
    public class Traversal
    {
        public IEnumerable<Neuron> Neurons { get; set; }
        public IEnumerable<Terminal> Terminals { get; set; }
    }
}
