// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Subscription settings list. </summary>
    internal partial class SettingsList
    {
        /// <summary> Initializes a new instance of SettingsList. </summary>
        internal SettingsList()
        {
            Value = new ChangeTrackingList<SecuritySettingData>();
        }

        /// <summary> Initializes a new instance of SettingsList. </summary>
        /// <param name="value">
        /// The settings list.
        /// Please note <see cref="SecuritySettingData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecurityAlertSyncSettings"/> and <see cref="DataExportSettings"/>.
        /// </param>
        /// <param name="nextLink"> The URI to fetch the next page. </param>
        internal SettingsList(IReadOnlyList<SecuritySettingData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// The settings list.
        /// Please note <see cref="SecuritySettingData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecurityAlertSyncSettings"/> and <see cref="DataExportSettings"/>.
        /// </summary>
        public IReadOnlyList<SecuritySettingData> Value { get; }
        /// <summary> The URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}
