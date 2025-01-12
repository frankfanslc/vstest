﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.IO;

using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions.Interfaces;

#if NETFRAMEWORK || NETSTANDARD2_0

#nullable disable

namespace Microsoft.VisualStudio.TestPlatform.PlatformAbstractions;

public partial class ProcessHelper : IProcessHelper
{
    /// <inheritdoc/>
    public string GetCurrentProcessLocation()
    {
        return Path.GetDirectoryName(GetCurrentProcessFileName());
    }

    public IntPtr GetProcessHandle(int processId)
    {
        return Process.GetProcessById(processId).Handle;
    }

    /// <inheritdoc/>
    public PlatformArchitecture GetCurrentProcessArchitecture()
    {
        return IntPtr.Size == 8 ? PlatformArchitecture.X64 : PlatformArchitecture.X86;
    }
}

#endif
