﻿using System.Collections.Generic;
using System.Runtime.Versioning;

namespace Microsoft.Net.Runtime.Services
{
    [AssemblyNeutral]
    public interface IMetadataReferenceProvider
    {
        // REVIEW: This is object because we don't have a reference to roslyn in this assembly
        IEnumerable<object> GetReferences(string name, FrameworkName targetFramework);
    }
}
