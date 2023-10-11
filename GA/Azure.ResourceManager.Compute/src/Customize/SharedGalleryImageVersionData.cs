// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.ComponentModel;

namespace Azure.ResourceManager.Compute
{
    public partial class SharedGalleryImageVersionData
    {
        /// <summary>
        /// If set to true, Virtual Machines deployed from the latest version of the Image Definition won&apos;t use this Image Version.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool? ExcludeFromLatest { get => IsExcludedFromLatest; }
    }
}
