// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The Editable status for Reverse Shipping Address and Contact Info. </summary>
    public enum ReverseShippingDetailsEditStatus
    {
        /// <summary> Reverse shipping details can be edited. </summary>
        Enabled,
        /// <summary> Edit is disabled for Reverse shipping details. </summary>
        Disabled,
        /// <summary> Edit is not supported for Reverse shipping details. Either subscription feature is not available or SKU doesn't support this feature. </summary>
        NotSupported
    }
}