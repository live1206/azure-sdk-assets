// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Validation result for config server settings. </summary>
    public partial class ConfigServerSettingsValidateResult
    {
        /// <summary> Initializes a new instance of ConfigServerSettingsValidateResult. </summary>
        internal ConfigServerSettingsValidateResult()
        {
            Details = new ChangeTrackingList<ConfigServerSettingsErrorRecord>();
        }

        /// <summary> Initializes a new instance of ConfigServerSettingsValidateResult. </summary>
        /// <param name="isValid"> Indicate if the config server settings are valid. </param>
        /// <param name="details"> The detail validation results. </param>
        internal ConfigServerSettingsValidateResult(bool? isValid, IReadOnlyList<ConfigServerSettingsErrorRecord> details)
        {
            IsValid = isValid;
            Details = details;
        }

        /// <summary> Indicate if the config server settings are valid. </summary>
        public bool? IsValid { get; }
        /// <summary> The detail validation results. </summary>
        public IReadOnlyList<ConfigServerSettingsErrorRecord> Details { get; }
    }
}