// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.ComPlus
{
    using System.Collections.Generic;
    using WixToolset.Data.WindowsInstaller;
    using WixToolset.Extensibility;

    public class ComPlusWindowsInstallerBackendBinderExtension : BaseWindowsInstallerBackendBinderExtension
    {
        public override IEnumerable<TableDefinition> TableDefinitions => ComPlusTableDefinitions.All;
    }
}
